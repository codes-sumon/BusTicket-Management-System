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
        public FormRouteUpdate()
        {
            InitializeComponent();
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

        }
    }
}
