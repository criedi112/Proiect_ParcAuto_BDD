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
using System.Windows.Controls;

namespace BDD_interface_like
{
    public partial class Form_Cautare : Form
    {
        public IEnumerable<Masini> Dgv { get; set; }

        private class Item
        {
            public string Name;
            public string Value;
            public Item(string name, string value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }
        public Form_Cautare()
        {
            InitializeComponent();

            comboBox_Marca.Items.Add(new Item("BMW", "BMW"));
            comboBox_Marca.Items.Add(new Item("Audi", "Audi"));
            comboBox_Marca.Items.Add(new Item("Mazda", "Mazda"));
            comboBox_Marca.Items.Add(new Item("Toyota", "Toyota"));
            //comboBox_Marca.Items.Add(new Item("Opel", "Opel"));


            comboBox_An1.Items.Add(new Item("1990", "1990"));
            comboBox_An1.Items.Add(new Item("1991", "1991"));
            comboBox_An1.Items.Add(new Item("1992", "1992"));
            comboBox_An1.Items.Add(new Item("1993", "1993"));
            comboBox_An1.Items.Add(new Item("1994", "1994"));
            comboBox_An1.Items.Add(new Item("1995", "1995"));
            comboBox_An1.Items.Add(new Item("1996", "1996"));
            comboBox_An1.Items.Add(new Item("1997", "1997"));
            comboBox_An1.Items.Add(new Item("1998", "1998"));
            comboBox_An1.Items.Add(new Item("1999", "1999"));
            comboBox_An1.Items.Add(new Item("2000", "2000"));
            comboBox_An1.Items.Add(new Item("2001", "2001"));
            comboBox_An1.Items.Add(new Item("2002", "2002"));
            comboBox_An1.Items.Add(new Item("2003", "2003"));
            comboBox_An1.Items.Add(new Item("2004", "2004"));
            comboBox_An1.Items.Add(new Item("2005", "2005"));
            comboBox_An1.Items.Add(new Item("2006", "2006"));
            comboBox_An1.Items.Add(new Item("2007", "2007"));
            comboBox_An1.Items.Add(new Item("2008", "2008"));
            comboBox_An1.Items.Add(new Item("2010", "2010"));
            comboBox_An1.Items.Add(new Item("2011", "2011"));
            comboBox_An1.Items.Add(new Item("2012", "2012"));
            comboBox_An1.Items.Add(new Item("2013", "2013"));
            comboBox_An1.Items.Add(new Item("2014", "2014"));
            comboBox_An1.Items.Add(new Item("2015", "2015"));
            comboBox_An1.Items.Add(new Item("2016", "2016"));
            comboBox_An1.Items.Add(new Item("2017", "2017"));
            comboBox_An1.Items.Add(new Item("2018", "2018"));


            comboBox_An2.Items.Add(new Item("1990", "1990"));
            comboBox_An2.Items.Add(new Item("1991", "1991"));
            comboBox_An2.Items.Add(new Item("1992", "1992"));
            comboBox_An2.Items.Add(new Item("1993", "1993"));
            comboBox_An2.Items.Add(new Item("1994", "1994"));
            comboBox_An2.Items.Add(new Item("1995", "1995"));
            comboBox_An2.Items.Add(new Item("1996", "1996"));
            comboBox_An2.Items.Add(new Item("1997", "1997"));
            comboBox_An2.Items.Add(new Item("1998", "1998"));
            comboBox_An2.Items.Add(new Item("1999", "1999"));
            comboBox_An2.Items.Add(new Item("2000", "2000"));
            comboBox_An2.Items.Add(new Item("2001", "2001"));
            comboBox_An2.Items.Add(new Item("2002", "2002"));
            comboBox_An2.Items.Add(new Item("2003", "2003"));
            comboBox_An2.Items.Add(new Item("2004", "2004"));
            comboBox_An2.Items.Add(new Item("2005", "2005"));
            comboBox_An2.Items.Add(new Item("2006", "2006"));
            comboBox_An2.Items.Add(new Item("2007", "2007"));
            comboBox_An2.Items.Add(new Item("2008", "2008"));
            comboBox_An2.Items.Add(new Item("2010", "2010"));
            comboBox_An2.Items.Add(new Item("2011", "2011"));
            comboBox_An2.Items.Add(new Item("2012", "2012"));
            comboBox_An2.Items.Add(new Item("2013", "2013"));
            comboBox_An2.Items.Add(new Item("2014", "2014"));
            comboBox_An2.Items.Add(new Item("2015", "2015"));
            comboBox_An2.Items.Add(new Item("2016", "2016"));
            comboBox_An2.Items.Add(new Item("2017", "2017"));
            comboBox_An2.Items.Add(new Item("2018", "2018"));
            // comboBox_Marca_SelectedIndexChanged(comboBox_culoare.SelectedItem.ToString(),comboBox_Marca.KeyDown);

            //comboBox_culoare.SelectedIndex = 0;
        }

