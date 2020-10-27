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
    }
}
