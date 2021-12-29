using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OIT_cv_parsing
{
    public partial class signup : UserControl
    {
        ADO d = new ADO();
        public signup()
        {
            InitializeComponent();
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                bunifuMaterialTextbox2.isPassword = false;
                bunifuMaterialTextbox3.isPassword = false;
            }
            else
            {
                bunifuMaterialTextbox2.isPassword = true;
                bunifuMaterialTextbox3.isPassword = true;
            }

            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            if (bunifuMaterialTextbox1.Text != "" && bunifuMaterialTextbox2.Text != "" && bunifuMaterialTextbox3.Text != "")  
            {
                if (bunifuMaterialTextbox2.Text.ToString().Trim().ToLower() == bunifuMaterialTextbox3.Text.ToString().Trim().ToLower()) 
                {
                    string FullName = bunifuMaterialTextbox6.Text;
                    string Username = bunifuMaterialTextbox1.Text;
                    string Company = bunifuMaterialTextbox4.Text;
                    string Email = bunifuMaterialTextbox1.Text;
                    string Password = Cryptography.Encrypt(bunifuMaterialTextbox2.Text.ToString());
                    d.CONNECTER();
                   d.cmd  = new SqlCommand("insert into login(FullName,Username,Company,Email,Password)values('" + FullName + "','" + Username + "','" + Company + "','" + Email + "','" + Password + "')", d.cnx);
                    d.cmd.ExecuteNonQuery();
                    d.DECONNECTER();
                    MessageBox.Show("Record inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password doesn't match!.. Please Check..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);  
            }
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox3.Text == bunifuMaterialTextbox2.Text)
            {
                label2.Visible = false;
            }
            else
            {
                label2.Text = "Vérifier votre mot de passe";
                label2.Visible = true;
            }
>>>>>>> bba56c88950a3b1d1500a21cdc59ac6784af01b9
        }
    }
}
