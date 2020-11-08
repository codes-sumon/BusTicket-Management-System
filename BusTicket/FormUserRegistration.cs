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
    public partial class FormUserRegistration : Form
    {
        public int MstID { get; set; }
        UserInfoTB model = new UserInfoTB();

        public FormUserRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtUsername.Text) 
                || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtMobile.Text)
                || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtReTypePassword.Text)  
                || string.IsNullOrEmpty(cmbAccountType.Text) )
            {
                MessageBox.Show("Fill All Required Fild * ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            PasswordManager passwordManager = new PasswordManager();
            using (BusDBEntities db = new BusDBEntities())
            {
                    model = new UserInfoTB();

                    model.Name = txtName.Text.Trim();
                    model.Username = txtUsername.Text.Trim();
                    model.Email = txtEmail.Text.Trim();
                    model.Mobile = txtMobile.Text.Trim();
                    model.Password = passwordManager.Encrypt(txtPassword.Text);
                    model.AccountType = cmbAccountType.Text.Trim();
                    model.IsActive = true;

              
                    db.UserInfoTBs.Add(model);
                    db.SaveChanges();
                    clean();
                    MessageBox.Show("Registration Complete");
                }
            }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            UserInfoTB aUserInfoTBs;
            using (BusDBEntities db = new BusDBEntities())
            {
                aUserInfoTBs = db.UserInfoTBs.SingleOrDefault(c => c.Username == txtUsername.Text);
                if (aUserInfoTBs != null)
                {
                    MessageBox.Show("Username Not Available");
                    btnRegister.Enabled = false;
                    return;
                }
                else
                {
                    btnRegister.Enabled = true;
                }
            }
        }

        private void txtReTypePassword_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text != txtReTypePassword.Text)
            {
                MessageBox.Show("Password Not Matched");
                btnRegister.Enabled = false;
                return;
            }
            else
            {
                btnRegister.Enabled = true;
            }
        }
        public void clean()
        {
            txtName.Text = "";
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";
            txtPassword.Text = "";
            txtReTypePassword.Text = "";
            cmbAccountType.Text = "Admin";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            UserInfoTB aUserInfoTBs;
            using (BusDBEntities db = new BusDBEntities())
            {
                aUserInfoTBs = db.UserInfoTBs.SingleOrDefault(c => c.Email == txtEmail.Text);
                if (aUserInfoTBs != null)
                {
                    MessageBox.Show("Email Address Not Available");
                    btnRegister.Enabled = false;
                    return;
                }
                else
                {
                    btnRegister.Enabled = true;
                }
            }
        }

        private void FormUserRegistration_Load(object sender, EventArgs e)
        {
            clean();
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }
    }
}
