namespace BDD_interface_like
{
    partial class Form_add_avarie
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
            this.label_car = new System.Windows.Forms.Label();
            this.label_vin = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add_avarie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_car
            // 
            this.label_car.AutoSize = true;
            this.label_car.Location = new System.Drawing.Point(49, 29);
            this.label_car.Name = "label_car";
            this.label_car.Size = new System.Drawing.Size(116, 13);
            this.label_car.TabIndex = 0;
            this.label_car.Text = "Nici o masina selectata";
            // 
            // label_vin
            // 
            this.label_vin.AutoSize = true;
            this.label_vin.Location = new System.Drawing.Point(219, 29);
            this.label_vin.Name = "label_vin";
            this.label_vin.Size = new System.Drawing.Size(0, 13);
            this.label_vin.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Avarie";
            // 
            // btn_add_avarie
            // 
            this.btn_add_avarie.Location = new System.Drawing.Point(355, 62);
            this.btn_add_avarie.Name = "btn_add_avarie";
            this.btn_add_avarie.Size = new System.Drawing.Size(75, 23);
            this.btn_add_avarie.TabIndex = 4;
            this.btn_add_avarie.Text = "Adauga";
            this.btn_add_avarie.UseVisualStyleBackColor = true;
            this.btn_add_avarie.Click += new System.EventHandler(this.btn_add_avarie_Click);
            // 
            // Form_add_avarie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 105);
            this.Controls.Add(this.btn_add_avarie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_vin);
            this.Controls.Add(this.label_car);
            this.Name = "Form_add_avarie";
            this.Text = "Form_add_avarie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_car;
        private System.Windows.Forms.Label label_vin;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_avarie;
    }
}