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

namespace SBMS
{
    public partial class StockModule : Form
    {
        StockModuleManager _stockModuleManager = new StockModuleManager();
        public StockModule()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string categoryName = categoryTextBox.Text;
            string productName = productTextBox.Text;
            string startDate;
            string endDate;
            startDate = startDateTimePicker.Value.ToString();
            endDate = endDateTimePicker.Value.ToString();

            DataTable dataTable = _stockModuleManager.DisplayStockByDate(categoryName, productName, startDate, endDate);

            showDataGridView.DataSource = dataTable;
        }

        private void StockModule_Load(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _stockModuleManager.DisplayStockInfo();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _stockModuleManager.DisplayStockInfo();
        }
    }
}
