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
using System.Security.Cryptography;

namespace BDD_interface_like
{
    public partial class Form_Login : Form
    {
        public string Curent_user;

        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var context = new Parc_AutoDataContext();


            string user = textBox_username.Text;
            string pass = textBox_pass.Text;
            //------------------cripteaza----------------

            Encryption enc = new Encryption();
            pass = enc.EncryptPassword(pass);

            //--------------------------------------------

            var query = from r in context.Admin_users
                        where r.Username.Equals(user) && r.Password.Equals(pass)
                        select r;

            if (query.Count() != 0)
            {
                Curent_user = user;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Nume sau Parola Gresite ! ");
            }

        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
