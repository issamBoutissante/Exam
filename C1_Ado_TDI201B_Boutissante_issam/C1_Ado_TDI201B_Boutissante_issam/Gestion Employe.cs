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
    public partial class Gestion_Employe : Form
    {
        static string conString = "data source=.;database=zaikay;integrated security=true";
        SqlConnection connection=new SqlConnection(conString);
        SqlDataAdapter employeAdapter;
        DataSet dataSet=new DataSet();
        BindingManagerBase bmbEmploye;
        public Gestion_Employe()
        {
            InitializeComponent();
        }

        private void Gestion_Employe_Load(object sender, EventArgs e)
        {
            employeAdapter = new SqlDataAdapter("select * from employe", connection);
            employeAdapter.Fill(dataSet, "employe");

            bmbEmploye = BindingContext[dataSet.Tables["employe"]];
            dataGridView1.DataSource = dataSet.Tables["employe"];

            Email.DataBindings.Add("Text", dataSet.Tables["employe"], "email");
            Nom.DataBindings.Add("Text", dataSet.Tables["employe"], "nom");

            DateEmbauche.DataBindings.Add("Text", dataSet.Tables["employe"], "dateEmbauche");
            Division.DataBindings.Add("Text", dataSet.Tables["employe"], "idDivision");
            Adresse.DataBindings.Add("Text", dataSet.Tables["employe"], "adresse");
            //OuiRadio.DataBindings.Add("Text", dataSet.Tables["emplye"], "email");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