        private void comboBox_Marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Marca.SelectedItem.ToString() == "BMW")
            {
                comboBox_Model.Items.Clear();
                comboBox_Model.Items.Add(new Item("seria 1", "seria 1"));
                comboBox_Model.Items.Add(new Item("seria 3", "seria 3"));
                comboBox_Model.Items.Add(new Item("seria 4", "seria 4"));
                comboBox_Model.Items.Add(new Item("seria 5", "seria 5"));
                comboBox_Model.Items.Add(new Item("seria 6", "seria 6"));
                comboBox_Model.Items.Add(new Item("seria 7", "seria 7"));
                comboBox_Model.Items.Add(new Item("z3", "z3"));
                comboBox_Model.Items.Add(new Item("X1", "X1"));
                comboBox_Model.Items.Add(new Item("X3", "X3"));
                comboBox_Model.Items.Add(new Item("X5", "X5"));
                comboBox_Model.Items.Add(new Item("X6", "X6"));

            }
            else if (comboBox_Marca.SelectedItem.ToString() == "Audi")
            {
                comboBox_Model.Items.Clear();
                comboBox_Model.Items.Add(new Item("A1", "A1"));
                comboBox_Model.Items.Add(new Item("A3", "A3"));
                comboBox_Model.Items.Add(new Item("A4", "A4"));
                comboBox_Model.Items.Add(new Item("A5", "A5"));
                comboBox_Model.Items.Add(new Item("A6", "A6"));
                comboBox_Model.Items.Add(new Item("A7", "A7"));
                comboBox_Model.Items.Add(new Item("Q3", "Q3"));
                comboBox_Model.Items.Add(new Item("Q5", "Q5"));
                comboBox_Model.Items.Add(new Item("Q7", "Q7"));
            }
            else if (comboBox_Marca.SelectedItem.ToString() == "Mazda")
            {
                comboBox_Model.Items.Clear();
                comboBox_Model.Items.Add(new Item("3", "3"));
                comboBox_Model.Items.Add(new Item("6", "6"));
                comboBox_Model.Items.Add(new Item("MX-5", "MX-5"));
                comboBox_Model.Items.Add(new Item("CX-3", "CX-3"));
                comboBox_Model.Items.Add(new Item("CX-5", "CX-5"));
                comboBox_Model.Items.Add(new Item("CX-7", "CX-7"));

            }
            else if (comboBox_Marca.SelectedItem.ToString() == "Toyota")
            {
                comboBox_Model.Items.Clear();
                comboBox_Model.Items.Add(new Item("Auris", "Auris"));
                comboBox_Model.Items.Add(new Item("Avensis", "Avensis"));
                comboBox_Model.Items.Add(new Item("Corolla", "Corolla"));
                comboBox_Model.Items.Add(new Item("Hilux", "Hilux"));
                comboBox_Model.Items.Add(new Item("RAV-4", "RAV-4"));
                comboBox_Model.Items.Add(new Item("Prius", "Prius"));
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
          
        }

