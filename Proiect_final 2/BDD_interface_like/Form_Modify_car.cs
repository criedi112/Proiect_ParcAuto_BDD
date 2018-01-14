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
    public partial class Form_Modify_car : Form
    {
        private int id_mas;

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

        public Form_Modify_car(string id)
        {
            InitializeComponent();
            id_mas = Int32.Parse(id);

            comboBox_climatizare.Items.Add(new Item("AC Automat", "AC Automat"));
            comboBox_climatizare.Items.Add(new Item("AC Manual", "AC Manual"));

            comboBox_culoare.Items.Add(new Item("alb", "alb"));
            comboBox_culoare.Items.Add(new Item("gri", "gri"));
            comboBox_culoare.Items.Add(new Item("argintiu", "argintiu"));
            comboBox_culoare.Items.Add(new Item("albastru", "albastru"));
            comboBox_culoare.Items.Add(new Item("maro", "maro"));
            comboBox_culoare.Items.Add(new Item("rosu", "rosu"));

            comboBox_faruri.Items.Add(new Item("Led", "Led"));
            comboBox_faruri.Items.Add(new Item("Xenon", "Xenon"));
            comboBox_faruri.Items.Add(new Item("Halogen", "Halogen"));

            comboBox_tapiterie.Items.Add(new Item("piele", "piele"));
            comboBox_tapiterie.Items.Add(new Item("textil", "textil"));
            comboBox_tapiterie.Items.Add(new Item("alcantara", "alcantara"));

            comboBox_Marca.Items.Add(new Item("BMW", "BMW"));
            comboBox_Marca.Items.Add(new Item("Audi", "Audi"));
            comboBox_Marca.Items.Add(new Item("Mazda", "Mazda"));
            comboBox_Marca.Items.Add(new Item("Toyota", "Toyota"));

            comboBox_An_fabricatie.Items.Add(new Item("1990", "1990"));
            comboBox_An_fabricatie.Items.Add(new Item("1991", "1991"));
            comboBox_An_fabricatie.Items.Add(new Item("1992", "1992"));
            comboBox_An_fabricatie.Items.Add(new Item("1993", "1993"));
            comboBox_An_fabricatie.Items.Add(new Item("1994", "1994"));
            comboBox_An_fabricatie.Items.Add(new Item("1995", "1995"));
            comboBox_An_fabricatie.Items.Add(new Item("1996", "1996"));
            comboBox_An_fabricatie.Items.Add(new Item("1997", "1997"));
            comboBox_An_fabricatie.Items.Add(new Item("1998", "1998"));
            comboBox_An_fabricatie.Items.Add(new Item("1999", "1999"));
            comboBox_An_fabricatie.Items.Add(new Item("2000", "2000"));
            comboBox_An_fabricatie.Items.Add(new Item("2001", "2001"));
            comboBox_An_fabricatie.Items.Add(new Item("2002", "2002"));
            comboBox_An_fabricatie.Items.Add(new Item("2003", "2003"));
            comboBox_An_fabricatie.Items.Add(new Item("2004", "2004"));
            comboBox_An_fabricatie.Items.Add(new Item("2005", "2005"));
            comboBox_An_fabricatie.Items.Add(new Item("2006", "2006"));
            comboBox_An_fabricatie.Items.Add(new Item("2007", "2007"));
            comboBox_An_fabricatie.Items.Add(new Item("2008", "2008"));
            comboBox_An_fabricatie.Items.Add(new Item("2009", "2009"));
            comboBox_An_fabricatie.Items.Add(new Item("2010", "2010"));
            comboBox_An_fabricatie.Items.Add(new Item("2011", "2011"));
            comboBox_An_fabricatie.Items.Add(new Item("2012", "2012"));
            comboBox_An_fabricatie.Items.Add(new Item("2013", "2013"));
            comboBox_An_fabricatie.Items.Add(new Item("2014", "2014"));
            comboBox_An_fabricatie.Items.Add(new Item("2015", "2015"));
            comboBox_An_fabricatie.Items.Add(new Item("2016", "2016"));
            comboBox_An_fabricatie.Items.Add(new Item("2017", "2017"));
            comboBox_An_fabricatie.Items.Add(new Item("2018", "2018"));


            comboBox_Supplier.Items.Add(new Item("BMWAuto", "BMWAuto"));
            comboBox_Supplier.Items.Add(new Item("AudiExpres", "AudiExpres"));
            comboBox_Supplier.Items.Add(new Item("ToyotaAsia", "ToyotaAsia"));
            comboBox_Supplier.Items.Add(new Item("Bimmer", "Bimmer"));
            comboBox_Supplier.Items.Add(new Item("MazdaAuto", "MazdaAuto"));
        }


        private void btn_addcar_Click(object sender, EventArgs e)
        {
            var context = new Parc_AutoDataContext();

            float pret1 = 0;
            bool parsepret1 = float.TryParse(textBox_Pret_addmasina.Text.ToString(), out pret1);

            string sup = null;
            if (comboBox_Supplier.SelectedIndex > -1)
            {
                sup = comboBox_Supplier.SelectedItem.ToString();
            }
            else
            {
                this.Close();
                MessageBox.Show("Nu ati introdus suplier !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox_Marca.SelectedIndex > -1 && textBox_VIN.Text.ToString() != null
            && comboBox_Model.SelectedIndex > -1 && comboBox_An_fabricatie.SelectedIndex > -1 && parsepret1 != false)
            {
                MessageBox.Show("Campuri Complete !");
            }
            else
            {
                this.Close();
                MessageBox.Show("Campuri Incomplete !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var supplier = from db in context.Suppliers
                           where db.Company_Name.Equals(sup)
                           select db.ID_Suppliers;

            float pret = 0;
            bool parsepret = float.TryParse(textBox_Pret_addmasina.Text.ToString(), out pret);

            int fabricatie = 0;
            bool parseOK = Int32.TryParse(comboBox_An_fabricatie.SelectedItem.ToString(), out fabricatie);

            
            var masina=(from db in context.Masinis
                       where db.ID_Masina.Equals(id_mas)
                       select db).First();
        
            masina.ID_Suppliers = supplier.First();
            masina.Marca = comboBox_Marca.SelectedItem.ToString();
            masina.Model = comboBox_Model.SelectedItem.ToString();
            masina.VIN = textBox_VIN.Text.ToString();
            masina.An_Fabricatie = fabricatie;
            masina.Pret_Vanzare = pret;


            

            //if (parsepret == true)
            //{
            //    context.Masinis.InsertOnSubmit(masina);
            //}

            context.SubmitChanges();

            //var masina_id = from db in context.Masinis
            //                where db.VIN.Equals(masina.VIN)
            //                select db.ID_Masina;


            string faruri;
            if (comboBox_faruri.SelectedIndex > -1)
            {
                faruri = comboBox_faruri.SelectedItem.ToString();
            }
            else
            {
                faruri = null;
            }

            string clima;
            if (comboBox_climatizare.SelectedIndex > -1)
            {
                clima = comboBox_climatizare.SelectedItem.ToString();
            }
            else
            {
                clima = null;
            }

            string Tapiterie1;
            if (comboBox_tapiterie.SelectedIndex > -1)
            {
                Tapiterie1 = comboBox_tapiterie.SelectedItem.ToString();
            }
            else
            {
                Tapiterie1 = null;
            }

            string cul;
            if (comboBox_culoare.SelectedIndex > -1)
            {
                cul = comboBox_culoare.SelectedItem.ToString();
            }
            else
            {
                cul = null;
            }


            var opt=(from db in context.Optiunis
                    where db.ID_Masina.Equals(id_mas)
                    select db).First();


            if (opt == null)
            {
                Optiuni option = new Optiuni
                {
                    ID_Masina = id_mas,
                    Climatizare = clima,
                    Faruri = faruri,
                    Tapiterie = Tapiterie1,
                    Faruri_ceata = checkBox_faruri_ceata.Checked,
                    Culoare = cul,
                    Tractiune4x4 = checkBox_4x4.Checked,
                    Avariat = checkBox_avarie.Checked,
                    Comenzi_volan = checkBox_volan_multifunctional.Checked,
                    Cruise_control = checkBox_adaptive_cruise.Checked,
                    Navigatie = checkBox_navigatie.Checked,
                    Scaune_incalzite = checkBox_scaune_incalzite.Checked,
                    Senzori_parcare = checkBox_senzori_parcare.Checked
                };

                context.Optiunis.InsertOnSubmit(option);
            }
            else
            {
                opt.Climatizare = clima;
                opt.Faruri = faruri;
                opt.Tapiterie = Tapiterie1;
                opt.Faruri_ceata = checkBox_faruri_ceata.Checked;
                opt.Culoare = cul;
                opt.Tractiune4x4 = checkBox_4x4.Checked;
                opt.Avariat = checkBox_avarie.Checked;
                opt.Comenzi_volan = checkBox_volan_multifunctional.Checked;
                opt.Cruise_control = checkBox_adaptive_cruise.Checked;
                opt.Navigatie = checkBox_navigatie.Checked;
                opt.Scaune_incalzite = checkBox_scaune_incalzite.Checked;
                opt.Senzori_parcare = checkBox_senzori_parcare.Checked;
            }

            context.SubmitChanges();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void comboBox_Marca_SelectedIndexChanged_1(object sender, EventArgs e)
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
    }
}
