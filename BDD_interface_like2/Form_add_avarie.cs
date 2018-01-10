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
   

    public partial class Form_add_avarie : Form
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

        private int id_car;

        public Form_add_avarie(string car, string vin,string id_masina)
        {
            InitializeComponent();
            label_car.Text = car;
            label_vin.Text = vin;

            var context = new Parc_AutoDataContext();
            var avariiQuery = from db in context.Issues
                              select db;

            foreach(var av in avariiQuery)
            {
                comboBox1.Items.Add(new Item(av.Denumire.ToString(), av.ID_Issues.ToString()));
            }

            id_car = Int32.Parse(id_masina);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_avarie_Click(object sender, EventArgs e)
        {
            var context = new Parc_AutoDataContext();

            var issue = (from db in context.Issues
                        where db.Denumire.Equals(comboBox1.SelectedItem.ToString())
                        select db).First();
            int id_is = Int32.Parse(issue.ID_Issues.ToString());

            Cars_Issue prob = new Cars_Issue
            {
                ID_car = id_car,
                ID_Issue = issue.ID_Issues
            };

            context.Cars_Issues.InsertOnSubmit(prob);
            context.SubmitChanges();

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