        private void button_start_cautare_Click(object sender, EventArgs e)
        {
            var context = new Parc_AutoDataContext();

            int marca_check = comboBox_Marca.SelectedIndex;
            int model_check = comboBox_Model.SelectedIndex;
            int an1_check = comboBox_An1.SelectedIndex;
            int an2_check = comboBox_An2.SelectedIndex;
            string pret1_check = textBox_pret1.Text.ToString();
            string pret2_check = textBox_pret2.Text.ToString();


            if (marca_check > -1 && model_check <= -1 && an1_check <= -1 && an2_check <= -1 && pret1_check == "" && pret2_check == "")
            {
                //daca doar marca e selectata
                var masini = from db in context.Masinis
                              where db.Marca.Equals(comboBox_Marca.Text.ToString())
                              select db;
                Dgv = masini;
                this.Close();
                return;
            }
            else if (marca_check > -1 && model_check > -1 && an1_check <= -1 && an2_check <= -1 && pret1_check == "" && pret2_check == "")
            {
                //daca marca si model selected
                var masini = from db in context.Masinis
                             where db.Marca.Equals(comboBox_Marca.Text.ToString()) 
                             && (db.Model.Equals(comboBox_Model.Text.ToString()))
                             select db;
                Dgv = masini;
                this.Close();
                return;
            }
            else if (marca_check <= -1 && model_check <= -1 && an1_check > -1 && an2_check > -1 && pret1_check == "" && pret2_check == "")
            {
                //daca intervalul de ani e selectat
                int a1 = Int32.Parse(comboBox_An1.Text.ToString());
                int a2 = Int32.Parse(comboBox_An2.Text.ToString());

                if (a1 > a2)
                {
                    MessageBox.Show("Intervalul de ani introdus gresit !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var masini = from db in context.Masinis
                             where db.An_Fabricatie> Int32.Parse(comboBox_An1.Text.ToString())
                             && db.An_Fabricatie < Int32.Parse(comboBox_An2.Text.ToString())
                             select db;
                Dgv = masini;
                this.Close();
                return;
            }
            else if (marca_check <= -1 && model_check <= -1 && an1_check > -1 && an2_check <= -1 && pret1_check == "" && pret2_check == "")
            {
                //an1 e selectat; 
                //selecteaza masinile mai mari de anul respectiv
                var masini = from db in context.Masinis
                             where db.An_Fabricatie > Int32.Parse(comboBox_An1.Text.ToString())
                             select db;
                Dgv = masini;
                this.Close();
                return;
            }
            else if (marca_check <= -1 && model_check <= -1 && an1_check <= -1 && an2_check > -1 && pret1_check == "" && pret2_check == "")
            {
                //an2 e selectat; 
                //selecteaza masinile mai mici de anul respectiv 
                var masini = from db in context.Masinis
                             where db.An_Fabricatie < Int32.Parse(comboBox_An2.Text.ToString())
                             select db;
                Dgv = masini;
                this.Close();
                return;
            }
            else if (marca_check <= -1 && model_check <= -1 && an1_check <= -1 && an2_check <= -1 && pret1_check != "" && pret2_check != "")
            {
                // intervalul de pret e selectat 
                int pr1 = Int32.Parse(textBox_pret1.Text.ToString());
                int pr2 = Int32.Parse(textBox_pret2.Text.ToString());
                if (pr1 > pr2)
                {
                    MessageBox.Show("Intervalul de rpet introdus gresit !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            
                var masini = from db in context.Masinis
                             where db.Pret_Vanzare > Int32.Parse(textBox_pret1.Text.ToString())
                             && db.Pret_Vanzare < Int32.Parse(textBox_pret2.Text.ToString())
                             select db;
                Dgv = masini;
                this.Close();
                return;
            }
            else if (marca_check <= -1 && model_check <= -1 && an1_check <= -1 && an2_check <= -1 && pret1_check != "" && pret2_check == "")
            {
                //pret1 e selectat; 
                //selecteaza masinile mai mari de pretul respectiv 
                var masini = from db in context.Masinis
                             where db.Pret_Vanzare > Int32.Parse(textBox_pret1.Text.ToString())
                             select db;
                Dgv = masini;
                this.Close();
                return;
            }
            else if (marca_check <= -1 && model_check <= -1 && an1_check <= -1 && an2_check <= -1 && pret1_check == "" && pret2_check != "")
            {
                //pret2 e selectat; 
                //selecteaza masinile mai mici de pretul respectiv 
                var masini = from db in context.Masinis
                             where db.Pret_Vanzare < Int32.Parse(textBox_pret2.Text.ToString())
                             select db;
                Dgv = masini;
                this.Close();
                return;
            }
            else if (marca_check > -1 && model_check > -1 && an1_check > -1 && an2_check > -1 && pret1_check == "" && pret2_check == "")
            {
                //marca model si ani
                var masini = from db in context.Masinis
                             where db.Marca.Equals(comboBox_Marca.Text.ToString())
                             && (db.Model.Equals(comboBox_Model.Text.ToString()))
                             && db.An_Fabricatie > Int32.Parse(comboBox_An1.Text.ToString())
                             && db.An_Fabricatie < Int32.Parse(comboBox_An2.Text.ToString())
                             select db;
                Dgv = masini;
                this.Close();
                return;

            }
            else if (marca_check > -1 && model_check > -1 && an1_check > -1 && an2_check > -1 && pret1_check != "" && pret2_check != "")
            {
                //daca toate sunt selectate
                var masini = from db in context.Masinis
                             where db.Marca.Equals(comboBox_Marca.Text.ToString())
                             && (db.Model.Equals(comboBox_Model.Text.ToString()))
                             && db.An_Fabricatie > Int32.Parse(comboBox_An1.Text.ToString())
                             && db.An_Fabricatie < Int32.Parse(comboBox_An2.Text.ToString())
                             && db.An_Fabricatie > Int32.Parse(textBox_pret1.Text.ToString())
                             && db.An_Fabricatie < Int32.Parse(textBox_pret2.Text.ToString())
                             select db;
                Dgv = masini;
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Unul sau mai multe campuri nu au fost completate !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
