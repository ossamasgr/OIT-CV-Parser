using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OIT_cv_parsing
{
    public partial class main : UserControl
    {
        public DataTable readCSV;
        public main()
        {
            InitializeComponent();
        }



        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try 
            {
                OpenFileDialog dialog = new OpenFileDialog();
                //dialog.Filter = "Text files | *.txt"; // file types, that will be allowed to upload
                dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
                if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
                {
                    String path = dialog.FileName; // get name of file
                    label2.Text = path;

                    var result = JsonConvert.DeserializeObject(File.ReadAllText(path)); ;
                    bunifuCustomDataGrid1.DataSource = result;
                    using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                    {
                        // ...
                    }
                    bunifuCircleProgressbar1.Value = 70;
                }   
            }
            catch(Exception ex){}
            

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void main_Load(object sender, System.EventArgs e)
        {
            
        }
    }
}
