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

            specieslb.DisplayMember = "Species";

            context.Table.Load();
            bs.DataSource = context.Table.Local;

            SpeciesLoad();
            dgv();
        }

        private void dgv ()
        {
            var p = from x in context.Table
                    where x.Species == ((Table)specieslb.SelectedItem).Species
                    select x;

            dataGridView1.DataSource = p.ToList();

        }

        private void SpeciesLoad()
        {
            var species = from x in context.Table
                          where x.Species.Contains(speciestb.Text)
                          select x;

            specieslb.DataSource = species.ToList();
        }

        private void specieslb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv();
        }
    }
}
