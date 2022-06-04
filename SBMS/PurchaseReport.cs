using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBMS.Model;
using SBMS.BLL;
using SBMS.ViewModel;

namespace SBMS
{
    public partial class PurchaseReport : Form
    {
        Stock stock = new Stock();
        PurchaseReportManager _purchaseReportManager = new PurchaseReportManager();

        public PurchaseReport()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string startDate;
            string endDate;
            startDate = startDateTimePicker1.Value.ToString();
            endDate = endDateTimePicker2.Value.ToString();

            DataTable dataTable = _purchaseReportManager.SelectPurchaseInfo(startDate, endDate);

            purchaseReportDataGridView.DataSource = dataTable;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //List<PurchaseModuleView> purchaseReport = _purchaseReportManager.DisplayAllPurchaseInfo();
            //purchaseReportDataGridView.DataSource = purchaseReport;
            purchaseReportDataGridView.DataSource = _purchaseReportManager.DisplayAllPurchaseInfo();
        }

        private void PurchaseReport_Load(object sender, EventArgs e)
        {
            //List<PurchaseModuleView> purchaseReport = _purchaseReportManager.DisplayAllPurchaseInfo();
            //purchaseReportDataGridView.DataSource = purchaseReport;
            purchaseReportDataGridView.DataSource = _purchaseReportManager.DisplayAllPurchaseInfo();
        }

        private void purchaseReportDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
