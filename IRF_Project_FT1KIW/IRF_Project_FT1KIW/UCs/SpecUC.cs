using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IRF_Project_FT1KIW.ORM;

namespace IRF_Project_FT1KIW.UCs
{
    public partial class SpecUC : UCClass
    {
        PatientsDBEntities context = new PatientsDBEntities();

        public SpecUC()
        {
            InitializeComponent();

            List<string> species = new List<string>
            {
                "horse",
                "rabbit",
                "cow",
                "cat"
            };

            speclb.DataSource = species;

            DGs dataGridView1 = new DGs();

            dgv();
        }

        private void dgv()
        {
            var p = from x in context.Table
                    where x.Species == speclb.SelectedItem.ToString()
                    select x;

            dataGridView1.DataSource = p.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() != DialogResult.OK) return;

            List<Table> toexp;

            var patients = from x in context.Table
                           where x.Species.Contains(speclb.SelectedItem.ToString())
                           select x;

            toexp = patients.ToList();

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                sw.Write(speclb.SelectedItem.ToString() + "s, " + DateTime.Today.ToString("dd / MM / yyyy") + ":");
                sw.WriteLine();

                foreach (var p in toexp)
                {
                    sw.Write(p.Name);
                    sw.Write(";");                    
                    sw.Write(p.Age.ToString());
                    sw.Write(";");
                    sw.Write(p.Problem);
                    sw.Write(";");
                    sw.Write(p.Treatment);
                    sw.Write(";");
                    sw.Write(p.Doctor);
                    sw.WriteLine();
                }
            }
        }

        private void speclb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv();
        }
    }
}
