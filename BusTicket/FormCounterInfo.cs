using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicket
{
    
    public partial class FormCounterInfo : Form
    {
        public int MstID { get; set; }
        CounterInfoTB model = new CounterInfoTB();

        public FormCounterInfo()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtCounterName.Text = txtPhone.Text = txtAddress.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            model.ID = 0;
            MstID = 0;
        }

        void PopulateDataGridView()
        {
            dgvCounterInfo.AutoGenerateColumns = false;
            using (BusDBEntities db = new BusDBEntities())
            {

                dgvCounterInfo.Rows.Clear();
                foreach (var a in db.CounterInfoTBs.OrderByDescending(c => c.ID).ToList())
                {
                    dgvCounterInfo.Rows.Add(a.ID, a.Name, a.Phone, a.Address);
                }
            }
        }
        private void FormCounterInfo_Load(object sender, EventArgs e)
        {
            clear();
            PopulateDataGridView();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (cmbAddCounter.SelectedValue == null)
            //{
            //    return;

            //}
            if (string.IsNullOrEmpty(txtCounterName.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Fill All Required File * ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            if(MstID == 0)
            {
                foreach (DataGridViewRow dr in dgvCounterInfo.Rows)
                {
                    if (dr.Cells[1].Value.ToString() == txtCounterName.Text)
                    {
                        MessageBox.Show("Already Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (dr.Cells[2].Value.ToString() == txtPhone.Text)
                    {
                        MessageBox.Show("Already Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    
                }
            }
            

            using (BusDBEntities db = new BusDBEntities())
            {
                model = db.CounterInfoTBs.SingleOrDefault(a => a.ID == MstID);
                if (model != null)
                {
                    model.Name = txtCounterName.Text.Trim();
                    model.Phone = txtPhone.Text.Trim();
                    model.Address = txtAddress.Text.Trim();
                    db.SaveChanges();
                    MstID = 0;

                    MessageBox.Show("Update Successfully");
                }
                else
                {
                    model = new CounterInfoTB();
                    model.Name = txtCounterName.Text.Trim();
                    model.Phone = txtPhone.Text.Trim();
                    model.Address = txtAddress.Text.Trim();
                    db.CounterInfoTBs.Add(model);
                    db.SaveChanges();

                    MessageBox.Show("Saved Successfully");
                }
            }
            clear();
            PopulateDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (BusDBEntities db = new BusDBEntities())
                {
                    model = db.CounterInfoTBs.SingleOrDefault(a=>a.ID==MstID);
                    if (model != null)
                    {
                        db.CounterInfoTBs.Remove(model);
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
        }

       

        private void dgvCounterInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(dgvCounterInfo.Rows[e.RowIndex].Cells[0].Value.ToString());
            CounterInfoTB aCounterInfoTBs;

            using (BusDBEntities db = new BusDBEntities())
            {
                 aCounterInfoTBs = db.CounterInfoTBs.SingleOrDefault(c => c.ID == ID);
                if (aCounterInfoTBs != null)
                {
                    txtCounterName.Text = aCounterInfoTBs.Name;
                    txtPhone.Text = aCounterInfoTBs.Phone;
                    txtAddress.Text = aCounterInfoTBs.Address;
                    MstID = aCounterInfoTBs.ID;
                }
            }
            btnSave.Text = "Update";
            btnDelete.Enabled = true;

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }
    }
}
