using Digital_app;
using Microsoft.Reporting.WinForms;
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
    public partial class frmReportViewer : Form
    {
        public frmReportViewer()
        {
            InitializeComponent();
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {

            this.rptOthersreportviewer.RefreshReport();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using (var posContext = new BusDBEntities())
            {
                DataTable dt = IdManager.GetShowDataTable("Select  * from [dbo].[View_TicketSalesInfo] where  Convert(date,TicketSaleTime,103) between Convert(date,'" + dtpFromDate.Value.Date.ToString("dd/MM/yyyy") + "',103) and Convert(date,'" + dtpTodate.Value.Date.ToString("dd/MM/yyyy") + "',103)");
                // List<CompanyInfo> ACompany = posContext.vie.ToList();
                // DataTable dtCompany = Global.LINQToDataTable(ACompany);
                if (dt.Rows.Count > 0)
                {
                    rptOthersreportviewer.ProcessingMode = ProcessingMode.Local;
                    // DataTable dt2 = IdManager.GetShowDataTable("SELECT     SUM(Expanse) AS Expanse, SUM(Revenue) AS Revenue, SUM(Profit) AS Profit FROM dbo.DailyStatus where  Convert(date,Date,103) between Convert(date,'" + dtpStartDate.Value.Date.ToString("dd/MM/yyyy") + "',103) and Convert(date,'" + dtpEmdDate.Value.Date.ToString("dd/MM/yyyy") + "',103)");

                    //string reportPath = Path.Combine(exeFolder, @"Reports\PurchaseInfo.rdlc");
                    rptOthersreportviewer.LocalReport.ReportEmbeddedResource = "BusTicket.Report.rptSalesInfo.rdlc";

                    //ReportDataSource rds = new ReportDataSource("Sales", dt);
                    rptOthersreportviewer.LocalReport.DataSources.Clear();
                   // rptOthersreportviewer.LocalReport.DataSources.Add(rds);
                    rptOthersreportviewer.LocalReport.DataSources.Add(new ReportDataSource("Sales", dt));

                    //rptOthersreportviewer.LocalReport.SetParameters(new ReportParameter("ReportDate", dtpFromDate.Value.Date.ToString("dd/MM/yyyy") + " To " + dtpTodate.Value.Date.ToString("dd/MM/yyyy")));


                    rptOthersreportviewer.LocalReport.Refresh();
                    rptOthersreportviewer.RefreshReport();
                }
            }
        }
    }
}
