namespace IRF_Project_FT1KIW
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prblabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.doclabel = new System.Windows.Forms.Label();
            this.patientslb = new System.Windows.Forms.ListBox();
            this.patientstb = new System.Windows.Forms.TextBox();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.agelabel = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namelabel = new System.Windows.Forms.Label();
            this.horsetimer = new System.Windows.Forms.Timer(this.components);
            this.rabbittimer = new System.Windows.Forms.Timer(this.components);
            this.cattimer = new System.Windows.Forms.Timer(this.components);
            this.cowtimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.speciesDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.problemDataGridViewTextBoxColumn,
            this.treatmentDataGridViewTextBoxColumn,
            this.doctorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bs;
            this.dataGridView1.Location = new System.Drawing.Point(12, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(955, 144);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(721, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 146);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patients:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Problem:";
            // 
            // prblabel
            // 
            this.prblabel.AutoSize = true;
            this.prblabel.Location = new System.Drawing.Point(273, 110);
            this.prblabel.Name = "prblabel";
            this.prblabel.Size = new System.Drawing.Size(65, 20);
            this.prblabel.TabIndex = 5;
            this.prblabel.Text = "prblabel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Doctor:";
            // 
            // doclabel
            // 
            this.doclabel.AutoSize = true;
            this.doclabel.Location = new System.Drawing.Point(273, 76);
            this.doclabel.Name = "doclabel";
            this.doclabel.Size = new System.Drawing.Size(68, 20);
            this.doclabel.TabIndex = 9;
            this.doclabel.Text = "doclabel";
            // 
            // patientslb
            // 
            this.patientslb.FormattingEnabled = true;
            this.patientslb.ItemHeight = 20;
            this.patientslb.Location = new System.Drawing.Point(12, 76);
            this.patientslb.Name = "patientslb";
            this.patientslb.Size = new System.Drawing.Size(120, 124);
            this.patientslb.TabIndex = 10;
            this.patientslb.SelectedIndexChanged += new System.EventHandler(this.specieslb_SelectedIndexChanged);
            // 
            // patientstb
            // 
            this.patientstb.Location = new System.Drawing.Point(12, 44);
            this.patientstb.Name = "patientstb";
            this.patientstb.Size = new System.Drawing.Size(120, 26);
            this.patientstb.TabIndex = 11;
            this.patientstb.TextChanged += new System.EventHandler(this.patientstb_TextChanged);
            // 
            // bs
            // 
            this.bs.DataSource = typeof(IRF_Project_FT1KIW.ORM.Table);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Age: ";
            // 
            // agelabel
            // 
            this.agelabel.AutoSize = true;
            this.agelabel.Location = new System.Drawing.Point(277, 146);
            this.agelabel.Name = "agelabel";
            this.agelabel.Size = new System.Drawing.Size(69, 20);
            this.agelabel.TabIndex = 13;
            this.agelabel.Text = "agelabel";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // speciesDataGridViewTextBoxColumn
            // 
            this.speciesDataGridViewTextBoxColumn.DataPropertyName = "Species";
            this.speciesDataGridViewTextBoxColumn.HeaderText = "Species";
            this.speciesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.speciesDataGridViewTextBoxColumn.Name = "speciesDataGridViewTextBoxColumn";
            this.speciesDataGridViewTextBoxColumn.Width = 150;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 40;
            // 
            // problemDataGridViewTextBoxColumn
            // 
            this.problemDataGridViewTextBoxColumn.DataPropertyName = "Problem";
            this.problemDataGridViewTextBoxColumn.HeaderText = "Problem";
            this.problemDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.problemDataGridViewTextBoxColumn.Name = "problemDataGridViewTextBoxColumn";
            this.problemDataGridViewTextBoxColumn.Width = 150;
            // 
            // treatmentDataGridViewTextBoxColumn
            // 
            this.treatmentDataGridViewTextBoxColumn.DataPropertyName = "Treatment";
            this.treatmentDataGridViewTextBoxColumn.HeaderText = "Treatment";
            this.treatmentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.treatmentDataGridViewTextBoxColumn.Name = "treatmentDataGridViewTextBoxColumn";
            this.treatmentDataGridViewTextBoxColumn.Width = 150;
            // 
            // doctorDataGridViewTextBoxColumn
            // 
            this.doctorDataGridViewTextBoxColumn.DataPropertyName = "Doctor";
            this.doctorDataGridViewTextBoxColumn.HeaderText = "Doctor";
            this.doctorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.doctorDataGridViewTextBoxColumn.Name = "doctorDataGridViewTextBoxColumn";
            this.doctorDataGridViewTextBoxColumn.Width = 150;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(224, 33);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(51, 20);
            this.namelabel.TabIndex = 14;
            this.namelabel.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 364);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.agelabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.patientstb);
            this.Controls.Add(this.patientslb);
            this.Controls.Add(this.doclabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prblabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label prblabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label doclabel;
        private System.Windows.Forms.ListBox patientslb;
        private System.Windows.Forms.TextBox patientstb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label agelabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Timer horsetimer;
        private System.Windows.Forms.Timer rabbittimer;
        private System.Windows.Forms.Timer cattimer;
        private System.Windows.Forms.Timer cowtimer;
    }
}

