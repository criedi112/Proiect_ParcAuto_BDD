using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDD_interface_like
{
    public partial class Form_Adauga_Angajat : Form
    {
        public Form_Adauga_Angajat()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form_Adauga_Angajat_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = textBox1.Text.ToString();
            string functie = textBox2.Text.ToString();
            string sal = textBox3.Text.ToString();


            float sal1 = 0;
            bool salariu = float.TryParse(sal, out sal1);


            if (nume == "" || functie == "" || sal == "")
            {
                MessageBox.Show("Campuri incomplete !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var context = new Parc_AutoDataContext();
                

                var angajat = new Angajati
                {
                    Nume = nume,
                    Functie = functie,
                    Salariu_baza = sal1
                };

                context.Angajatis.InsertOnSubmit(angajat);
                context.SubmitChanges();

                MessageBox.Show("Ati adaugat cu succes !", "Confirmare", MessageBoxButtons.OK);

                this.Close();
                return;
            }
        }
    }
}
