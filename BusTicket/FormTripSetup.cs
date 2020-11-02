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
    public partial class FormTripSetup : Form
    {
        public int MstID { get; set; }
        TripInfoTB model = new TripInfoTB();

        public FormTripSetup()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtStartTime.Text = txtPerSitPrice.Text  = "";
            cmbBus.Text = "Select Bus ID";
            cmbRoute.Text = "Select Route Name";
            cmbDriver.Text = "Select Driver";
            cmbSuperVisor.Text = "Select Super Visor";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            model.ID = 0;
            MstID = 0;
            using (BusDBEntities db = new BusDBEntities())
            {
                cmbBegCounter.DataSource = db.CounterInfoTBs.ToList();
                cmbBegCounter.ValueMember = "ID";
                cmbBegCounter.DisplayMember = "Name";

                cmbBus.DataSource = db.BusInfoTBs.ToList();
                cmbBus.ValueMember = "ID";
                cmbBus.DisplayMember = "BusNumber";

                cmbDriver.DataSource = db.DriverInfoTBs.ToList();
                cmbDriver.ValueMember = "ID";
                cmbDriver.DisplayMember = "Name";

                cmbRoute.DataSource = db.RouteInfoTBs.ToList();
                cmbRoute.ValueMember = "RouteID";
                cmbRoute.DisplayMember = "Name";

                cmbSuperVisor.DataSource = db.SuperViseorInfoTBs.ToList();
                cmbSuperVisor.ValueMember = "ID";
                cmbSuperVisor.DisplayMember = "Name";


                dgvTripInfo.Rows.Clear();
                foreach (TripInfoTB a in db.TripInfoTBs.OrderByDescending(a=>a.ID))
                {
                    dgvTripInfo.Rows.Add(a.ID,a.Date,a.PerSitPrice, a.BusInfoTB.BusNumber,a.BusInfoTB.BusName,a.StartTime,a.DriverInfoTB.Name,a.RouteInfoTB.Name,a.SuperViseorInfoTB.Name);
                }
            }
        }
        void PopulateDataGridView()
        {
            dgvTripInfo.AutoGenerateColumns = false;
            using (BusDBEntities db = new BusDBEntities())
            {

                dgvTripInfo.Rows.Clear();
                foreach (var a in db.TripInfoTBs.OrderByDescending(c => c.ID).ToList())
                {
                    dgvTripInfo.Rows.Add(a.ID, a.Date, a.StartTime);
                }
            }
        }
        private void FormTripSetup_Load(object sender, EventArgs e)
        {
            clear();
          //  PopulateDataGridView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ':'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == ':'))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (BusDBEntities db = new BusDBEntities())
            {
                TripInfoTB aTripInfoTB;
                aTripInfoTB = db.TripInfoTBs.SingleOrDefault(a => a.ID == MstID);
                if (aTripInfoTB == null)
                {
                    aTripInfoTB = new TripInfoTB();
                    aTripInfoTB.Date = dtpTripDate.Value.Date;
                    aTripInfoTB.PerSitPrice = Convert.ToInt32(txtPerSitPrice.Text);
                    aTripInfoTB.BusID = (int)cmbBus.SelectedValue;
                    aTripInfoTB.CounterID = (int)cmbBegCounter.SelectedValue;
                    aTripInfoTB.DriverID = (int)cmbDriver.SelectedValue;
                    aTripInfoTB.RouteID = (int)cmbRoute.SelectedValue;
                    aTripInfoTB.SuperVisorID = (int)cmbSuperVisor.SelectedValue;
                    aTripInfoTB.StartTime = txtStartTime.Text;
                    
                    db.TripInfoTBs.Add(aTripInfoTB);
                    db.SaveChanges();
                    MessageBox.Show("Record Save Succesfully");
                    clear();
                }
                else
                {
                    aTripInfoTB.Date = dtpTripDate.Value.Date;
                    aTripInfoTB.PerSitPrice = Convert.ToInt32(txtPerSitPrice.Text);
                    aTripInfoTB.BusID = (int)cmbBus.SelectedValue;
                    aTripInfoTB.CounterID = (int)cmbBegCounter.SelectedValue;
                    aTripInfoTB.DriverID = (int)cmbDriver.SelectedValue;
                    aTripInfoTB.RouteID = (int)cmbRoute.SelectedValue;
                    aTripInfoTB.SuperVisorID = (int)cmbSuperVisor.SelectedValue;
                    aTripInfoTB.StartTime = txtStartTime.Text;

                    db.SaveChanges();
                    MessageBox.Show("Record Update Succesfully");
                    clear();
                }

            }
        }

        private void txtStartTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ':') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // If you want, you can allow decimal (float) numbers
            
        }

        private void dgvTripInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Text = "Update";
            try
            {
                MstID = (int)dgvTripInfo.Rows[e.RowIndex].Cells[0].Value;
                using (BusDBEntities db = new BusDBEntities())
                {
                    TripInfoTB aTripInfoTB;
                    aTripInfoTB = db.TripInfoTBs.SingleOrDefault(a => a.ID == MstID);
                    if (aTripInfoTB != null)
                    {
                        btnDelete.Enabled = true;
                        dtpTripDate.Value = Convert.ToDateTime(aTripInfoTB.Date);
                        txtPerSitPrice.Text = aTripInfoTB.PerSitPrice.ToString();
                        cmbBegCounter.SelectedValue = aTripInfoTB.CounterID;
                        cmbBus.SelectedValue = aTripInfoTB.BusID;
                        cmbDriver.SelectedValue = aTripInfoTB.DriverID;

                        cmbRoute.SelectedValue = aTripInfoTB.RouteID;
                        cmbSuperVisor.SelectedValue = aTripInfoTB.SuperVisorID;
                        txtStartTime.Text = aTripInfoTB.StartTime;


                    }
                }
            }
            catch
            {
                using (BusDBEntities db = new BusDBEntities())
                {
                    TripInfoTB aTripInfoTB;
                    aTripInfoTB = db.TripInfoTBs.SingleOrDefault(a => a.ID == MstID);
                    if (aTripInfoTB != null)
                    {
                        btnDelete.Enabled = true;
                        dtpTripDate.Value = Convert.ToDateTime(aTripInfoTB.Date);
                        txtPerSitPrice.Text = aTripInfoTB.PerSitPrice.ToString();
                        cmbBegCounter.SelectedValue = aTripInfoTB.CounterID;
                        cmbBus.SelectedValue = aTripInfoTB.BusID;
                        cmbDriver.SelectedValue = aTripInfoTB.DriverID;

                        cmbRoute.SelectedValue = aTripInfoTB.RouteID;
                        cmbSuperVisor.SelectedValue = aTripInfoTB.SuperVisorID;
                        txtStartTime.Text = aTripInfoTB.StartTime;


                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (BusDBEntities db = new BusDBEntities())
            {
                TripInfoTB aTripInfoTB;
                aTripInfoTB = db.TripInfoTBs.SingleOrDefault(a => a.ID == MstID);
                if (aTripInfoTB != null)
                {
                    db.TripInfoTBs.Remove(aTripInfoTB);
                    db.SaveChanges();
                    MessageBox.Show("Record Delete Succesfully");
                    clear();
                }
            }
        }
    }
}
