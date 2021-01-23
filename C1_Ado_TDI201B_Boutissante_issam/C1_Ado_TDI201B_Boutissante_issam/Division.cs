using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            command = new SqlCommand("select * from division",connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    idDivision.Items.Add(reader["idDivision"]);
                }
                reader.Close();
                connection.Close();
            }catch(SqlException ex)
            {
                MessageBox.Show("Error : "+ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            command = new SqlCommand($"insert into division values({Nom.Text},{Description.Text});");
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }catch(SqlException ex)
            {
                MessageBox.Show("Error : "+ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            command = new SqlCommand($"delete Division where idDivision={idDivision.SelectedItem}");
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void idDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            command = new SqlCommand($"select nom,description from division where idDivision={idDivision.SelectedItem}");
            try
            {
                SqlDataReader reader= command.ExecuteReader();
                reader.Read();
                Nom.Text = reader["nom"].ToString();
                Description.Text = reader["description"].ToString();

            }catch(SqlException ex)
            {
                MessageBox.Show("Error : "+ex.Message);
            }
        }
    }
}
