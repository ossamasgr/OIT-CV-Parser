using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OIT_cv_parsing
{
    public partial class signup : UserControl
    {
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
    }
}
