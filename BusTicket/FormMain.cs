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
    }
}
