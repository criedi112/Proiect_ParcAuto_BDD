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
    public partial class Form_usernam_pass : Form
    {
        string nume;
        public Form_usernam_pass(string name)
        {
            InitializeComponent();
            nume = name;
        }

        private void Form_usernam_pass_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text.ToString();
            string password = textBox2.Text.ToString();

            if(user=="" || password == "")
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
                
                var admin1 = new Admin_user
                {
                    Admin_name = nume,
                    Username = user,
                    Password = password
                };

                context.Admin_users.InsertOnSubmit(admin1);
                context.SubmitChanges();

                this.Close();
                return;
            }
        }
    }
}
