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
    public partial class BusInfo : Form
    {
        BusInfoTB model = new BusInfoTB();
        public BusInfo()
        {
            InitializeComponent();
        }
        //function for clean text box
        void clear()
        {
            txtBusName.Text = txtBusNumber.Text =  "";
            cbBusSits.Text = "Select Total Sits";
            cbBusType.Text = "Select Bus Type";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            model.ID = 0;
        }
        //function for data gride view 
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (BusDBEntities db = new BusDBEntities())
            {
                model = db.BusInfoTBs.SingleOrDefault(a => a.ID == MstID);
                if (model != null)
                {
                    model.BusName = txtBusName.Text.Trim();
                    model.BusNumber = txtBusNumber.Text.Trim();
                    model.TotalSits = int.Parse(cbBusSits.Text);
                    model.BusType = cbBusType.Text.Trim();
                    db.SaveChanges();

                    MessageBox.Show("Update Successfully");
                }
                else
                {
                    model = new BusInfoTB();

                    model.BusName = txtBusName.Text.Trim();
                    model.BusNumber = txtBusNumber.Text.Trim();
                    model.TotalSits = int.Parse(cbBusSits.Text);
                    model.BusType = cbBusType.Text.Trim();
                    db.BusInfoTBs.Add(model);
                    db.SaveChanges();

                    MessageBox.Show("Saved Successfully");
                }
                clear();
                PopulateDataGridView();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (BusDBEntities db = new BusDBEntities())
                {
                    model = db.BusInfoTBs.SingleOrDefault(a => a.ID == MstID);
                    if (model != null)
                    {
                        db.BusInfoTBs.Remove(model);
                        db.SaveChanges();
                    }
                    PopulateDataGridView();
                    clear();
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
            PopulateDataGridView();
        }

        private void BusInfo_Load(object sender, EventArgs e)
        {
            clear();
            PopulateDataGridView();
        }

        void PopulateDataGridView()
        {
            dgvBusInfo.AutoGenerateColumns = false;
            using (BusDBEntities db = new BusDBEntities())
            {
                dgvBusInfo.DataSource = db.BusInfoTBs.ToList();   //BusInfoTBs is table name 
            }
        }
        public int MstID;
        private void dgvBusInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(dgvBusInfo.Rows[e.RowIndex].Cells[0].Value.ToString());
            BusInfoTB aBusInfoTBs;

            using (BusDBEntities db = new BusDBEntities())
            {
                aBusInfoTBs = db.BusInfoTBs.SingleOrDefault(c => c.ID == ID);
                if (aBusInfoTBs != null)
                {
                    txtBusName.Text = aBusInfoTBs.BusName;
                    txtBusNumber.Text = aBusInfoTBs.BusNumber;
                    cbBusSits.Text = aBusInfoTBs.TotalSits.ToString();
                    cbBusType.Text = aBusInfoTBs.BusType;
                    MstID = aBusInfoTBs.ID;
                }
            }
            btnSave.Text = "Update";
            btnDelete.Enabled = true;
        }
    }
}
