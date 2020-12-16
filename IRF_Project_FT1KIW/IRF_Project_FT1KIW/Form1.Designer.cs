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
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prblabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.doclabel = new System.Windows.Forms.Label();
            this.patientslb = new System.Windows.Forms.ListBox();
            this.patientstb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.agelabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.horsetimer = new System.Windows.Forms.Timer(this.components);
            this.rabbittimer = new System.Windows.Forms.Timer(this.components);
            this.cattimer = new System.Windows.Forms.Timer(this.components);
            this.cowtimer = new System.Windows.Forms.Timer(this.components);
            this.labelsok = new System.Windows.Forms.Label();
            this.spcslabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(894, 178);
            this.dataGridView1.TabIndex = 0;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(IRF_Project_FT1KIW.ORM.Table);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patients:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Problem:";
            // 
            // prblabel
            // 
            this.prblabel.AutoSize = true;
            this.prblabel.Location = new System.Drawing.Point(306, 137);
            this.prblabel.Name = "prblabel";
            this.prblabel.Size = new System.Drawing.Size(65, 20);
            this.prblabel.TabIndex = 5;
            this.prblabel.Text = "prblabel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Doctor:";
            // 
            // doclabel
            // 
            this.doclabel.AutoSize = true;
            this.doclabel.Location = new System.Drawing.Point(306, 101);
            this.doclabel.Name = "doclabel";
            this.doclabel.Size = new System.Drawing.Size(68, 20);
            this.doclabel.TabIndex = 9;
            this.doclabel.Text = "doclabel";
            // 
            // patientslb
            // 
            this.patientslb.FormattingEnabled = true;
            this.patientslb.ItemHeight = 20;
            this.patientslb.Location = new System.Drawing.Point(12, 91);
            this.patientslb.Name = "patientslb";
            this.patientslb.Size = new System.Drawing.Size(120, 124);
            this.patientslb.TabIndex = 10;
            this.patientslb.SelectedIndexChanged += new System.EventHandler(this.specieslb_SelectedIndexChanged);
            // 
            // patientstb
            // 
            this.patientstb.Location = new System.Drawing.Point(12, 59);
            this.patientstb.Name = "patientstb";
            this.patientstb.Size = new System.Drawing.Size(120, 26);
            this.patientstb.TabIndex = 11;
            this.patientstb.TextChanged += new System.EventHandler(this.patientstb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Age: ";
            // 
            // agelabel
            // 
            this.agelabel.AutoSize = true;
            this.agelabel.Location = new System.Drawing.Point(306, 173);
            this.agelabel.Name = "agelabel";
            this.agelabel.Size = new System.Drawing.Size(69, 20);
            this.agelabel.TabIndex = 13;
            this.agelabel.Text = "agelabel";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.ForeColor = System.Drawing.Color.Maroon;
            this.namelabel.Location = new System.Drawing.Point(198, 20);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(51, 20);
            this.namelabel.TabIndex = 14;
            this.namelabel.Text = "label5";
            // 
            // horsetimer
            // 
            this.horsetimer.Tick += new System.EventHandler(this.horsetimer_Tick);
            // 
            // rabbittimer
            // 
            this.rabbittimer.Interval = 5000;
            this.rabbittimer.Tick += new System.EventHandler(this.rabbittimer_Tick);
            // 
            // cattimer
            // 
            this.cattimer.Tick += new System.EventHandler(this.cattimer_Tick);
            // 
            // cowtimer
            // 
            this.cowtimer.Tick += new System.EventHandler(this.cowtimer_Tick);
            // 
            // labelsok
            // 
            this.labelsok.AutoSize = true;
            this.labelsok.Location = new System.Drawing.Point(198, 67);
            this.labelsok.Name = "labelsok";
            this.labelsok.Size = new System.Drawing.Size(70, 20);
            this.labelsok.TabIndex = 15;
            this.labelsok.Text = "Species:";
            // 
            // spcslabel
            // 
            this.spcslabel.AutoSize = true;
            this.spcslabel.Location = new System.Drawing.Point(306, 67);
            this.spcslabel.Name = "spcslabel";
            this.spcslabel.Size = new System.Drawing.Size(75, 20);
            this.spcslabel.TabIndex = 16;
            this.spcslabel.Text = "spcslabel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(8, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Other patients of the same species:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(950, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 60);
            this.button1.TabIndex = 18;
            this.button1.Text = "Data Export";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(950, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 61);
            this.button2.TabIndex = 19;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(912, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Delete all of this species:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(411, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1144, 494);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.spcslabel);
            this.Controls.Add(this.labelsok);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.agelabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.patientstb);
            this.Controls.Add(this.patientslb);
            this.Controls.Add(this.doclabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prblabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Other patients from the same species:";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label doclabel;
        private System.Windows.Forms.ListBox patientslb;
        private System.Windows.Forms.TextBox patientstb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label agelabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Timer horsetimer;
        private System.Windows.Forms.Timer rabbittimer;
        private System.Windows.Forms.Timer cattimer;
        private System.Windows.Forms.Timer cowtimer;
        private System.Windows.Forms.Label labelsok;
        private System.Windows.Forms.Label spcslabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}

