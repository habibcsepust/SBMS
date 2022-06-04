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

namespace SBMS
{
    public partial class SalesModuleUI : Form
    {
        SaleModuleManager _saleModuleManager = new SaleModuleManager();
        Sale sale = new Sale();
        Customer customer = new Customer();
        Category category = new Category();
        //Product product = new Product();
        Stock stock = new Stock();
        PurchaseDetails purchaseDetails = new PurchaseDetails();
        SupplierPurchaseDetails supplierPurchaseDetails = new SupplierPurchaseDetails();
        DataTable dataTable = new DataTable();
        DetailSaleInfo saleDetails = new DetailSaleInfo();
        TemporaryLoyalityPoint temporaryLoyalityPoint = new TemporaryLoyalityPoint();

        double passLoyalityToSale;
        string customerCombo = "";
        string categoryCombo = "";
        string productCombo = "";
        double unitPrice;
        double MRP;
        double total;
        int id;
        int i;
        int countRecord;
        double count;

        public SalesModuleUI()
        {
            InitializeComponent();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                customerCombo = customerComboBox.SelectedValue.ToString();

                if (Convert.ToInt32(customerCombo) <= 0)
                {
                    MessageBox.Show("Please,, Select any Customer..");
                    return;
                }
            }
            catch (Exception excp)
            {
                //MessageBox.Show(excp.Message);
                MessageBox.Show("Please,, Select any Customer..");
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

            if (productComboBox.Text == "")
            {
                MessageBox.Show("Select Product");
            }
            //try
            //{
            //    productCombo = productComboBox.SelectedValue.ToString();

            //    if (Convert.ToInt32(productCombo) <= 0)
            //    {
            //        MessageBox.Show("Please,, Select any Product..");
            //        return;
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Please,, Select any Product..");
            //    return;
            //}
            if (quantityTextBox.Text == "")
            {
                MessageBox.Show("Quantity field is requirde..");
                return;
            }
            if (MRPTextBox.Text == "")
            {
                MessageBox.Show("MRP field is required..");
                return;
            }

            if (!CheckIfNumeric(quantityTextBox.Text))
            {
                MessageBox.Show("Please enter numeric Quantity.");
                quantityTextBox.Clear();
                return;
            }

            //if (!CheckIfNumeric(MRPTextBox.Text))
            //{
            //    MessageBox.Show("Please enter numeric MRP.");
            //    MRPTextBox.Clear();
            //    return;
            //}

            if (Convert.ToDouble(quantityTextBox.Text) > Convert.ToDouble(aQuantityTextBox.Text))
            {
                MessageBox.Show("Sorry..! There no more available quantity..");
                return;
            }

            DataRow dr = dataTable.NewRow();
            dr["CategoryId"] = Convert.ToInt32(categoryComboBox.SelectedValue.ToString());
            dr["ProductId"] = Convert.ToInt32(productComboBox.SelectedValue.ToString());
            dr["Category"] = categoryComboBox.Text;
            dr["Product"] = productComboBox.Text;
            dr["AvailableQuantity"] = aQuantityTextBox.Text;
            dr["Quantity"] = quantityTextBox.Text;
            dr["MRP"] = MRPTextBox.Text;
            dr["TotalMRP"] = totalMRPTextBox.Text;
            dataTable.Rows.Add(dr);
            salesDataGridView.DataSource = dataTable;


             total = total + Convert.ToDouble(totalMRPTextBox.Text);
            grandTotalTextBox.Text = total.ToString();

            double loyatiPoint = total / 1000;
            

            //Insert Temporary Loyality Point
            temporaryLoyalityPoint.CustomerId = Convert.ToInt32(customerComboBox.SelectedValue.ToString());
            temporaryLoyalityPoint.LoyalityPoint = Convert.ToDouble(loyaltyPointTextBox.Text);
            //_saleModuleManager.AddLoyalityPoint(temporaryLoyalityPoint);
            if (!_saleModuleManager.IsExistCustomer(temporaryLoyalityPoint.CustomerId))
            {
                _saleModuleManager.AddLoyalityPoint(temporaryLoyalityPoint, loyatiPoint);
            }
            else
            {
                _saleModuleManager.UpdateCustomerLty(loyatiPoint, temporaryLoyalityPoint.CustomerId);
            }
            LoyalityCalculation();
            passLoyalityToSale = loyatiPoint;
            //double totalLoyality = loyatiPoint + Convert.ToDouble(loyaltyPointTextBox.Text);
            //loyaltyPointTextBox.Text = totalLoyality.ToString();
            // MessageBox.Show("Added .." + Convert.ToDouble(loyaltyPointTextBox.Text));
            double discount = Convert.ToDouble(loyaltyPointTextBox.Text) / 10;
            discountTextBox.Text = discount.ToString();
            double discountAmount = total * discount / 100;
            discountAmountTextBox.Text = discountAmount.ToString();
            double payableAmount = total - discountAmount;
            payableAmountTextBox.Text = payableAmount.ToString();
            MessageBox.Show("Added Successfully.."+ Convert.ToDouble(loyaltyPointTextBox.Text));

        }
        public bool CheckIfNumeric(string input)
        {
            return input.IsNumeric();
        }

        
        private void submitButton_Click(object sender, EventArgs e)
        {
            int totRows = dataTable.Rows.Count;
            if (totRows == 0)
            {
                MessageBox.Show("Please, before submit Click to add product Item");
                return;
            }
            sale.CustomerId = Convert.ToInt32(customerComboBox.SelectedValue.ToString());
            sale.Date = dateTimePicker.Value.ToString();
            sale.LoyalityPoint = passLoyalityToSale;
            _saleModuleManager.SaveSale(sale);
            int maxSaleId = _saleModuleManager.MaxIdOfSale();

            //Profit Calculation
            //int customerId = Convert.ToInt32(customerComboBox.SelectedValue.ToString());
            //List<Sale> loyalityPoints = _saleModuleManager.CustomerLoyalityPoint(customerId);
            //foreach (Sale loyalityPoint in loyalityPoints)
            //{
            //    CustomerLoyalityPoint += loyalityPoint.LoyalityPoint;
            //}
            //double cl = CustomerLoyalityPoint;
            double grantTotal = Convert.ToDouble(grandTotalTextBox.Text);
            //double loyatiPoint = grantTotal / 1000;
            double discount = Convert.ToDouble(loyaltyPointTextBox.Text) / 10;
            double discountAmount = grantTotal * discount / 100;
            double unitPlusDiscount = unitPrice + discountAmount;
            double profit = MRP - unitPlusDiscount;

            //unitPrice,MRP,Profit

            foreach (DataRow dr in dataTable.Rows)
            {
                if (i == 0)
                {
                    countRecord = _saleModuleManager.CountRecord();
                    i++;
                }
                string rowCount = "2019-000" + ++countRecord;
                saleDetails.Code = rowCount.ToString();
                saleDetails.SaleId = maxSaleId;
                saleDetails.CategoryId = Convert.ToInt32(dr["CategoryId"].ToString());
                saleDetails.ProductId = Convert.ToInt32(dr["ProductId"].ToString());
                saleDetails.Category = dr["Category"].ToString();
                saleDetails.Product = dr["Product"].ToString();
                saleDetails.AvailableQuantity = Convert.ToDouble(dr["AvailableQuantity"].ToString());
                saleDetails.Quantity = Convert.ToDouble(dr["Quantity"].ToString());
                saleDetails.MRP = Convert.ToDouble(dr["MRP"].ToString());
                saleDetails.TotalMRP = Convert.ToDouble(dr["TotalMRP"].ToString());
                saleDetails.UnitPrice = unitPrice;
                saleDetails.Profit = profit;
                if (profit < 150)
                {
                    profit = 150;
                }
                

                _saleModuleManager.AddSaleStock(saleDetails);

                if (!_saleModuleManager.IsSalesProductName(saleDetails.Product))
                {
                    _saleModuleManager.SaveDetailsSale(saleDetails, saleDetails.UnitPrice, profit);
                }
                else
                {
                    _saleModuleManager.UpdateSalesProductQty(saleDetails, profit);
                }

                string product = dr["Product"].ToString();
                _saleModuleManager.UpdateStockQty(saleDetails.Quantity, saleDetails.Product);
            }

            //Delete Temporary Loyality Point
            int customerId = Convert.ToInt32(customerComboBox.SelectedValue.ToString());
            _saleModuleManager.DeleteLoyalityPoint(customerId);
            LoyalityCalculation();

            dataTable.Clear();
            salesDataGridView.DataSource = dataTable;
            total = 0;
            MessageBox.Show("Iserted Successfully..");

            aQuantityTextBox.Clear();
            quantityTextBox.Text = 0.ToString();
            MRPTextBox.Clear();
            totalMRPTextBox.Clear();

            grandTotalTextBox.Clear();
            discountTextBox.Clear();
            discountAmountTextBox.Clear();
            payableAmountTextBox.Clear();
        }

