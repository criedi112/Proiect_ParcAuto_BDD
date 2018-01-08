namespace BDD_interface_like
{
    partial class Form_ModificaAngajati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ModificaAngajati));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_concediaza = new System.Windows.Forms.Button();
            this.btn_modificaAngajat = new System.Windows.Forms.Button();
            this.btn_ListareAngajati = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_addAdmin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(618, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_concediaza
            // 
            this.btn_concediaza.Location = new System.Drawing.Point(510, 43);
            this.btn_concediaza.Name = "btn_concediaza";
            this.btn_concediaza.Size = new System.Drawing.Size(104, 34);
            this.btn_concediaza.TabIndex = 1;
            this.btn_concediaza.Text = "Concediaza";
            this.btn_concediaza.UseVisualStyleBackColor = true;
            this.btn_concediaza.Click += new System.EventHandler(this.btn_concediaza_Click);
            // 
            // btn_modificaAngajat
            // 
            this.btn_modificaAngajat.Location = new System.Drawing.Point(400, 43);
            this.btn_modificaAngajat.Name = "btn_modificaAngajat";
            this.btn_modificaAngajat.Size = new System.Drawing.Size(104, 34);
            this.btn_modificaAngajat.TabIndex = 2;
            this.btn_modificaAngajat.Text = "Modifica Angajat";
            this.btn_modificaAngajat.UseVisualStyleBackColor = true;
            this.btn_modificaAngajat.Click += new System.EventHandler(this.btn_modificaAngajat_Click);
            // 
            // btn_ListareAngajati
            // 
            this.btn_ListareAngajati.Location = new System.Drawing.Point(290, 43);
            this.btn_ListareAngajati.Name = "btn_ListareAngajati";
            this.btn_ListareAngajati.Size = new System.Drawing.Size(104, 34);
            this.btn_ListareAngajati.TabIndex = 3;
            this.btn_ListareAngajati.Text = "Listeaza Angajati";
            this.btn_ListareAngajati.UseVisualStyleBackColor = true;
            this.btn_ListareAngajati.Click += new System.EventHandler(this.btn_ListareAngajati_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_addAdmin
            // 
            this.btn_addAdmin.Location = new System.Drawing.Point(400, 84);
            this.btn_addAdmin.Name = "btn_addAdmin";
            this.btn_addAdmin.Size = new System.Drawing.Size(104, 38);
            this.btn_addAdmin.TabIndex = 5;
            this.btn_addAdmin.Text = "Adauga ca Administrator";
            this.btn_addAdmin.UseVisualStyleBackColor = true;
            this.btn_addAdmin.Click += new System.EventHandler(this.btn_addAdmin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Adaugare Angajat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(510, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Concediere administrator";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_ModificaAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 356);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_addAdmin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_ListareAngajati);
            this.Controls.Add(this.btn_modificaAngajat);
            this.Controls.Add(this.btn_concediaza);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_ModificaAngajati";
            this.Text = "Form_ModificaAngajati";
            this.Load += new System.EventHandler(this.Form_ModificaAngajati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_concediaza;
        private System.Windows.Forms.Button btn_modificaAngajat;
        private System.Windows.Forms.Button btn_ListareAngajati;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_addAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}