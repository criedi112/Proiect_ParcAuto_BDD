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
    public partial class Form_Grafic : Form
    {
        public Form_Grafic()
        {
            DateTime day = DateTime.Today;
            DateTime d = day.AddDays(-30);

            InitializeComponent();
            var context = new Parc_AutoDataContext();
            var result = from s in context.Vanzaris.Take(30)
                         where (s.Data >= d)
                         group s by new { date = new DateTime(s.Data.Value.Year, s.Data.Value.Month, s.Data.Value.Day) } into g
                         select new
                         {
                             read_date = g.Key.date,
                             T1 = g.Sum(x => x.Pret_vanzare)
                         };

            foreach( var suma_zilnica in result )
            {
               // string[] s = suma_zilnica.read_date.ToString();
                this.chart1.Series["Profituri Lunare"].Points.AddXY(suma_zilnica.read_date, suma_zilnica.T1);
                chart1.Series["Profituri Lunare"]["PixelPointWidth"] = "10";
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
