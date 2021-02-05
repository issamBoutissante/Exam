using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C1_Ado_TDI201B_Boutissante_issam
{
    public partial class Gestion_Employe : Form
    {
        static string conString = "data source=.;database=zaikay;integrated security=true";
        SqlConnection connection=new SqlConnection(conString);
        SqlDataAdapter employeAdapter;
        SqlDataAdapter divisionAdapter;
        DataSet dataSet=new DataSet();
        BindingManagerBase bmbEmploye;

        public Gestion_Employe()
        {
            InitializeComponent();
        }

        private void Gestion_Employe_Load(object sender, EventArgs e)
        {
            divisionAdapter = new SqlDataAdapter("select idDivision from division;",connection);
            divisionAdapter.Fill(dataSet, "division");

            employeAdapter = new SqlDataAdapter("select * from employe", connection);
            employeAdapter.Fill(dataSet, "employe");
            
            bmbEmploye = BindingContext[dataSet.Tables["employe"]];

            Email.DataBindings.Add("Text", dataSet.Tables["employe"], "email");
            Nom.DataBindings.Add("Text", dataSet.Tables["employe"], "nom");

            DateEmbauche.DataBindings.Add("Text", dataSet.Tables["employe"], "dateEmbauche");
            Adresse.DataBindings.Add("Text", dataSet.Tables["employe"], "adresse");
            OuiRadio.DataBindings.Add("Checked", dataSet.Tables["employe"], "responsable");
            OuiRadio.CheckedChanged += (object o, EventArgs ex) =>
            {
                var r=(RadioButton)o;
                if (!r.Checked) NonRadio.Checked = true;
                EmpoyedataGridView.Refresh();
            };
            EmpoyedataGridView.DataSource = dataSet.Tables["employe"];
            Division.DataSource = dataSet.Tables["division"];
            Division.DisplayMember = "idDivision";
            Division.ValueMember = "idDivision";
        }

        private void T_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("i changed");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bmbEmploye.AddNew();
        }

        private void NonRadio_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("non radio is : "+NonRadio.Checked.ToString());
            //MessageBox.Show("oui radio is : "+OuiRadio.Checked.ToString());
        }

        private void OuiRadio_CheckedChanged(object sender, EventArgs e)
        {
           // MessageBox.Show("non radio is : " + NonRadio.Checked.ToString());
            //MessageBox.Show("oui radio is : " + OuiRadio.Checked.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmbEmploye.Position = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bmbEmploye.Position--;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bmbEmploye.Position++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bmbEmploye.Position = bmbEmploye.Count - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var control in this.Controls) 
                if (control is TextBox) ((TextBox)control).Clear();
        }
    }
}
