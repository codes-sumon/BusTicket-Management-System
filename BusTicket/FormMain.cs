using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicket
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            countomizeDesign();
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

        private void btnFindBus_Click(object sender, EventArgs e)
        {
            dgvFindBus.Visible = true;


        }

        private void FormMain_Load(object sender, EventArgs e)
        {
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
    }
}
