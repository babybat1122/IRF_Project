using IRF_Project_FT1KIW.ORM;
using IRF_Project_FT1KIW.UCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project_FT1KIW
{
    public partial class ExportForm : Form
    {
        public ExportForm()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DocUC docuc = new DocUC();
            panel1.Controls.Add(docuc);
            docuc.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
