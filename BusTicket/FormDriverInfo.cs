﻿using System;
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
    public partial class FormDriverInfo : Form
    {
        DriverInfoTB model = new DriverInfoTB();
        
        public FormDriverInfo()
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
            dgvDriverInfo.AutoGenerateColumns = false;
            using (BusDBEntities db = new BusDBEntities())
            {

                dgvDriverInfo.Rows.Clear();
                foreach (var a in db.DriverInfoTBs.OrderByDescending(c => c.ID).ToList())
                {
                    dgvDriverInfo.Rows.Add(a.ID, a.Name, a.Phone, a.Address);
                }
            }
        }
        private void FormDriverInfo_Load(object sender, EventArgs e)
        {
            clear();
            PopulateDataGridView();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (BusDBEntities db = new BusDBEntities())
            {
                model = db.DriverInfoTBs.SingleOrDefault(a => a.ID == MstID);
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
                    model = new DriverInfoTB();
                    model.Name = txtName.Text.Trim();
                    model.Phone = txtPhone.Text.Trim();
                    model.Address = txtAddress.Text.Trim();
                    db.DriverInfoTBs.Add(model);
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
                    model = db.DriverInfoTBs.SingleOrDefault(a => a.ID == MstID);
                    if (model != null)
                    {
                        db.DriverInfoTBs.Remove(model);
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
        private void dgvDriverInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(dgvDriverInfo.Rows[e.RowIndex].Cells[0].Value.ToString());
            DriverInfoTB aDriverInfoTBs;

            using (BusDBEntities db = new BusDBEntities())
            {
                aDriverInfoTBs = db.DriverInfoTBs.SingleOrDefault(c => c.ID == ID);
                if (aDriverInfoTBs != null)
                {
                    txtName.Text = aDriverInfoTBs.Name;
                    txtPhone.Text = aDriverInfoTBs.Phone;
                    txtAddress.Text = aDriverInfoTBs.Address;
                    MstID = aDriverInfoTBs.ID;
                }
            }
            btnSave.Text = "Update";
            btnDelete.Enabled = true;
        }
    }
}
