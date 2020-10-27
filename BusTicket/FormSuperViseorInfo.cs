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
    public partial class FormSuperViseorInfo : Form
    {
        SuperViseorInfoTB model = new SuperViseorInfoTB();
        public FormSuperViseorInfo()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtName.Text = txtPhone.Text = txtAddress.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            model.ID = 0;
        }
        void PopulateDataGridView()
        {
            dgvSVInfo.AutoGenerateColumns = false;
            using (BusDBEntities db = new BusDBEntities())
            {

                dgvSVInfo.Rows.Clear();
                foreach (var a in db.SuperViseorInfoTBs.OrderByDescending(c => c.ID).ToList())
                {
                    dgvSVInfo.Rows.Add(a.ID, a.Name, a.Phone, a.Address);
                }
            }
        }

        private void FormSuperViseorInfo_Load(object sender, EventArgs e)
        {
            clear();
            PopulateDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (BusDBEntities db = new BusDBEntities())
            {
                model = db.SuperViseorInfoTBs.SingleOrDefault(a => a.ID == MstID);
                if (model != null)
                {
                    model.Name = txtName.Text.Trim();
                    model.Phone = txtPhone.Text.Trim();
                    model.Address = txtAddress.Text.Trim();
                    db.SaveChanges();

                    MessageBox.Show("Update Successfully");
                }
                else
                {
                    model = new SuperViseorInfoTB();
                    model.Name = txtName.Text.Trim();
                    model.Phone = txtPhone.Text.Trim();
                    model.Address = txtAddress.Text.Trim();
                    db.SuperViseorInfoTBs.Add(model);
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
                    model = db.SuperViseorInfoTBs.SingleOrDefault(a => a.ID == MstID);
                    if (model != null)
                    {
                        db.SuperViseorInfoTBs.Remove(model);
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

        public int MstID;
        private void dgvSVInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(dgvSVInfo.Rows[e.RowIndex].Cells[0].Value.ToString());
            SuperViseorInfoTB aSuperViseorInfoTBs;

            using (BusDBEntities db = new BusDBEntities())
            {
                aSuperViseorInfoTBs = db.SuperViseorInfoTBs.SingleOrDefault(c => c.ID == ID);
                if (aSuperViseorInfoTBs != null)
                {
                    txtName.Text = aSuperViseorInfoTBs.Name;
                    txtPhone.Text = aSuperViseorInfoTBs.Phone;
                    txtAddress.Text = aSuperViseorInfoTBs.Address;
                    MstID = aSuperViseorInfoTBs.ID;
                }
            }
            btnSave.Text = "Update";
            btnDelete.Enabled = true;
        }
    }
}
