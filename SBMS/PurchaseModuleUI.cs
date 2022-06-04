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
    public partial class PurchaseModuleUI : Form
    {
        PurchaseModuleManager _purchaseManager = new PurchaseModuleManager();
        SupplierPurchase supplierPurchase = new SupplierPurchase();
        SupplierPurchaseDetails supplierPurchaseDetails = new SupplierPurchaseDetails();
        Supplier supplier = new Supplier();
        Category category = new Category();
        Product product = new Product();
        DataTable dataTable = new DataTable();
        string supplierCombo = "";
        string categoryCombo = "";
        string productCombo = "";

        public PurchaseModuleUI()
        {
            InitializeComponent();
        }

        private void PurchaseModuleUI_Load(object sender, EventArgs e)
        {
            supplier.Name = "--Select--";
            List<Supplier> loadSuppliers = _purchaseManager.LoadSupplier();
            loadSuppliers.Insert(0, supplier);
            supplierComboBox.DataSource = loadSuppliers;

            category.Name = "--Select--";
            List<Category> loadCategories = _purchaseManager.LoadCategory();
            loadCategories.Insert(0, category);
            categoryComboBox.DataSource = loadCategories;

            product.Name = "--Select--";
            List<Product> loadProducts = _purchaseManager.LoadProduct();
            loadProducts.Insert(0, product);
            productComboBox.DataSource = loadProducts;

            dataTable.Clear();
            dataTable.Columns.Add("CategoryId");
            dataTable.Columns.Add("ProductId"); 
            dataTable.Columns.Add("Category");
            dataTable.Columns.Add("Product");
            dataTable.Columns.Add("Code");
            dataTable.Columns.Add("AvailableQuantity");
            dataTable.Columns.Add("ManufacturedDate");
            dataTable.Columns.Add("ExpireDate");
            dataTable.Columns.Add("Remarks");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("UnitPrice");
            dataTable.Columns.Add("TotalPrice");
            dataTable.Columns.Add("PreviousUnitPrice");
            dataTable.Columns.Add("PreviousMRP");
            dataTable.Columns.Add("MRP");
            
            purchaseDataGridView.DataSource = dataTable;
        }
        public bool CheckIfNumeric(string input)
        {
            return input.IsNumeric();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string bill = billTextBox.Text;

            if (billTextBox.Text == "")
            {
                MessageBox.Show("Required Invoice No..");
                return;
            }
            else if (bill.Length < 4)
            {
                MessageBox.Show("Invoice No filed is required minimum 5 digit length");
                billTextBox.Clear();
                return;
            }
            try
            {
                supplierCombo = supplierComboBox.SelectedValue.ToString();

                if (Convert.ToInt32(supplierCombo) <= 0)
                {
                    MessageBox.Show("Please,, Select any Supplier..");
                    return;
                }
            }
            catch (Exception)

            {
                //MessageBox.Show(excp.Message);
                MessageBox.Show("Please,, Select any Supplier..");
                return;
            }

            try
            {
                categoryCombo = categoryComboBox.SelectedValue.ToString();

                if (Convert.ToInt32(categoryCombo) <= 0)
                {
                    MessageBox.Show("Please,, Select any Category..");
                    return;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(excp.Message);
                MessageBox.Show("Please,, Select any Category..");
                return;
            }

            try
            {
                productCombo = productComboBox.SelectedValue.ToString();

                if (Convert.ToInt32(productCombo) <= 0)
                {
                    MessageBox.Show("Please,, Select any Product..");
                    return;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(excp.Message);
                MessageBox.Show("Please,, Select any Product..");
                return;
            }

            if (aQuantityTextBox.Text == "" || remarksTextBox.Text == "" || quantityTextBox.Text == "" ||
                unitPriceTextBox.Text == "" || totalPriceTextBox.Text == "" || MRPTextBox.Text == ""||
                codeTextBox.Text == "")
            {
                MessageBox.Show("Please Product field is required..");
                return;
            }
            if (!CheckIfNumeric(quantityTextBox.Text))
            {
                MessageBox.Show("Please enter numeric Quantity.");
                codeTextBox.Clear();
                return;
            }
            if (!CheckIfNumeric(unitPriceTextBox.Text))
            {
                MessageBox.Show("Please enter numeric UnitPrice.");
                codeTextBox.Clear();
                return;
            }

            DataRow dr = dataTable.NewRow();
            dr["CategoryId"] = Convert.ToInt32(categoryComboBox.SelectedValue.ToString());
            dr["ProductId"] = Convert.ToInt32(productComboBox.SelectedValue.ToString());
            dr["Category"] = categoryComboBox.Text;
            dr["Product"] = productComboBox.Text;
            dr["Code"] = codeTextBox.Text;
            dr["AvailableQuantity"] = aQuantityTextBox.Text;
            dr["ManufacturedDate"] = menufactureDateTimePicker1.Value.ToString();
            dr["ExpireDate"] = eDateTimePicker2.Value.ToString();
            dr["Remarks"] = remarksTextBox.Text;
            dr["Quantity"] = quantityTextBox.Text;
            dr["UnitPrice"] = unitPriceTextBox.Text;
            dr["TotalPrice"] = totalPriceTextBox.Text;
            dr["PreviousUnitPrice"] = pUnitPriceTextBox.Text;
            dr["PreviousMRP"] = pMRPTextBox.Text;
            dr["MRP"] = MRPTextBox.Text;
            dataTable.Rows.Add(dr);
            purchaseDataGridView.DataSource = dataTable;
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryId = Convert.ToInt32(categoryComboBox.SelectedValue.ToString());

            product.Name = "--Select--";
            List<Product> loadProducts = _purchaseManager.SelectProduct(categoryId);
            loadProducts.Insert(0, product);
            productComboBox.DataSource = loadProducts;
        }

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(productComboBox.SelectedValue.ToString());
            string productName = productComboBox.Text;
            int productWiseQuantity = _purchaseManager.ProductWiseQuantity(productId);
            if (productWiseQuantity > 0)
            {
                aQuantityTextBox.Text = productWiseQuantity.ToString();
            }
            else
            {
                aQuantityTextBox.Text = 0.ToString();
            }
            

            codeTextBox.Text = _purchaseManager.SelectProductCode(productId).ToString();

            DataTable dataTable = _purchaseManager.SelectPreviousMRP(productId);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    pUnitPriceTextBox.Text = dataRow["UnitPrice"].ToString();
                    double previousMRP = Convert.ToDouble(pUnitPriceTextBox.Text) + Convert.ToDouble(pUnitPriceTextBox.Text) * 25 / 100;
                    pMRPTextBox.Text = previousMRP.ToString();
                }
            }
            else
            {
                pUnitPriceTextBox.Text = 0.ToString();
                pMRPTextBox.Text = 0.ToString();
            }
        }

        private void unitPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            double totalPrice = Convert.ToDouble(quantityTextBox.Text) * Convert.ToDouble(unitPriceTextBox.Text);
            totalPriceTextBox.Text = totalPrice.ToString();

            double MRP = Convert.ToDouble(unitPriceTextBox.Text) + Convert.ToDouble(unitPriceTextBox.Text) * 25 / 100;
            MRPTextBox.Text = MRP.ToString();
        }

        int countRecord = 0;
        string purchaseCode = "";
        int i = 0;
        private void submitButton_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(productComboBox.SelectedValue.ToString());
            product.Name = productComboBox.Text;

            int totRows = dataTable.Rows.Count;
            if (totRows == 0)
            {
                MessageBox.Show("Please, before submit Click to add product Item");
                return;
            }

            supplierPurchase.Date = sDateTimePicker.Value.ToString();
            supplierPurchase.BillNo = billTextBox.Text;
            supplierPurchase.SupplierId = Convert.ToInt32(supplierComboBox.SelectedValue.ToString());
            _purchaseManager.SaveSupplierPurchase(supplierPurchase);
            int maxPurchaseId = _purchaseManager.MaxIdOfPurchase();

            double profit = Convert.ToDouble(MRPTextBox.Text) - Convert.ToDouble(unitPriceTextBox.Text);
            foreach (DataRow dr in dataTable.Rows)
            {
                if (i == 0)
                {
                    countRecord = _purchaseManager.CountRecord();
                    i++;
                }
                purchaseCode = "2019-000" + ++countRecord;
                //codeTextBox.Text = purchaseCode;

                supplierPurchaseDetails.SupplierPurchaseId = maxPurchaseId;
                supplierPurchaseDetails.CategoryId = Convert.ToInt32(dr["CategoryId"].ToString());
                supplierPurchaseDetails.ProductId = Convert.ToInt32(dr["ProductId"].ToString());
                supplierPurchaseDetails.Category = dr["Category"].ToString();
                supplierPurchaseDetails.Product = dr["Product"].ToString();
                supplierPurchaseDetails.PurchaseCode = purchaseCode;
                supplierPurchaseDetails.Code = dr["Code"].ToString();
                supplierPurchaseDetails.AvailableQuantity = dr["AvailableQuantity"].ToString();
                supplierPurchaseDetails.ManufacturedDate = dr["ManufacturedDate"].ToString();
                supplierPurchaseDetails.ExpireDate = dr["ExpireDate"].ToString();
                supplierPurchaseDetails.Remarks = dr["Remarks"].ToString();
                supplierPurchaseDetails.Quantity = Convert.ToDouble(dr["Quantity"].ToString());
                supplierPurchaseDetails.UnitPrice = Convert.ToDouble(dr["UnitPrice"].ToString());
                supplierPurchaseDetails.TotalPrice = Convert.ToDouble(dr["TotalPrice"]);
                supplierPurchaseDetails.PreviousUnitPrice = Convert.ToDouble(dr["PreviousUnitPrice"].ToString());
                supplierPurchaseDetails.PreviousMRP = Convert.ToDouble(dr["PreviousMRP"].ToString());
                supplierPurchaseDetails.MRP = Convert.ToDouble(dr["MRP"].ToString());

                bool isAddPurchaseItem = _purchaseManager.AddStock(supplierPurchaseDetails);

                if (!_purchaseManager.IsPurchaseProductName(supplierPurchaseDetails.ProductId))
                {
                    _purchaseManager.AddPurchaseItem(supplierPurchaseDetails);
                }
                else
                {
                    _purchaseManager.UpdatePurchaseProductQty(supplierPurchaseDetails);
                }
            }

            dataTable.Clear();
            purchaseDataGridView.DataSource = dataTable;
            MessageBox.Show("Iserted Successfully..");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            dataTable.Rows.RemoveAt(Convert.ToInt32(purchaseDataGridView.CurrentCell.RowIndex.ToString()));
            int totRows = dataTable.Rows.Count; 
        }
    }
}
