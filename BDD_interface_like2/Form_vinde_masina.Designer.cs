namespace BDD_interface_like
{
    partial class Form_vinde_masina
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nume_client = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nume_vanzator = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_vinde_masina = new System.Windows.Forms.Button();
            this.label_vin = new System.Windows.Forms.Label();
            this.label_pret = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_Data = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "VIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nume Client";
            // 
            // textBox_nume_client
            // 
            this.textBox_nume_client.Location = new System.Drawing.Point(82, 106);
            this.textBox_nume_client.Name = "textBox_nume_client";
            this.textBox_nume_client.Size = new System.Drawing.Size(159, 20);
            this.textBox_nume_client.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nume Vanzator";
            // 
            // textBox_nume_vanzator
            // 
            this.textBox_nume_vanzator.Location = new System.Drawing.Point(82, 143);
            this.textBox_nume_vanzator.Name = "textBox_nume_vanzator";
            this.textBox_nume_vanzator.Size = new System.Drawing.Size(159, 20);
            this.textBox_nume_vanzator.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pret";
            // 
            // btn_vinde_masina
            // 
            this.btn_vinde_masina.Location = new System.Drawing.Point(82, 179);
            this.btn_vinde_masina.Name = "btn_vinde_masina";
            this.btn_vinde_masina.Size = new System.Drawing.Size(84, 23);
            this.btn_vinde_masina.TabIndex = 8;
            this.btn_vinde_masina.Text = "Vinde Masina";
            this.btn_vinde_masina.UseVisualStyleBackColor = true;
            this.btn_vinde_masina.Click += new System.EventHandler(this.btn_vinde_masina_Click);
            // 
            // label_vin
            // 
            this.label_vin.AutoSize = true;
            this.label_vin.Location = new System.Drawing.Point(107, 25);
            this.label_vin.Name = "label_vin";
            this.label_vin.Size = new System.Drawing.Size(0, 13);
            this.label_vin.TabIndex = 9;
            // 
            // label_pret
            // 
            this.label_pret.AutoSize = true;
            this.label_pret.Location = new System.Drawing.Point(107, 51);
            this.label_pret.Name = "label_pret";
            this.label_pret.Size = new System.Drawing.Size(0, 13);
            this.label_pret.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data";
            // 
            // label_Data
            // 
            this.label_Data.AutoSize = true;
            this.label_Data.Location = new System.Drawing.Point(107, 76);
            this.label_Data.Name = "label_Data";
            this.label_Data.Size = new System.Drawing.Size(0, 13);
            this.label_Data.TabIndex = 12;
            // 
            // Form_vinde_masina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 214);
            this.Controls.Add(this.label_Data);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_pret);
            this.Controls.Add(this.label_vin);
            this.Controls.Add(this.btn_vinde_masina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_nume_vanzator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_nume_client);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_vinde_masina";
            this.Text = "Form_vinde_masina";
            this.Load += new System.EventHandler(this.Form_vinde_masina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nume_client;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nume_vanzator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_vinde_masina;
        private System.Windows.Forms.Label label_vin;
        private System.Windows.Forms.Label label_pret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_Data;
    }
}