        private void showGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SalesModuleUI_Load(object sender, EventArgs e)
        {
            customer.Name = "--Select--";
            List<Customer> loadCustomers = _saleModuleManager.LoadCustomer();
            loadCustomers.Insert(0, customer);
            customerComboBox.DataSource = loadCustomers;

            category.Name = "--Select--";
            List<Category> loadCategories = _saleModuleManager.LoadCategory();
            loadCategories.Insert(0, category);
            categoryComboBox.DataSource = loadCategories;

            supplierPurchaseDetails.Product = "--Select--";
            List<SupplierPurchaseDetails> loadProducts = _saleModuleManager.LoadProduct();
            loadProducts.Insert(0, supplierPurchaseDetails);
            productComboBox.DataSource = loadProducts;

            dataTable.Clear();
            dataTable.Columns.Add("CategoryId");
            dataTable.Columns.Add("ProductId");
            dataTable.Columns.Add("Category");
            dataTable.Columns.Add("Product");
            dataTable.Columns.Add("AvailableQuantity");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("MRP");
            dataTable.Columns.Add("TotalMRP");
            salesDataGridView.DataSource = dataTable;
    }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryId = Convert.ToInt32(categoryComboBox.SelectedValue.ToString());

            supplierPurchaseDetails.Product = "--Select--";
            List<SupplierPurchaseDetails> loadProducts = _saleModuleManager.SelectProduct(categoryId);
            loadProducts.Insert(0, supplierPurchaseDetails);
            productComboBox.DataSource = loadProducts;
        }

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productName = productComboBox.Text;
            //int productId = Convert.ToInt32(productComboBox.SelectedValue.ToString());
            int countProducts = _saleModuleManager.CountProduct(productName);

