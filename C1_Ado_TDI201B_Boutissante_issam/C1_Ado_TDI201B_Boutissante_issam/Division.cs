using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C1_Ado_TDI201B_Boutissante_issam
{
    public partial class Division : Form
    {
        static string conString = "data source=.;database=zaikay;integrated security=true";
        SqlConnection connection = new SqlConnection(conString);
        SqlCommand command;
        public Division()
        {
            InitializeComponent();
        }

        private void idDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            command = new SqlCommand($"select nom,description from division where idDivision={idDivision.SelectedItem}",connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                Nom.Text = reader["nom"].ToString();
                Description.Text = reader["description"].ToString();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error : "+ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Vider_Click(object sender, EventArgs e)
        {
            foreach (var control in this.Controls)
                if (control is TextBox) ((TextBox)control).Clear();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            command = new SqlCommand($"insert into division values('{Nom.Text}','{Description.Text}');",connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("division a ete ajoute");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {

        }

        private void idDivision_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("select idDivision from division;", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) idDivision.Items.Add(reader["idDivision"]);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
