using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace BDD_interface_like
{
    public partial class Form_concediaza_admin : Form
    {
        private string CCurent_user;
        public Form_concediaza_admin(string Curent_user)
        {
            CCurent_user = Curent_user;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = textBox1.Text.ToString();
            string password = textBox2.Text.ToString();

            if (nume == "" || password == "")
            {
                MessageBox.Show("Campuri incomplete !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var context = new Parc_AutoDataContext();

                //--------------criptare------------

                Encryption enc = new Encryption();
                password = enc.EncryptPassword(password);

                //----------------------------------

                var selected_admin = (from db in context.Admin_users
                                      where db.Admin_name.Equals(nume)
                                      select db).First();

                if (selected_admin == null)
                {
                    MessageBox.Show("Adminul nu exista in baza de date !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                if (CCurent_user == nume)
                {
                    MessageBox.Show("Nu puteti sterge adminul curent !", "Confirmare", MessageBoxButtons.OK);

                    this.Close();
                    return;
                }

                if (selected_admin.Password == password)
                {
                    context.Admin_users.DeleteOnSubmit(selected_admin);
                    context.SubmitChanges();

                    MessageBox.Show("Adminul a fost concediat !", "Confirmare", MessageBoxButtons.OK);

                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Parola incorecta !", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                 
                    this.Close();
                    return;
                }
            }
        }

        private void Form_concediaza_admin_Load(object sender, EventArgs e)
        {

        }
    }
}
