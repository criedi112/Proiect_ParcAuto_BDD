using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDD_interface_like.Properties;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Xml.Linq;

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
            using (Form_Cautare frm_cautare = new Form_Cautare())
            {
                frm_cautare.ShowDialog();
                if (frm_cautare.Dgv != null)
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
                    btn_raport.Visible = true;
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
            btn_raport.Visible = false;
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

        private void btn_optiuni_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                using (Form_afisare_optiuni form_optiuni = new Form_afisare_optiuni(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    form_optiuni.ShowDialog();
                }
            }
        }

        private void btn_avarii_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                using (Form_add_avarie frm = new Form_add_avarie(dataGridView1.SelectedRows[0].Cells[2].Value.ToString(), 
                    dataGridView1.SelectedRows[0].Cells[4].Value.ToString(), dataGridView1.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("nu ati selectat masina");
            }
        }

        private void btn_raport_Click(object sender, EventArgs e)
        {
            DateTime day = DateTime.Today;
            DateTime d = day.AddDays(-30);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += "\\Labar.xlsx";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            // Load Excel application
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            // Create empty workbook
            excel.Workbooks.Add();

            // Create Worksheet from active sheet
            Microsoft.Office.Interop.Excel._Worksheet workSheet = excel.ActiveSheet;

            // I created Application and Worksheet objects before try/catch,
            // so that i can close them in finnaly block.
            // It's IMPORTANT to release these COM objects!!
            try
            {
                // ------------------------------------------------
                // Creation of header cells
                // ------------------------------------------------
                workSheet.Cells[1, "A"] = "VIN";
                workSheet.Cells[1, "B"] = "Clinet";
                workSheet.Cells[1, "C"] = "Vanzator";
                workSheet.Cells[1, "D"] = "Pret Vanzare";
                workSheet.Cells[1, "E"] = "Data";

                var context = new Parc_AutoDataContext();
                var result = from s in context.Vanzaris.Take(30)
                             where (s.Data >= d)
                             select new { VIN=s.VIN,Client=s.Client,Vanzator=s.Vanzator,Pret_Vanzare=s.Pret_vanzare,Data=s.Data };

                int row = 2; // start row (in row 1 are header cells)
                foreach (var car in result)
                {
                    workSheet.Cells[row, "A"] = car.VIN;
                    workSheet.Cells[row, "B"] = car.Client;
                    workSheet.Cells[row, "C"] = car.Vanzator;
                    workSheet.Cells[row, "D"] = car.Pret_Vanzare;
                    workSheet.Cells[row, "E"] = car.Data;
                    

                    row++;
                }

                // Apply some predefined styles for data to look nicely :)
                //workSheet.Range["A1"].AutoFormat(Microsoft.Office.Interop.Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic1);//
                
                // Save this data as a file
                workSheet.SaveAs(path);

                // Display SUCCESS message
                MessageBox.Show(string.Format("The file '{0}' is saved successfully!", path));
            }
            catch (Exception exception)
            {
                MessageBox.Show("Exception",
                    "There was a PROBLEM saving Excel file!\n" + exception.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
