using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C1_Ado_TDI201B_Boutissante_issam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Gestion_Employe());
        }
        void openForm(Form form)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Division());
        }
    }
}
