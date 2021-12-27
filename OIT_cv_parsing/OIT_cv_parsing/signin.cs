using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace OIT_cv_parsing
{
    public partial class signin : UserControl
    {
        ADO d = new ADO();
        public signin()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                bunifuMaterialTextbox2.isPassword = false;

            }
            else
                bunifuMaterialTextbox2.isPassword = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            // log in code 
            // checking the database for password:
            d.cmd = new SqlCommand("select count (*) from login where UserName = '" + bunifuMaterialTextbox1.Text+ "' and password = '" + bunifuMaterialTextbox2.Text + "'", d.cnx);
            d.CONNECTER();
            int i = (int)d.cmd.ExecuteScalar();
            if (i == 1)
            {
                Form1 m = new Form1();
                m.Show();
                this.Hide();
            }
            else if (i == 0)
            {
                MessageBox.Show("information incorrect");
            }
            d.DECONNECTER();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
