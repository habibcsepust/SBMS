using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBMS
{
    public partial class SBMSMDIParent : Form
    {
        private int childFormNumber = 0;

        public SBMSMDIParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void manageCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            CategoryUI categoryUI = new CategoryUI();
            categoryUI.Show();
        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ProductUI productUI = new ProductUI();
            productUI.Show();
        }

        private void manageCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            CustomerUI customerUI = new CustomerUI();
            customerUI.Show();
        }

        private void manageSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            SupplierUI supplierUI = new SupplierUI();
            supplierUI.Show();
        }

        private void purchaseProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseModuleUI purchaseModuleUI = new PurchaseModuleUI();
            purchaseModuleUI.Show();
        }

        private void salesProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesModuleUI salesModuleUI = new SalesModuleUI();
            salesModuleUI.Show();
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseReport purchaseReport = new PurchaseReport();
            purchaseReport.Show();
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesModuleReportUI salesModuleReportUI = new SalesModuleReportUI();
            salesModuleReportUI.Show();
        }

        private void stockModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockModule stockModule = new StockModule();
            stockModule.Show();
        }
    }
}
