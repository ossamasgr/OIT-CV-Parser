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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
