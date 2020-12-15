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

            pictureBox2.Image = Image.FromFile(@"C:\Users\vicah\source\repos\IRF_Project\IRF_Project_FT1KIW\IRF_Project_FT1KIW\Icons\stethoscope.png");

            pictureBox1.Image = Image.FromFile(@"C:\Users\vicah\source\repos\IRF_Project\IRF_Project_FT1KIW\IRF_Project_FT1KIW\Icons\pawprint.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DocUC docuc = new DocUC();
            panel1.Controls.Add(docuc);
            docuc.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            SpecUC specuc = new SpecUC();
            panel1.Controls.Add(specuc);
            specuc.Dock = DockStyle.Fill;
        }
    }
}
