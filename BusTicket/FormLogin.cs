using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.DBManager;

namespace BusTicket
{
    public partial class FormLogin : Form
    {
        UserInfoTB model = new UserInfoTB();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (BusDBEntities db = new BusDBEntities())
            {
                PasswordManager passwordManager = new PasswordManager();
                string encryptedPassword = passwordManager.Encrypt(txtPassword.Text.Trim());

                Global.LoggedInUser = db.UserInfoTBs.SingleOrDefault(id => id.Username == txtUsername.Text.Trim()
                && id.Password == encryptedPassword &&
                    id.IsActive == true);
                //model = db.UserInfoTBs.SingleOrDefault(id => id.Username == txtUsername.Text.Trim() && id.Password == encryptedPassword &&
                //    id.IsActive == true);

                if (Global.LoggedInUser != null)
                    //if (model != null)
                {
                    this.Hide();
                    FormMain ss = new FormMain();
                    ss.Show();
                    
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void labelRegisterAccount_Click(object sender, EventArgs e)
        {
            FormUserRegistration ss = new FormUserRegistration();
            ss.Show();
        }
    }
}
