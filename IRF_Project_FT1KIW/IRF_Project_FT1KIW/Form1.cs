using IRF_Project_FT1KIW.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project_FT1KIW
{
    public partial class Form1 : BasicForm
    {
        PatientsDBEntities context = new PatientsDBEntities();

        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();         //enélkül errort ad

            patientslb.DisplayMember = "Name";

            context.Table.Load();
            bs.DataSource = context.Table.Local;

            PatientsLoad();
            dgv();
            Pics();

            namelabel.Font = new Font("Calibri", 15, FontStyle.Bold);

            rabbittimer.Interval = 2000;
            horsetimer.Interval = 2000;
            cattimer.Interval = 2000;
            cowtimer.Interval = 2000;
        }

        private void dgv ()
        {
            var p = from x in context.Table
                    where x.Species == ((Table)patientslb.SelectedItem).Species
                    select x;

            dataGridView1.DataSource = p.ToList();

        }

        public void PatientsLoad()
        {
            var patients = from x in context.Table
                          where x.Name.Contains(patientstb.Text)
                          select x;

            patientslb.DataSource = patients.ToList();
        }

        private void Data()
        {
            spcslabel.Text = ((Table)patientslb.SelectedItem).Species;
            doclabel.Text = ((Table)patientslb.SelectedItem).Doctor;
            prblabel.Text = ((Table)patientslb.SelectedItem).Problem;
            agelabel.Text = ((Table)patientslb.SelectedItem).Age.ToString();
            namelabel.Text = ((Table)patientslb.SelectedItem).Name;
        }

        private void Pics()
        {
            // addott fajtához a megfelelő timer elindítása, többi leállítása

            if (((Table)patientslb.SelectedItem).Species == "horse")
            {
                //MessageBox.Show("horsetimer");
                horsetimer.Start();

                cattimer.Stop();
                cowtimer.Stop();
                rabbittimer.Stop();
            }
            if (((Table)patientslb.SelectedItem).Species == "cat")
            {
                //MessageBox.Show("cattimer");
                cattimer.Start();

                horsetimer.Stop();
                cowtimer.Stop();
                rabbittimer.Stop();
            }
            if (((Table)patientslb.SelectedItem).Species == "rabbit")
            {
                //MessageBox.Show("rabbittimer");
                rabbittimer.Start();

                cattimer.Stop();
                cowtimer.Stop();
                horsetimer.Stop();
            }
            else if (((Table)patientslb.SelectedItem).Species == "cow")
            {
                //MessageBox.Show("cowtimer");
                cowtimer.Start();

                cattimer.Stop();
                horsetimer.Stop();
                rabbittimer.Stop();
            }
        }

        private void specieslb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv();
            Data();
            Pics();
        }

        int h = 1;

        private void horsetimer_Tick(object sender, EventArgs e)
        {
            if (h == 6)
            {
                h = 1;
            }

            pictureBox1.Image = Image.FromFile(@"C:\Users\vicah\source\repos\IRF_Project\IRF_Project_FT1KIW\IRF_Project_FT1KIW\Pics\horse" + h + ".jpg");

            h++;
        }

        int r = 1;

        private void rabbittimer_Tick(object sender, EventArgs e)
        {
            if (r == 4)
            {
                r = 1;
            }            

            pictureBox1.Image = Image.FromFile(@"C:\Users\vicah\source\repos\IRF_Project\IRF_Project_FT1KIW\IRF_Project_FT1KIW\Pics\rabbit" + r + ".jpg");

            r++;
        }

        int cat = 1;

        private void cattimer_Tick(object sender, EventArgs e)
        {
            if (cat == 9)
            {
                cat = 1;
            }

            pictureBox1.Image = Image.FromFile(@"C:\Users\vicah\source\repos\IRF_Project\IRF_Project_FT1KIW\IRF_Project_FT1KIW\Pics\cat" + cat + ".jpg");

            cat++;
        }

        int cow = 1;

        private void cowtimer_Tick(object sender, EventArgs e)
        {
            if (cow == 6)
            {
                cow = 1;
            }

            pictureBox1.Image = Image.FromFile(@"C:\Users\vicah\source\repos\IRF_Project\IRF_Project_FT1KIW\IRF_Project_FT1KIW\Pics\cow" + cow + ".jpg");

            cow++;
        }

        private void patientstb_TextChanged(object sender, EventArgs e)
        {
            PatientsLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportForm ef = new ExportForm();
            ef.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string spec = ((Table)patientslb.SelectedItem).Species.ToString();

            List<Table> delpatients;

            delpatients = (from x in context.Table
                           where x.Species == spec
                          select x).ToList();

            //MessageBox.Show(delpatients.Count.ToString());

            foreach (var item in context.Table)
            {
                if (delpatients.Contains(item))
                {
                    //MessageBox.Show("van ilyen");
                    context.Table.Remove(item);
                }
            }

            context.SaveChanges();

            PatientsLoad();
            dgv();
        }
    }
}
