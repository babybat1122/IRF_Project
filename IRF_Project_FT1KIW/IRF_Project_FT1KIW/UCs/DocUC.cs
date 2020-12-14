using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IRF_Project_FT1KIW.ORM;
using System.IO;

namespace IRF_Project_FT1KIW.UCs
{
    public partial class DocUC : UserControl
    {
        PatientsDBEntities context = new PatientsDBEntities();

        public DocUC()
        {
            InitializeComponent();

            List<string> names = new List<string>
            {
                "Dr. Nagy Sándor",
                "Dr. Nagyné Béres Anna"
            };

            doclb.DataSource = names;

            dgv();
        }

        private void dgv()
        {
            var p = from x in context.Table
                    where x.Doctor == doclb.SelectedItem.ToString()
                    select x;

            dataGridView1.DataSource = p.ToList();
        }

        private void doclb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() != DialogResult.OK) return;

            List<Table> toexp;

            var patients = from x in context.Table
                           where x.Doctor.Contains(doclb.SelectedItem.ToString())
                           select x;

            toexp = patients.ToList();

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                sw.Write(doclb.SelectedItem.ToString());
                sw.Write(" betegei, " + DateTime.Today.ToString("dd/MM/yyyy"));
                sw.WriteLine();

                foreach (var p in toexp)
                {
                    sw.Write(p.Name);
                    sw.Write(";");
                    sw.Write(p.Species);
                    sw.Write(";");
                    sw.Write(p.Age.ToString());
                    sw.Write(";");
                    sw.Write(p.Problem);
                    sw.Write(";");
                    sw.Write(p.Treatment);
                    sw.WriteLine();
                }
            }
        }
    }
}
