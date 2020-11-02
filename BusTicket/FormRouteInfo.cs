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
    public partial class FormRouteInfo : Form
    {
        //Ro/*uteInfoTB model = new RouteInfoTB();*/
        public FormRouteInfo()
        {
            InitializeComponent();
        }

        private void FormRouteInfo_Load(object sender, EventArgs e)
        {
            comboLoadData();
        }

        private void comboLoadData()
        {
            using (BusDBEntities db = new BusDBEntities())
            {
                cmbBegCounter.DataSource = db.CounterInfoTBs.ToList();
                cmbBegCounter.ValueMember = "ID";
                cmbBegCounter.DisplayMember = "Name";

                cmbAddCounter.DataSource = db.CounterInfoTBs.ToList();
                cmbAddCounter.ValueMember = "ID";
                cmbAddCounter.DisplayMember = "Name";

                cmEndCounter.DataSource = db.CounterInfoTBs.ToList();
                cmEndCounter.ValueMember = "ID";
                cmEndCounter.DisplayMember = "Name";
            }
        }

        private void button1_Click(object sender, EventArgs e)     /*button1 is Add Button in */
        {
            if(cmbAddCounter.SelectedValue==null)
            {
                MessageBox.Show("Fill All Required Fild * ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(txtcounterdistance.Text) || string.IsNullOrEmpty(txtSerialNo.Text))
            {
                MessageBox.Show("Fill Serial and Distance Time * ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataGridViewRow dr in dgroaddetails.Rows)
            {
                if(dr.Cells[0].Value.ToString()==cmbAddCounter.SelectedValue.ToString())
                {
                    MessageBox.Show("Already Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if(dr.Cells[1].Value.ToString() == txtSerialNo.Text)
                {
                    MessageBox.Show("Already Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            dgroaddetails.Rows.Add(cmbAddCounter.SelectedValue,txtSerialNo.Text,cmbAddCounter.Text, txtcounterdistance.Text);
            clear_add();
        }

        void clear_add()
        {
            txtcounterdistance.Text = txtSerialNo.Text = "";
        }

        private void dgroaddetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==4)
            {
                dgroaddetails.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Fill All Required File * ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (BusDBEntities db = new BusDBEntities())
                {
                    RouteInfoTB aRouteInfoTB;
                    aRouteInfoTB = db.RouteInfoTBs.SingleOrDefault(a=> a.RouteID==0);
                    if(aRouteInfoTB!=null)
                    {

                    }
                    else
                    {
                        aRouteInfoTB = new RouteInfoTB();
                        aRouteInfoTB.Name = txtName.Text;
                        aRouteInfoTB.BegCounter = (int)cmbBegCounter.SelectedValue;
                        aRouteInfoTB.EndCounter =(int) cmEndCounter.SelectedValue;
                        db.RouteInfoTBs.Add(aRouteInfoTB);
                       
                        if (dgroaddetails.Rows.Count>0)
                        {
                            db.SaveChanges();
                            RouteDetailsTB aRouteDetailsTB;
                            foreach (DataGridViewRow dr in dgroaddetails.Rows)
                            {
                                
                                aRouteDetailsTB = new RouteDetailsTB();
                                aRouteDetailsTB.SerielNo = Convert.ToDecimal(dr.Cells[1].Value);
                                aRouteDetailsTB.RouteID = aRouteInfoTB.RouteID;
                                aRouteDetailsTB.NextCounter = (int)dr.Cells[0].Value;
                                aRouteDetailsTB.NCDistanceTime = dr.Cells[3].Value.ToString();
                                db.RouteDetailsTBs.Add(aRouteDetailsTB);
                             }
                        }
                        else
                        {
                            MessageBox.Show("Save Succesfully");
                            return;
                        }
                        db.SaveChanges();
                        MessageBox.Show("Save Succesfully");
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSerialNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            
        }

        private void txtcounterdistance_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            FormRouteUpdate.Instance.Show();
        }
    }
}
