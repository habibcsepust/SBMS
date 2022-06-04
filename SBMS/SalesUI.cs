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
    public partial class SalesUI : Form
    {
        SalesManager _salesManager = new SalesManager();
        Sales sale = new Sales();
        Customer customer = new Customer();
        Category category = new Category();
        Product product = new Product();
        PurchaseDetails purchaseDetails = new PurchaseDetails();
        DataTable dataTable = new DataTable();
        Sales_Details salesDetails = new Sales_Details();
        Sales_Amount sales_Amount = new Sales_Amount();

        string customerCombo = "";
        string categoryCombo = "";
        string productCombo = "";
        double unitPrice;
        double total;
        int id;

        public SalesUI()
        {
            InitializeComponent();
        }

        int i;
        int countRecord;
        double count;
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
            catch (Exception excp)
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
            catch (Exception excp)
            {
                //MessageBox.Show(excp.Message);
                MessageBox.Show("Please,, Select any Product..");
                return;
            }

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

            //if (addButton.Text == "Update")
            //{
            //    salesDetails.Product = productComboBox.Text;
            //    salesDetails.AvailableQuantity = Convert.ToDouble(aQuantityTextBox.Text);
            //    salesDetails.Quantity = Convert.ToDouble(quantityTextBox);
            //    salesDetails.MRP = Convert.ToDouble(MRPTextBox.Text);
            //    salesDetails.TotalMRP = Convert.ToDouble(totalMRPTextBox.Text);

            //    showGridView.Visible = true;
            //    salesDataGridView.Visible = false;
            //    if (_salesManager.UpdateSalesItem(salesDetails, id))
            //    {
            //        MessageBox.Show("Sales Product Updated Successfully");
            //        Edit();
            //        List<Sales_Details> sales_Details = _salesManager.DisplaySalesItem();
            //        showGridView.DataSource = sales_Details;
            //        SL();
            //        addButton.Text = "Save";
            //        Clear();
            //        return;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Purchase Product Not Updated, Check details");
            //        return;
            //    }
            //}

            if (!CheckIfNumeric(MRPTextBox.Text))
            {
                MessageBox.Show("Please enter numeric MRP.");
                MRPTextBox.Clear();
                return;
            }

            sale.CustomerId = Convert.ToInt32(customerComboBox.SelectedValue.ToString());
            sale.Date = dateTimePicker.Value.ToString("dd/mm/yyyy");
            sale.LoyalityPoint = Convert.ToDouble(loyaltyPointTextBox.Text);
            sale.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue.ToString());
            sale.ProductId = Convert.ToInt32(productComboBox.SelectedValue.ToString());
            sale.AvailableQuantity = Convert.ToDouble(aQuantityTextBox.Text);
            sale.Quantity = Convert.ToDouble(quantityTextBox.Text);
            sale.MRP = Convert.ToDouble(MRPTextBox.Text);
            sale.TotalMRP = Convert.ToDouble(totalMRPTextBox.Text);

            if (Convert.ToDouble(quantityTextBox.Text) > Convert.ToDouble(aQuantityTextBox.Text))
            {
                MessageBox.Show("Sorry..! There no more available quantity..");
                return;
            }

            //if (_salesManager.SaveSalesItem(sale))
            //{

            salesDataGridView.Visible = true;
            showGridView.Visible = false;
                MessageBox.Show("Added Successfully..");

                deleteButton.Visible = true;

                DataRow dr = dataTable.NewRow();
                dr["Product"] = productComboBox.Text;
                dr["Quantity"] = quantityTextBox.Text;
                dr["MRP(TK)"] = MRPTextBox.Text;
                dr["TotalMRP(TK)"] = totalMRPTextBox.Text;
                dataTable.Rows.Add(dr);
                salesDataGridView.DataSource = dataTable;

                total = total + Convert.ToDouble(totalMRPTextBox.Text);
                grandTotalTextBox.Text = total.ToString();

                double loyatiPoint = total / 1000;
                loyaltyPointTextBox.Text = loyatiPoint.ToString();

                double discount = loyatiPoint / 10;
                discountTextBox.Text = discount.ToString();

                double discountAmount = total * discount / 100;
                discountAmountTextBox.Text = discountAmount.ToString();

                double payableAmount = total - discountAmount;
                payableAmountTextBox.Text = payableAmount.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Not added");
            //}

        }
        public bool CheckIfNumeric(string input)
        {
            return input.IsNumeric();
        }

        private void SalesUI_Load(object sender, EventArgs e)
        {
            showGridView.Visible = true;
            salesDataGridView.Visible = false;

            customer.Name = "--Select--";
            List<Customer> loadCustomers = _salesManager.LoadCustomer();
            loadCustomers.Insert(0, customer);
            customerComboBox.DataSource = loadCustomers;

            category.Name = "--Select--";
            List<Category> loadCategories = _salesManager.LoadCategory();
            loadCategories.Insert(0, category);
            categoryComboBox.DataSource = loadCategories;

            purchaseDetails.Product = "--Select--";
            List<PurchaseDetails> loadProducts = _salesManager.LoadProduct();
            loadProducts.Insert(0, purchaseDetails);
            productComboBox.DataSource = loadProducts;

            showGridView.Visible = true;
            salesDataGridView.Visible = false;
            List<Sales_Details> sales_Details = _salesManager.DisplaySalesItem();
            showGridView.DataSource = sales_Details;
            SL();
            addButton.Text = "Add";
            EditAction();
            deleteButton.Visible = false;

            //Clear();

            dataTable.Clear();
            dataTable.Columns.Add("Product");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("MRP(TK)");
            dataTable.Columns.Add("TotalMRP(TK)");
        }

        public void SL()
        {
            int i = 1;
            foreach (DataGridViewRow rows in showGridView.Rows)
            {
                rows.Cells[0].Value = i;
                i++;
            }
        }

        private void EditAction()
        {
            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            Editlink.UseColumnTextForLinkValue = true;
            Editlink.HeaderText = "Action";
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            Editlink.Text = "Edit";
            showGridView.Columns.Add(Editlink);
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sale.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue.ToString());

            purchaseDetails.Product = "--Select--";
            List<PurchaseDetails> loadProducts = _salesManager.SelectProduct(sale);
            loadProducts.Insert(0, purchaseDetails);
            productComboBox.DataSource = loadProducts;
        }

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string productName = productComboBox.Text;
            int countProducts = _salesManager.CountProduct(productName);
            
            if (countProducts > 0)
            {
                aQuantityTextBox.Text = countProducts.ToString();
            }
            else
            {
                aQuantityTextBox.Text = 0.ToString();
            }

            sale.ProductId = Convert.ToInt32(productComboBox.SelectedValue.ToString());

            //DataTable dataTble = _salesManager.ProductUnitPrice(sale.ProductId);
            //foreach (DataRow dr in dataTble.Rows)
            //{
            //    unitPrice = Convert.ToDouble(dr["UnitPrice"].ToString());
            //}
        }

        double enTotal;
        private void MRPTextBox_TextChanged(object sender, EventArgs e)
        {
            //double totlMRP = 0;
            if (MRPTextBox.Text == "")
            {
                MessageBox.Show("Required MRP textbox..");
                return;
            }

            double totalMRP = Convert.ToDouble(quantityTextBox.Text) * Convert.ToDouble(MRPTextBox.Text);
            totalMRPTextBox.Text = totalMRP.ToString();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //addButton.Text = "Update";
            showGridView.Visible = true;
            salesDataGridView.Visible = false;
            deleteButton.Visible = false;

            int totRows = dataTable.Rows.Count;
            if (totRows == 0)
            {
                MessageBox.Show("Please, before submit Click to add product Item");
                return;
            }
            foreach (DataRow dr in dataTable.Rows)
            {
                if (i == 0)
                {
                    countRecord = _salesManager.CountRecord();
                    i++;
                }
                string rowCount = "2019-000" + ++countRecord;

                salesDetails.CustomerId = Convert.ToInt32(customerComboBox.SelectedValue.ToString());
                salesDetails.Date = dateTimePicker.Value.ToString("mm/dd/yyyy");
                salesDetails.LoyalityPoint = Convert.ToDouble(loyaltyPointTextBox.Text);
                salesDetails.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue.ToString());
                salesDetails.ProductId = Convert.ToInt32(productComboBox.SelectedValue.ToString());
                salesDetails.SalesCode = rowCount;
                salesDetails.Product = dr["Product"].ToString();
                salesDetails.AvailableQuantity = Convert.ToDouble(aQuantityTextBox.Text);
                salesDetails.Quantity = Convert.ToDouble(dr["Quantity"].ToString());
                salesDetails.MRP = Convert.ToDouble(dr["MRP(TK)"].ToString());
                salesDetails.TotalMRP = Convert.ToDouble(dr["TotalMRP(TK)"].ToString());


                double soldPrice = salesDetails.MRP + salesDetails.MRP * 25 / 100;
                double profit = soldPrice - salesDetails.MRP;

                //bool isAddPurchaseItem = _salesManager.AddSalesItem(salesDetails, soldPrice, profit);
                if (!_salesManager.IsStockProductName(salesDetails.Product))
                {
                    _salesManager.AddSalesItem(salesDetails, soldPrice, profit);
                }
                else
                {
                    _salesManager.UpdateSalesQty(salesDetails.Product, salesDetails.Quantity);
                }

                _salesManager.UpdateStockQty(salesDetails);
            }

            sales_Amount.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue.ToString());
            sales_Amount.ProductId = Convert.ToInt32(productComboBox.SelectedValue.ToString());
            sales_Amount.GrandTotal = Convert.ToDouble(grandTotalTextBox.Text);
            sales_Amount.Discount = Convert.ToDouble(discountTextBox.Text);
            sales_Amount.DiscountAmount = Convert.ToDouble(discountAmountTextBox.Text);
            sales_Amount.PayableAmount = Convert.ToDouble(payableAmountTextBox.Text);

            bool isAddSalesAmount = _salesManager.AddSalesAmount(sales_Amount);

            grandTotalTextBox.Text = "";
            discountTextBox.Text = "";
            discountAmountTextBox.Text = "";
            payableAmountTextBox.Text = "";

            showGridView.Visible = true;
            salesDataGridView.Visible = false;
            List<Sales_Details> sales_Details = _salesManager.DisplaySalesItem();
            showGridView.DataSource = sales_Details;
            SL();
            addButton.Text = "Add";
            //Clear();

            dataTable.Clear();
            salesDataGridView.DataSource = dataTable;
            total = 0;
            MessageBox.Show("Iserted Successfully..");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                total = 0;
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

                    double loyatiPoint = total / 1000;
                    loyaltyPointTextBox.Text = loyatiPoint.ToString();

                    double discount = loyatiPoint / 10;
                    discountTextBox.Text = discount.ToString();

                    double discountAmount = total * discount / 100;
                    discountAmountTextBox.Text = discountAmount.ToString();

                    double payableAmount = total - discountAmount;
                    payableAmountTextBox.Text = payableAmount.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No available data");
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showGridView.Visible = true;
            salesDataGridView.Visible = false;
            List<Sales_Details> sales_Details = _salesManager.DisplaySalesItem();
            showGridView.DataSource = sales_Details;
            SL();
            addButton.Text = "Add";
            //Clear();
            deleteButton.Visible = false;
            return;
        }

        private void showGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (showGridView.CurrentRow.Index != -1)
            {
                //addButton.Text = "Update";
                id = Convert.ToInt32(showGridView.CurrentRow.Cells[1].Value.ToString());
                //customerComboBox.Text = showGridView.CurrentRow.Cells[2].Value.ToString();
                //categoryComboBox.Text = showGridView.CurrentRow.Cells[5].Value.ToString();
                productComboBox.Text = showGridView.CurrentRow.Cells[8].Value.ToString();
                aQuantityTextBox.Text = showGridView.CurrentRow.Cells[9].Value.ToString();
                quantityTextBox.Text = showGridView.CurrentRow.Cells[10].Value.ToString();
                MRPTextBox.Text = showGridView.CurrentRow.Cells[11].Value.ToString();
                totalMRPTextBox.Text = showGridView.CurrentRow.Cells[12].Value.ToString();
            }
        }

        private void searchDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            string searchDate = purchaseDetails.ManufacturedDate = searchDateTimePicker.Value.ToString("mm/dd/yyyy");
            searchTextBox.Text = searchDate;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string criteria = searchTextBox.Text;
            if (criteria == "")
            {
                MessageBox.Show("To searching field is required..");
            }

            List<Sales_Details> searchProducts = _salesManager.SearchProduct(criteria);
            showGridView.DataSource = searchProducts;
            SL();
        }
    }
}
