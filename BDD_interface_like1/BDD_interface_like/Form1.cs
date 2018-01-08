﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDD_interface_like.Properties;

namespace BDD_interface_like
{
    

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
           
        }

        private void btn_cautare_Click(object sender, EventArgs e)
        {
            using (Form_Cautare frm_cautare=new Form_Cautare())
            {
                frm_cautare.ShowDialog();
                if(frm_cautare.Dgv!=null)
                    dataGridView1.DataSource = frm_cautare.Dgv.ToList();
            }
        }

        private void btn_AddCar_Click(object sender, EventArgs e)
        {
            using (Form2_Add_Car frm_addcar = new Form2_Add_Car())
            {
                frm_addcar.ShowDialog();

                if (frm_addcar.Dgv != null)
                {
                    dataGridView1.DataSource = frm_addcar.Dgv.ToList();
                }
                //dataGridView1 = frm_addcar.Dgv;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            using (Form_Login frm_login = new Form_Login())
            {
                var result = frm_login.ShowDialog();

                if(result== DialogResult.OK)
                {
                    btn_Grafic.Visible = true;
                    btn_Angajati.Visible = true;
                    btn_Logout.Visible = true;
                    MessageBox.Show("Sunteti logat ca administrator .");
                }
            }
        }

        private void btn_Grafic_Click(object sender, EventArgs e)
        {
            using (Form_Grafic frm_graf = new Form_Grafic())
            {
                frm_graf.ShowDialog();


            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            btn_Grafic.Visible = false;
            btn_Angajati.Visible = false;
            btn_Logout.Visible = false;
        }

        private void btn_Angajati_Click(object sender, EventArgs e)
        {
            using (Form_ModificaAngajati frm_angajat = new Form_ModificaAngajati())
            {
                frm_angajat.ShowDialog();
            }
        }

        private void btn_ListMasini_Click(object sender, EventArgs e)
        {
            var context = new Parc_AutoDataContext();

            var query_listare_masini = from db in context.Masinis
                                       select db;

            dataGridView1.DataSource = query_listare_masini.ToList();

        }

        private void btn_SellCar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                using (Form_vinde_masina frm_vinde_car = new Form_vinde_masina(dataGridView1.SelectedRows[0].Cells[4].Value.ToString(), dataGridView1.SelectedRows[0].Cells[6].Value.ToString()))
                {
                    frm_vinde_car.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("nu ati selectat masina");
            }
        }

        private void btn_ModificaMasina_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                using (Form_Modify_car frm_modify_car = new Form_Modify_car(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    frm_modify_car.ShowDialog();
                }
            }
        }
    }
}