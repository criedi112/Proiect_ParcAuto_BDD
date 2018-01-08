using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;


namespace BDD_interface_like
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var context = new Parc_AutoDataContext();


            string user = textBox_username.Text;
            string pass = textBox_pass.Text;

            var query = from r in context.Admin_users
                        where r.Username.StartsWith(user) && r.Password.StartsWith(pass)
                        select r;
                       
            if(query.Count() != 0 )
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Nume sau Parola Gresite ! ");
            }
            
            
        }
    }
}
