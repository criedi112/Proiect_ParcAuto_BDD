namespace BDD_interface_like
{
    partial class Form_Cautare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cautare));
            this.comboBox_Marca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Model = new System.Windows.Forms.ComboBox();
            this.comboBox_An1 = new System.Windows.Forms.ComboBox();
            this.comboBox_An2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_start_cautare = new System.Windows.Forms.Button();
            this.textBox_pret1 = new System.Windows.Forms.TextBox();
            this.textBox_pret2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Marca
            // 
            this.comboBox_Marca.FormattingEnabled = true;
            this.comboBox_Marca.Location = new System.Drawing.Point(104, 31);
            this.comboBox_Marca.Name = "comboBox_Marca";
            this.comboBox_Marca.Size = new System.Drawing.Size(152, 21);
            this.comboBox_Marca.TabIndex = 0;
            this.comboBox_Marca.SelectedIndexChanged += new System.EventHandler(this.comboBox_Marca_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Interval An";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Interval Pret";
            // 
            // comboBox_Model
            // 
            this.comboBox_Model.FormattingEnabled = true;
            this.comboBox_Model.Location = new System.Drawing.Point(104, 66);
            this.comboBox_Model.Name = "comboBox_Model";
            this.comboBox_Model.Size = new System.Drawing.Size(152, 21);
            this.comboBox_Model.TabIndex = 5;
            // 
            // comboBox_An1
            // 
            this.comboBox_An1.FormattingEnabled = true;
            this.comboBox_An1.Location = new System.Drawing.Point(104, 108);
            this.comboBox_An1.Name = "comboBox_An1";
            this.comboBox_An1.Size = new System.Drawing.Size(152, 21);
            this.comboBox_An1.TabIndex = 6;
            // 
            // comboBox_An2
            // 
            this.comboBox_An2.FormattingEnabled = true;
            this.comboBox_An2.Location = new System.Drawing.Point(295, 108);
            this.comboBox_An2.Name = "comboBox_An2";
            this.comboBox_An2.Size = new System.Drawing.Size(148, 21);
            this.comboBox_An2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(273, -34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button_start_cautare
            // 
            this.button_start_cautare.Location = new System.Drawing.Point(180, 191);
            this.button_start_cautare.Name = "button_start_cautare";
            this.button_start_cautare.Size = new System.Drawing.Size(152, 23);
            this.button_start_cautare.TabIndex = 28;
            this.button_start_cautare.Text = "Cauta Masina";
            this.button_start_cautare.UseVisualStyleBackColor = true;
            this.button_start_cautare.Click += new System.EventHandler(this.button_start_cautare_Click);
            // 
            // textBox_pret1
            // 
            this.textBox_pret1.Location = new System.Drawing.Point(104, 149);
            this.textBox_pret1.Name = "textBox_pret1";
            this.textBox_pret1.Size = new System.Drawing.Size(152, 20);
            this.textBox_pret1.TabIndex = 29;
            // 
            // textBox_pret2
            // 
            this.textBox_pret2.Location = new System.Drawing.Point(295, 149);
            this.textBox_pret2.Name = "textBox_pret2";
            this.textBox_pret2.Size = new System.Drawing.Size(148, 20);
            this.textBox_pret2.TabIndex = 30;
            // 
            // Form_Cautare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 230);
            this.Controls.Add(this.textBox_pret2);
            this.Controls.Add(this.textBox_pret1);
            this.Controls.Add(this.button_start_cautare);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox_An2);
            this.Controls.Add(this.comboBox_An1);
            this.Controls.Add(this.comboBox_Model);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Marca);
            this.Name = "Form_Cautare";
            this.Text = "Form_Cautare";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Marca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Model;
        private System.Windows.Forms.ComboBox comboBox_An1;
        private System.Windows.Forms.ComboBox comboBox_An2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_start_cautare;
        private System.Windows.Forms.TextBox textBox_pret1;
        private System.Windows.Forms.TextBox textBox_pret2;
    }
}