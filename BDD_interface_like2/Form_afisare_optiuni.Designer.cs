namespace BDD_interface_like
{
    partial class Form_afisare_optiuni
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
            this.dataGridView_optiuni = new System.Windows.Forms.DataGridView();
            this.dataGridView_avarii = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_optiuni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_avarii)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Optiuni :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Avarii :";
            // 
            // dataGridView_optiuni
            // 
            this.dataGridView_optiuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_optiuni.Location = new System.Drawing.Point(12, 29);
            this.dataGridView_optiuni.Name = "dataGridView_optiuni";
            this.dataGridView_optiuni.Size = new System.Drawing.Size(537, 182);
            this.dataGridView_optiuni.TabIndex = 2;
            // 
            // dataGridView_avarii
            // 
            this.dataGridView_avarii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_avarii.Location = new System.Drawing.Point(12, 231);
            this.dataGridView_avarii.Name = "dataGridView_avarii";
            this.dataGridView_avarii.Size = new System.Drawing.Size(537, 122);
            this.dataGridView_avarii.TabIndex = 3;
            // 
            // Form_afisare_optiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 355);
            this.Controls.Add(this.dataGridView_avarii);
            this.Controls.Add(this.dataGridView_optiuni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_afisare_optiuni";
            this.Text = "Form_afisare_optiuni";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_optiuni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_avarii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_optiuni;
        private System.Windows.Forms.DataGridView dataGridView_avarii;
    }
}