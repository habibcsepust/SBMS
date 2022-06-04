using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBMS.BLL;
using SBMS.Model;
using SBMS.ViewModel;

namespace SBMS
{
    public partial class SalesModuleReportUI : Form
    {
        SaleModuleManager _saleModuleManager = new SaleModuleManager();
        SalesView salesView = new SalesView();
        public SalesModuleReportUI()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string startDate = startDateTimePicker1.Value.ToString();
            string endDate = endDateTimePicker2.Value.ToString();
            salesReportDataGridView.DataSource = _saleModuleManager.SearchSalesRecord(startDate, endDate);
        }

        private void SalesModuleReportUI_Load(object sender, EventArgs e)
        {
            salesReportDataGridView.DataSource = _saleModuleManager.DisplaySalesInfo();
            SL();
        }

        public void SL()
        {
            int i = 1;
            foreach (DataGridViewRow rows in salesReportDataGridView.Rows)
            {
                rows.Cells[0].Value = i;
                i++;
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            salesReportDataGridView.DataSource = _saleModuleManager.DisplaySalesInfo();
        }
    }
}
