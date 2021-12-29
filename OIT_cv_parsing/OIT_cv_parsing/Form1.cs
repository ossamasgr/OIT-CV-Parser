using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Microsoft.VisualBasic;

namespace OIT_cv_parsing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ADO d = new ADO();
        signin si = new signin();
     

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            main m = new main();
            panel3.Controls.Add(m);
            m.Dock = DockStyle.Fill;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //------------------Eyakoubi Mohamed---------------------------------------- 
         
            d.CONNECTER();
            string t;
            string c;
            int code;
            d.cmd.CommandText = "select ConfEmail from login where UserName = '" + signin.TextBoxValue + "'";
            d.cmd.Connection = d.cnx;
            t = (string)d.cmd.ExecuteScalar();
            if (t == "non")
            {
                if ((MessageBox.Show("svp vérifier ton email pour confirmation", "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)) == DialogResult.Yes)
                {
  
                    bunifuFlatButton1.Enabled = false;
                    d.cmd.CommandText = "select Email from login where UserName = '" + signin.TextBoxValue + "'";
                    d.cmd.Connection = d.cnx;
                    c = (string)d.cmd.ExecuteScalar();
                    int min = 100000;
                    int max = 999999;
                    Random random = new Random();
                    code = random.Next(min, max);
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("devdev081122@gmail.com");
                    mail.To.Add(c);
                    mail.Subject = "Code confirmation";
                    mail.Body = "Hi  "+ signin.TextBoxValue + " , \n Thank you for your registration \n here is your confirmation code : " + code.ToString() + "\n thank you.";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("devdev081122@gmail.com", "rozicxyvbslfamds");
                    smtp.Send(mail);

                    
                    if (Interaction.InputBox("Entre le code ", "Confirm email") == code.ToString())
                    {
                        d.cmd.CommandText = "UPDATE login SET ConfEmail='oui' WHERE UserName='" + signin.TextBoxValue + "'";
                        d.cmd.Connection = d.cnx;
                        d.cmd.ExecuteNonQuery();
                        MessageBox.Show("Cette opération s'est terminée avec succès");
                        bunifuFlatButton1.Enabled = true;
                    }
                     if (Interaction.InputBox("Entre le code ", "Confirm email") != code.ToString())
                    {
                        

                            int n = 3;
                            for (int i = 0; i < n; i++)
                            {
                                MessageBox.Show("Code incorrect");
                                if (Interaction.InputBox("Entre le code ", "Confirm email") == code.ToString())
                                {
                                    d.cmd.CommandText = "UPDATE login SET ConfEmail='oui' WHERE UserName='" + signin.TextBoxValue + "'";
                                    d.cmd.Connection = d.cnx;
                                    d.cmd.ExecuteNonQuery();
                                    MessageBox.Show("Cette opération s'est terminée avec succès");
                                    bunifuFlatButton1.Enabled = true;
                                    return;
                                }
                                i++;
                            }
                      }
                       else
                       {
                       
                        }
                 }
                    return;
                    //------------------------------------------------------------------------
               
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            bunifuFlatButton1.Visible = false;
            pictureBox1.Visible = false;
            label1.Visible = false;
            main m = new main();
            panel3.Controls.Add(m);
            m.Dock = DockStyle.Fill;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            About a = new About();
            panel3.Controls.Add(a);
            a.Dock = DockStyle.Fill;
        }

    }
}
