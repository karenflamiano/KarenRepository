using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserCredentialEF;
using UserCredentialEF.BusinessLogic;

namespace UserCredentials
{
    public partial class Form1 : Form
    {
        static PasswordManager pwdManager = new PasswordManager();
        static AddToDatabase AddDatabase = new AddToDatabase();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = textBox1.Text;
            var password = textBox2.Text;
            string salt = null;
            string passwordHash = pwdManager.GeneratePasswordHash(password, out salt);

            TblUser user = new TblUser
            {
                User = username,
                Hash = passwordHash,
                Salt = salt
            };

            if (AddDatabase.AddUserToDB(user))
            {
                MessageBox.Show("Successfully Added Credential!");
            }

            else
            {
                MessageBox.Show("Error!");
            }
           
           
        }


    }
}
