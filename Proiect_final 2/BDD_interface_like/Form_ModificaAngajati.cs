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
    public partial class Form_ModificaAngajati : Form
    {
        private string Curent_User;
        public Form_ModificaAngajati(string Curent_Userr)
        {
            Curent_User = Curent_Userr;
            InitializeComponent();
        }

        private void Form_ModificaAngajati_Load(object sender, EventArgs e)
        {

        }

        private void btn_ListareAngajati_Click(object sender, EventArgs e)
        {
            var context = new Parc_AutoDataContext();

            var query_listare_angajati = from db in context.Angajatis
                                       select db;

            dataGridView1.DataSource = query_listare_angajati.ToList();
        }

        private void btn_concediaza_Click(object sender, EventArgs e)
        {
            var context = new Parc_AutoDataContext();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id_angajat = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                var angajati = from db in context.Angajatis
                               where db.AngajatID == id_angajat
                               select db;

                foreach (var angajat in angajati)
                    context.Angajatis.DeleteOnSubmit(angajat);
                context.SubmitChanges();

                var query_listare_angajati = from db in context.Angajatis
                                             select db;

                dataGridView1.DataSource = query_listare_angajati.ToList();


                return;
            }
            else
            {
                MessageBox.Show("nu ati selectat niciun angajat");
            }
        }

        private void btn_addAdmin_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Sunteti sigur?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string nume = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    using (Form_usernam_pass frm_adauga_admin = new Form_usernam_pass(nume))
                    {
                        frm_adauga_admin.ShowDialog();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("nu ati selectat niciun angajat");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form_Adauga_Angajat frm_adauga_angajat = new Form_Adauga_Angajat())
            {
                frm_adauga_angajat.ShowDialog();
            }

            var context = new Parc_AutoDataContext();

            var query_listare_angajati = from db in context.Angajatis
                                         select db;

            dataGridView1.DataSource = query_listare_angajati.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Form_concediaza_admin frm_concediaza_ad = new Form_concediaza_admin(Curent_User))
            {
                frm_concediaza_ad.ShowDialog();
            }
        }

        private void btn_modificaAngajat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nume = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                using (Form_modifica_angajat frm_modify_ang = new Form_modifica_angajat(nume))
                {
                    frm_modify_ang.ShowDialog();

                    var context = new Parc_AutoDataContext();

                    var query_listare_angajati = from db in context.Angajatis
                                                 select db;

                    dataGridView1.DataSource = query_listare_angajati.ToList();
                }
            }
            else
            {
                MessageBox.Show("nu ati selectat niciun angajat");
            }
            
        }
    }
}