            if (countProducts > 0)
            {
                aQuantityTextBox.Text = countProducts.ToString();
            }
            else
            {
                aQuantityTextBox.Text = 0.ToString();
            }

            
            DataTable dataTable = _saleModuleManager.MRPCalculate(productName);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    unitPrice = Convert.ToDouble(dataRow["UnitPrice"].ToString());
                    MRP = Convert.ToDouble(dataRow["MRP"].ToString());
                    MRPTextBox.Text = MRP.ToString();
                }
            }
            else
            {
                MRPTextBox.Text = "";
            }
        }

        private void MRPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                total = 0;
                double loyatiPoint = 0;
                dataTable.Rows.RemoveAt(Convert.ToInt32(salesDataGridView.CurrentCell.RowIndex.ToString()));
                int totRows = dataTable.Rows.Count;
                if (totRows == 0)
                {
                    grandTotalTextBox.Text = " ";
                    loyaltyPointTextBox.Text = "";
                    discountTextBox.Text = "";
                    discountAmountTextBox.Text = " ";
                    payableAmountTextBox.Text = " ";
                }

                foreach (DataRow dataRow1 in dataTable.Rows)
                {
                    total = total + Convert.ToInt32(dataRow1["TotalMRP(TK)"].ToString());
                    grandTotalTextBox.Text = total.ToString();

                    loyatiPoint = total / 1000;
                    loyaltyPointTextBox.Text = loyatiPoint.ToString();

                    double discount = loyatiPoint / 10;
                    discountTextBox.Text = discount.ToString();

                    double discountAmount = total * discount / 100;
                    discountAmountTextBox.Text = discountAmount.ToString();

                    double payableAmount = total - discountAmount;
                    payableAmountTextBox.Text = payableAmount.ToString();
                }
                //Update Loyality Point
                _saleModuleManager.UpdateCustomerLty(loyatiPoint, temporaryLoyalityPoint.CustomerId);
                LoyalityCalculation();

            }
            catch (Exception)
            {
                MessageBox.Show("No available data");
            }
        }

        private void LoyalityCalculation()
        {
            int customerId = Convert.ToInt32(customerComboBox.SelectedValue.ToString());
            double customerLPoint = _saleModuleManager.LoyalityPoint(customerId);
            List<TemporaryLoyalityPoint> tempLPoints = _saleModuleManager.SelectTempLoyality(customerId);
            if (tempLPoints.Count > 0)
            {
                foreach (TemporaryLoyalityPoint tempLPoint in tempLPoints)
                {
                    temporaryLoyality += tempLPoint.LoyalityPoint;
                }
                CustomerLoyalityPoint = customerLPoint + temporaryLoyality;
                loyaltyPointTextBox.Text = (CustomerLoyalityPoint).ToString();
                CustomerLoyalityPoint = 0;
                temporaryLoyality = 0;
            }
            else
            {
                loyaltyPointTextBox.Text = (customerLPoint).ToString();
                CustomerLoyalityPoint = 0;
            }
        }

        double CustomerLoyalityPoint = 0;
        double temporaryLoyality = 0;
        //double endLPoint;
        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoyalityCalculation();
            //int customerId = Convert.ToInt32(customerComboBox.SelectedValue.ToString());
            //double customerLPoint = _saleModuleManager.LoyalityPoint(customerId);
            //List < TemporaryLoyalityPoint > tempLPoints = _saleModuleManager.SelectTempLoyality(customerId);
            //if (tempLPoints.Count > 0)
            //{
            //    foreach (TemporaryLoyalityPoint tempLPoint in tempLPoints)
            //    {
            //        temporaryLoyality += tempLPoint.LoyalityPoint;
            //    }
            //    CustomerLoyalityPoint = customerLPoint + temporaryLoyality;
            //    loyaltyPointTextBox.Text = (CustomerLoyalityPoint).ToString();
            //    CustomerLoyalityPoint = 0;
            //    temporaryLoyality = 0;
            //}
            //else
            //{
            //    loyaltyPointTextBox.Text = (customerLPoint).ToString();
            //    CustomerLoyalityPoint = 0;
            //}

            //int customerId = Convert.ToInt32(customerComboBox.SelectedValue.ToString());
            // DataTable endLoyalityPoint = _saleModuleManager.CustomerEndLoyalityPoint(customerId);
            // if (endLoyalityPoint.Rows.Count > 0)
            // {
            //     foreach (DataRow dataRow in endLoyalityPoint.Rows)
            //     {
            //         endLPoint = Convert.ToDouble(dataRow["LoyalityPoint"].ToString());
            //     }
            // }

            //List<Sale> loyalityPoints = _saleModuleManager.CustomerLoyalityPoint(customerId);
            //foreach (Sale loyalityPoint in loyalityPoints)
            //{
            //    CustomerLoyalityPoint += loyalityPoint.LoyalityPoint;
            //}
            ////if (CustomerLoyalityPoint != 0)
            ////{
            ////    CustomerLoyalityPoint = CustomerLoyalityPoint - endLPoint;
            ////}
            //loyaltyPointTextBox.Text = (CustomerLoyalityPoint).ToString();
            //CustomerLoyalityPoint = 0;
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MRPTextBox.Text == "")
            {
                MessageBox.Show("Required MRP Field..");
                return;
            }
            if (quantityTextBox.Text == "")
            {
                MessageBox.Show("Required quantity Field..");
                return;
            }
            double totalMRP = Convert.ToDouble(quantityTextBox.Text) * Convert.ToDouble(MRPTextBox.Text);
            totalMRPTextBox.Text = totalMRP.ToString();
        }
    }
}
