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
            comboBox_climatizare.Items.Add(new Item("AC Automat", "AC Automat"));
            comboBox_climatizare.Items.Add(new Item("AC Manual", "AC Manual"));


            comboBox_culoare.Items.Add(new Item("alb","alb"));
            comboBox_culoare.Items.Add(new Item("gri", "gri"));
            comboBox_culoare.Items.Add(new Item("argintiu", "argintiu"));
            comboBox_culoare.Items.Add(new Item("albastru", "albastru"));
            comboBox_culoare.Items.Add(new Item("maro", "maro"));
            comboBox_culoare.Items.Add(new Item("rosu", "rosu"));

            //comboBox_culoare.SelectedIndex = 0;
        }

        private void comboBox_Marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_start_cautare_Click(object sender, EventArgs e)
        {
            if(checkBox_4x4.Checked)
            {
                //MessageBox.Show("masina cu tractiune 4x4");
            }
            
            MessageBox.Show(comboBox_culoare.SelectedItem.ToString());
        }
    }
}
