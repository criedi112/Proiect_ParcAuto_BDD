namespace BDD_interface_like
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_AddCar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_DezCar = new System.Windows.Forms.Button();
            this.btn_SellCar = new System.Windows.Forms.Button();
            this.btn_avarii = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_optiuni = new System.Windows.Forms.Button();
            this.btn_cautare = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddCar
            // 
            this.btn_AddCar.Location = new System.Drawing.Point(196, 49);
            this.btn_AddCar.Name = "btn_AddCar";
            this.btn_AddCar.Size = new System.Drawing.Size(100, 33);
            this.btn_AddCar.TabIndex = 0;
            this.btn_AddCar.Text = "Adauga Masina";
            this.btn_AddCar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(706, 223);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_DezCar
            // 
            this.btn_DezCar.Location = new System.Drawing.Point(617, 49);
            this.btn_DezCar.Name = "btn_DezCar";
            this.btn_DezCar.Size = new System.Drawing.Size(101, 33);
            this.btn_DezCar.TabIndex = 3;
            this.btn_DezCar.Text = "Dezmembrari";
            this.btn_DezCar.UseVisualStyleBackColor = true;
            // 
            // btn_SellCar
            // 
            this.btn_SellCar.Location = new System.Drawing.Point(311, 49);
            this.btn_SellCar.Name = "btn_SellCar";
            this.btn_SellCar.Size = new System.Drawing.Size(106, 33);
            this.btn_SellCar.TabIndex = 4;
            this.btn_SellCar.Text = "Vinde Masina";
            this.btn_SellCar.UseVisualStyleBackColor = true;
            // 
            // btn_avarii
            // 
            this.btn_avarii.Location = new System.Drawing.Point(13, 139);
            this.btn_avarii.Name = "btn_avarii";
            this.btn_avarii.Size = new System.Drawing.Size(105, 23);
            this.btn_avarii.TabIndex = 5;
            this.btn_avarii.Text = "Verifica Avarii ";
            this.btn_avarii.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_optiuni
            // 
            this.btn_optiuni.Location = new System.Drawing.Point(150, 139);
            this.btn_optiuni.Name = "btn_optiuni";
            this.btn_optiuni.Size = new System.Drawing.Size(113, 23);
            this.btn_optiuni.TabIndex = 7;
            this.btn_optiuni.Text = "Optiuni Masina";
            this.btn_optiuni.UseVisualStyleBackColor = true;
            // 
            // btn_cautare
            // 
            this.btn_cautare.Location = new System.Drawing.Point(294, 139);
            this.btn_cautare.Name = "btn_cautare";
            this.btn_cautare.Size = new System.Drawing.Size(95, 23);
            this.btn_cautare.TabIndex = 8;
            this.btn_cautare.Text = "Filtru Cautare";
            this.btn_cautare.UseVisualStyleBackColor = true;
            this.btn_cautare.Click += new System.EventHandler(this.btn_cautare_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(166, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(315, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 403);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_cautare);
            this.Controls.Add(this.btn_optiuni);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_avarii);
            this.Controls.Add(this.btn_SellCar);
            this.Controls.Add(this.btn_DezCar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_AddCar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.Tan;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddCar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_DezCar;
        private System.Windows.Forms.Button btn_SellCar;
        private System.Windows.Forms.Button btn_avarii;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_optiuni;
        private System.Windows.Forms.Button btn_cautare;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

