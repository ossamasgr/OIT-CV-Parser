﻿using System;
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
using System.Net;
using System.Net.Mail;


namespace OIT_cv_parsing
{
    public partial class signin : UserControl
    {
        ADO d = new ADO();
        public static string TextBoxValue;
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
<<<<<<< HEAD
            d.cmd = new SqlCommand("select count (*) from login where UserName = '" + bunifuMaterialTextbox1.Text+ "' and password = '" + bunifuMaterialTextbox2.Text + "'", d.cnx);
            
            int i = (int)d.cmd.ExecuteScalar();
            if (i == 1)
            {
                TextBoxValue = bunifuMaterialTextbox1.Text;
                Form1 m = new Form1();
                m.Show();
                this.Hide();


              
            }


            else if (i == 0)
            {
                MessageBox.Show("information incorrect");
            }
            
=======
            /* d.cmd = new SqlCommand("select count (*) from login where Username = '" + bunifuMaterialTextbox1.Text+ "' and Password = '" + bunifuMaterialTextbox2.Text + "'", d.cnx);
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
             d.DECONNECTER();*/

            string Password = "";
            bool IsExist = false;
            d.CONNECTER();
            d.cmd = new SqlCommand("select * from login where Username='" + bunifuMaterialTextbox1.Text + "'", d.cnx);
            d.dr = d.cmd.ExecuteReader();
            if (d.dr.Read())
            {
                Password = d.dr.GetString(4);
                IsExist = true;
            }
            d.DECONNECTER();
            {
                if (Cryptography.Decrypt(Password).Equals(bunifuMaterialTextbox2.Text))
                {
                    MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 m = new Form1();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password is wrong!...", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
           /* else
            {
                MessageBox.Show("Please enter the valid credentials", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
>>>>>>> bba56c88950a3b1d1500a21cdc59ac6784af01b9

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

        private void signin_Load(object sender, EventArgs e)
        {
            d.CONNECTER();
        }
    }
}
