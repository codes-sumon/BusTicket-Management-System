using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.DBManager;

namespace BusTicket
{
    public partial class FormMain : Form
    {
        public string UserType { get; set; }
        public FormMain()
        {
            InitializeComponent();
            countomizeDesign();
            UserType = Global.LoggedInUser.AccountType;
        }
        private void countomizeDesign()
        {
            panelSetup.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelSetup.Visible == true)
                panelSetup.Visible = false;

            //add code for hide other submenue
        }

        private Form activeForm = null;
        //private object parent;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
            hideSubMenu();
            dgvFindBus.Visible = false;
            if (activeForm != null) activeForm.Close();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSetup);
        }

        private void btnBusInfo_Click(object sender, EventArgs e)
        {
            openChildForm(new BusInfo());
            hideSubMenu();
        }

        private void btnCounterInfo_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCounterInfo());
            hideSubMenu();
        }

        private void btnDriverInfo_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDriverInfo());
            hideSubMenu();
        }

        private void btnSuperVisor_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSuperViseorInfo());
            hideSubMenu();
        }

        private void btnRoutSetup_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRouteInfo());
            hideSubMenu();
        }

        private void btnTripSetup_Click(object sender, EventArgs e)
        {
            openChildForm(new FormTripSetup());
            hideSubMenu();
        }


       //Bus Finding Procidure Start 


        private void btnFindBus_Click(object sender, EventArgs e)
        {
            dgvFindBus.Visible = true;
            using (BusDBEntities db = new BusDBEntities())
            {
                if (cmbFrom.SelectedValue == null || cmbTo.SelectedValue == null)
                {
                    MessageBox.Show("Please Counter Select First");
                    return;
                }

                ObjectResult<GetTripInformation_Result> results = db.GetTripInformation((int)cmbFrom.SelectedValue, (int)cmbTo.SelectedValue, dtpSearchDatetime.Value.Date.ToString("dd/MM/yyyy"));

                dgvFindBus.Rows.Clear();
                dgvFindBus.Columns[1].HeaderText = dtpSearchDatetime.Value.Date.ToString("dd/MM/yyyy");
                foreach (GetTripInformation_Result a in results)
                {
                    dgvFindBus.Rows.Add(a.Coach,Convert.ToDateTime(a.StartTime).ToString("hh:mm"),a.TotalSits,a.Available,a.Roadname,a.PerSitPrice);
                }
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            if (UserType != "Admin")
            {
                btnSetup.Visible = false;
                btnUserRegister.Visible = false;
            }

            dgvFindBus.Visible = false;
            comboLoadData();
        }

        private void comboLoadData()
        {
            using (BusDBEntities db = new BusDBEntities())
            {
                cmbFrom.DataSource = db.CounterInfoTBs.ToList();
                cmbFrom.ValueMember = "ID";
                cmbFrom.DisplayMember = "Name";

                cmbTo.DataSource = db.CounterInfoTBs.ToList();
                cmbTo.ValueMember = "ID";
                cmbTo.DisplayMember = "Name";

            }
        }

        void PopulateDataGridView()
        {
            dgvFindBus.AutoGenerateColumns = false;
            using (BusDBEntities db = new BusDBEntities())
            {

                dgvFindBus.Rows.Clear();
                foreach (var a in db.TripInfoTBs.OrderByDescending(c => c.ID).ToList())
                {
                    dgvFindBus.Rows.Add(a.ID, a.Date, a.StartTime);
                }
            }
        }

        private void btnUserRegister_Click(object sender, EventArgs e)
        {
            openChildForm(new FormUserRegistration());
            hideSubMenu();
        }

        private void dgvFindBus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(dgvFindBus.Rows[e.RowIndex].Cells[0].Value.ToString());

            FormSellsTicket a = new FormSellsTicket(ID, (int)cmbFrom.SelectedValue, (int)cmbTo.SelectedValue, dtpSearchDatetime.Value, dgvFindBus.Rows[e.RowIndex].Cells[1].Value.ToString());
            a.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin ss = new FormLogin();
            ss.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin ss = new FormLogin();
            ss.Close();
            Application.Exit();
        }
    }
}
