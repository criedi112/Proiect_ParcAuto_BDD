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
    public partial class Form_modifica_angajat : Form
    {
        static string nume;
        public Form_modifica_angajat(string name)
        {
            InitializeComponent();
            nume = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string functie = textBox2.Text.ToString();
            string sal = textBox3.Text.ToString();

            float sal1 = 0;
            bool salariu = float.TryParse(sal, out sal1);

            var context = new Parc_AutoDataContext();

            var angajat = (from db in context.Angajatis
                           where db.Nume.Equals(nume)
                           select db).First();

            if(functie==""&& sal == "")
            {
                MessageBox.Show("Campuri Incomplete !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (functie != "" && sal == "")
            {
                angajat.Functie = functie;
                context.SubmitChanges();
                this.Close();
                return;
            }
            else if(functie=="" && sal != "")
            {
                angajat.Salariu_baza = sal1;
                context.SubmitChanges();
                this.Close();
                return;
            }
            else
            {
                angajat.Functie = functie;
                angajat.Salariu_baza = sal1;
                context.SubmitChanges();
                this.Close();
                return;
            }

        }

        private void Form_modifica_angajat_Load(object sender, EventArgs e)
        {

        }
    }
}
