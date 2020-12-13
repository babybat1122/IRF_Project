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
    public partial class Form1 : Form
    {
        PatientsDBEntities context = new PatientsDBEntities();

        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();         //enélkül errort ad

            bs.DataSource = context.Table.Local;

            patientslb.DisplayMember = "Name";

            context.Table.Load();
            bs.DataSource = context.Table.Local;

            PatientsLoad();
            dgv();
        }

        private void dgv ()
        {
            var p = from x in context.Table
                    where x.Species == ((Table)patientslb.SelectedItem).Species
                    select x;

            dataGridView1.DataSource = p.ToList();

        }

        private void PatientsLoad()
        {
            var patients = from x in context.Table
                          where x.Name.Contains(patientstb.Text)
                          select x;

            patientslb.DataSource = patients.ToList();
        }

        private void specieslb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv();
        }

        private void patientstb_TextChanged(object sender, EventArgs e)
        {
            PatientsLoad();
        }
    }
}
