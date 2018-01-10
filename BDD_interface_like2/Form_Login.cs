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
        public Form_Login()
        {
            InitializeComponent();
        }

        public static String EncryptPassword(String password, String salt)
        {
            String encryptedPassword = "";
            String saltedPassword = password + salt;

            HashAlgorithm algorithm = new SHA512Managed();

            byte[] hash = algorithm.ComputeHash(Encoding.Unicode.GetBytes(saltedPassword));

            foreach (byte b in hash)
            {
                encryptedPassword += b.ToString("X2");
            }

            return encryptedPassword = encryptedPassword.Length <= 50 ? encryptedPassword : encryptedPassword.Substring(0, 50);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var context = new Parc_AutoDataContext();


            string user = textBox_username.Text;
            string pass = textBox_pass.Text;
            //------------------cripteaza----------------

            pass = EncryptPassword(pass, "shaorma");

            //--------------------------------------------

            var query = from r in context.Admin_users
                        where r.Username.Equals(user) && r.Password.Equals(pass)
                        select r;

            if (query.Count() != 0)
            {
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
