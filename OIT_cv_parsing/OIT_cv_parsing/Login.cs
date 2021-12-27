using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OIT_cv_parsing
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            label2.Visible = false;
            signup s = new signup();
            panel1.Controls.Add(s);
            s.Dock = DockStyle.Fill;
            label4.Visible = true;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Form1 m = new Form1();
            m.Show();
            this.Hide();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            label2.Visible = true;
            label4.Visible = false;
            signin s = new signin();
            panel1.Controls.Add(s);
            s.Dock = DockStyle.Fill;

        }

        private void Login_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            signin s = new signin();
            panel1.Controls.Add(s);
            s.Dock = DockStyle.Fill;
        }
    }
}
