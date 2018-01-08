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
    public partial class Form_afisare_optiuni : Form
    {

        public Form_afisare_optiuni(string id_car)
        {
            InitializeComponent();

            var context = new Parc_AutoDataContext();

            int id = Int32.Parse(id_car);

            var queri_optiuni = from db in context.Optiunis
                                where db.ID_Masina.Equals(id) 
                                select db;

            dataGridView_optiuni.DataSource = queri_optiuni.ToList();

            var queri_avarii = from avarii in context.Issues
                               join mas in context.Cars_Issues on avarii.ID_Issues equals mas.ID_Issue
                               join masina in context.Masinis on mas.ID_car equals masina.ID_Masina
                               where masina.ID_Masina.Equals(id)
                               select avarii;

            dataGridView_avarii.DataSource = queri_avarii.ToList();

        }
    }
}
