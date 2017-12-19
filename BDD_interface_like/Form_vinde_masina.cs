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
    public partial class Form_vinde_masina : Form
    {
        private string vvv;
        private double ppp;


        public Form_vinde_masina(string vin , string pret)
        {
            InitializeComponent();

            DateTime day = DateTime.Today;
            string[] s = day.ToString().Split(' ');

            string curent_day = s[0];

            label_Data.Text = curent_day;

            label_vin.Text = vin;
            label_pret.Text = pret;
            
            label_vin.BackColor = System.Drawing.SystemColors.Window;
            label_pret.BackColor = System.Drawing.SystemColors.Window;

            vvv = vin;
            ppp = Convert.ToDouble(pret);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_vinde_masina_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_vinde_masina_Click(object sender, EventArgs e)
        {
            var context = new Parc_AutoDataContext();
            string nume_angajat = textBox_nume_vanzator.Text.ToString();
            string nume_client = textBox_nume_client.Text.ToString();

            var id_angajat = from db in context.Angajatis
                             where db.Nume.Equals(nume_angajat)
                             select db.AngajatID;

            var contract = new Vanzari
            {
                Angajat_ID = id_angajat.First(),
                Client = nume_client,
                Vanzator = nume_angajat,
                VIN = vvv,
                Pret_vanzare = ppp,
                Data = DateTime.Now
            };

            var car = from db in context.Masinis
                      where db.VIN.Equals(vvv)
                      select db;
            foreach (var masina in car )
            {
                context.Masinis.DeleteOnSubmit(masina);
            }
            context.Vanzaris.InsertOnSubmit(contract);
            context.SubmitChanges();
            this.Close();
        }
    }
}
