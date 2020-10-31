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
    public partial class FormRouteUpdate : Form
    {
        public int MstID { get; set; }
        RouteInfoTB model = new RouteInfoTB();

        public FormRouteUpdate()
        {
            InitializeComponent();
        }
        void clear()
        {
            txtName.Text = "";
            btnSave.Enabled = false;
            model.RouteID = 0;
            MstID = 0;
        }
        void PopulateDataGridView()
        {
            dgRouteDetails.AutoGenerateColumns = false;
            using (BusDBEntities db = new BusDBEntities())
            {

                dgRouteDetails.Rows.Clear();
                foreach (var a in db.RouteInfoTBs.OrderByDescending(c => c.RouteID).ToList())
                {
                    dgRouteDetails.Rows.Add(a.RouteID, a.Name);
                }
            }
        }

        private static FormRouteUpdate _FormRouteUpdate;

        public static FormRouteUpdate Instance
        {
            get
            {
                if (_FormRouteUpdate == null || _FormRouteUpdate.IsDisposed)
                    _FormRouteUpdate = new FormRouteUpdate();
                return _FormRouteUpdate;
            }
        }

        private void FormRouteUpdate_Load(object sender, EventArgs e)
        {
            clear();
            PopulateDataGridView();
        }

        private void dgRouteDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = true;
            MstID = (int)dgRouteDetails.Rows[e.RowIndex].Cells[0].Value;
            using (BusDBEntities db = new BusDBEntities())
            {
                RouteInfoTB aRouteInfoTB;
                aRouteInfoTB = db.RouteInfoTBs.SingleOrDefault(a => a.RouteID == MstID);
                if (aRouteInfoTB != null)
                {
                    txtName.Text = aRouteInfoTB.Name;
                    MstID = aRouteInfoTB.RouteID;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (BusDBEntities db = new BusDBEntities())
            {
                model = db.RouteInfoTBs.SingleOrDefault(a => a.RouteID == MstID);
                if (model != null)
                {
                    model.Name = txtName.Text.Trim();
                    db.SaveChanges();
                    MstID = 0;
                    PopulateDataGridView();
                    clear();
                    MessageBox.Show("Update Successfully");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
            PopulateDataGridView();

        }
    }
}
