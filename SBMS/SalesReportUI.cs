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

namespace SBMS
{
    public partial class SalesReportUI : Form
    {
        SalesManager _salesManager = new SalesManager();

        public SalesReportUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {

        }

        private void SalesReportUI_Load(object sender, EventArgs e)
        {
            salesReportDataGridView.DataSource = _salesManager.DisplaySalesInfo();
        }
    }
}
