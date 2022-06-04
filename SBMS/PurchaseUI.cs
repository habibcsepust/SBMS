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
    public partial class PurchaseUI : Form
    {
        PurchaseManager _purchaseManager = new PurchaseManager();
        Purchase purchase = new Purchase();
        Supplier supplier = new Supplier();
        Category category = new Category();
        Product product = new Product();
        PurchaseDetails purchaseDetails = new PurchaseDetails();
        DataTable dataTable = new DataTable();
        Stock stock = new Stock();

        double total = 0;

        string supplierCombo = "";
        string categoryCombo = "";
        string productCombo = "";
        int id;

        public PurchaseUI()
        {
            InitializeComponent();
        }

        private void PurchaseUI_Load(object sender, EventArgs e)
        {
            FalsePurchaseDataGridView();

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

            List<PurchaseDetails> purchaseDetails = _purchaseManager.DisplayPurchaeItem();
            showPurchaseDataGridView.DataSource = purchaseDetails;
            SL();
            EditAction();

            dataTable.Clear();
            dataTable.Columns.Add("Product");
            dataTable.Columns.Add("ManufacturedDate");
            dataTable.Columns.Add("ExpireDate");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("UnitPrice");
            dataTable.Columns.Add("TotalPrice");
            dataTable.Columns.Add("MRP");
            dataTable.Columns.Add("Remarks");
        }

        public bool CheckIfNumeric(string input)
        {
            return input.IsNumeric();
        }


        int i;
        int countRecord;
        private void addButton_Click(object sender, EventArgs e)
        {

            purchase.Date = sDateTimePicker.Text;
            purchase.BillNo = billTextBox.Text;
            purchase.Code = codeTextBox.Text;
            //purchase.ManufacturedDate = manufacturedDateTextBox.Text;
            purchase.ExpireDate = eDateTimePicker2.Value.ToString();
            purchase.Remarks = remarksTextBox.Text;

            if (purchase.Date == "" || purchase.BillNo == "")
            {
                MessageBox.Show("Please Select Supplier Field..");
                return;
            }
            if (!CheckIfNumeric(purchase.BillNo))
            {
                MessageBox.Show("Please enter numeric Invoice Number.");
                billTextBox.Clear();
                return;
            }
            else if (purchase.BillNo.Length < 4)
            {
                MessageBox.Show("Invoice No filed is required minimum 5 digit length");
                billTextBox.Clear();
                return;
            }
            else if (_purchaseManager.IsExistBillNo(billTextBox.Text))
            {
                MessageBox.Show("Invoice No is already exist");
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
            catch (Exception excp)
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
            catch (Exception)
            {
                //MessageBox.Show(excp.Message);
                MessageBox.Show("Please,, Select any Product..");
                return;
            }

            if (aQuantityTextBox.Text == "" || purchase.ManufacturedDate == "" ||
                purchase.ExpireDate == "" || purchase.Remarks == "" || quantityTextBox.Text == "" ||
                unitPriceTextBox.Text == "" || totalPriceTextBox.Text == ""|| MRPTextBox.Text == "")
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

            //if (!CheckIfNumeric(MRPTextBox.Text))
            //{
            //    MessageBox.Show("Please enter numeric MRP.");
            //    codeTextBox.Clear();
            //    return;
            //}

            purchase.SupplierId = Convert.ToInt32(supplierComboBox.SelectedValue.ToString());
            purchase.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue.ToString());
            purchase.ProductId = Convert.ToInt32(productComboBox.SelectedValue.ToString());
            purchase.AvailableQuantity = Convert.ToDouble(aQuantityTextBox.Text);
            purchase.Quantity = Convert.ToDouble(quantityTextBox.Text);
            purchase.UnitPrice = Convert.ToDouble(unitPriceTextBox.Text);
            purchase.TotalPrice = Convert.ToDouble(totalPriceTextBox.Text);
            //purchase.PreviousUnitPrice = Convert.ToDouble(pUnitPriceTextBox.Text);
            //purchase.PreviousMRP = Convert.ToDouble(pMRPTextBox.Text);
            purchase.MRP = Convert.ToDouble(MRPTextBox.Text);


            purchaseDetails.BillNo = billTextBox.Text;
            purchaseDetails.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue.ToString());
            purchaseDetails.ProductId = purchase.ProductId = Convert.ToInt32(productComboBox.SelectedValue.ToString());
            purchaseDetails.Code = codeTextBox.Text;
            purchaseDetails.Category = categoryComboBox.Text;
            purchaseDetails.Product = productComboBox.Text;
            purchaseDetails.ManufacturedDate = menufactureDateTimePicker1.Value.ToString();
            purchaseDetails.ExpireDate = eDateTimePicker2.Value.ToString();
            purchaseDetails.Quantity = Convert.ToDouble(quantityTextBox.Text);
            purchaseDetails.UnitPrice = Convert.ToDouble(unitPriceTextBox.Text);
            purchaseDetails.TotalPrice = Convert.ToDouble(totalPriceTextBox.Text);
            purchaseDetails.MRP = Convert.ToDouble(MRPTextBox.Text);
            purchaseDetails.Remarks = remarksTextBox.Text;

            if (addButton.Text == "Update")
            {
                FalsePurchaseDataGridView();
                TrueShowDataGridView();
                if (_purchaseManager.UpdatePurchaseItem(purchaseDetails, id))
                {
                    MessageBox.Show("Purchase Product Updated Successfully");
                    //Edit();
                    List<PurchaseDetails> purchaseViews = _purchaseManager.DisplayPurchaeItem();
                    showPurchaseDataGridView.DataSource = purchaseViews;
                    SL();
                    addButton.Text = "Save";
                    Clear();
                    return;
                }
                else
                {
                    MessageBox.Show("Purchase Product Not Updated, Check details");
                    return;
                }
            }

            //if (Convert.ToDouble(aQuantityTextBox.Text) < Convert.ToDouble(quantityTextBox.Text))
            //{
            //    MessageBox.Show("Sorry, there is no more available quantity..");
            //    return;
            //}

            if (_purchaseManager.SavePurchaseItem(purchase))
            {
                FalseShowDataGridView();
                TruePurchaseDataGridView();
                MessageBox.Show("Successfully Added ..");
                //List<PurchaseView> purchaseViews = _purchaseManager.DisplayPurchaeItem();
                //purchaseDataGridView.DataSource = purchaseViews;
                //SL();
                //Clear();


                DataRow dr = dataTable.NewRow();
                dr["Product"] = productComboBox.Text;
                dr["ManufacturedDate"] = menufactureDateTimePicker1.Value.ToString();
                dr["ExpireDate"] = eDateTimePicker2.Value.ToString();
                dr["Quantity"] = quantityTextBox.Text;
                dr["UnitPrice"] = unitPriceTextBox.Text;
                dr["TotalPrice"] = totalPriceTextBox.Text;
                dr["MRP"] = MRPTextBox.Text;
                dr["Remarks"] = remarksTextBox.Text;
                dataTable.Rows.Add(dr);
                purchaseDataGridView.DataSource = dataTable;

                total = total + Convert.ToDouble(totalPriceTextBox.Text);
                //totalLabel.Text = total.ToString();

                //for (int i = 0; i < Convert.ToDouble(quantityTextBox.Text); i++)
                //{
                //    _purchaseManager.DeletePurchaseProduct(purchase.ProductId);
                //}
                string productName = productComboBox.Text;
                DataTable dtbl = _purchaseManager.CodeSelect(productName);
                

                foreach (DataRow dataRow in dtbl.Rows)
                {
                    double profit = Convert.ToDouble(MRPTextBox.Text) - Convert.ToDouble(unitPriceTextBox.Text);
                    stock.Code = codeTextBox.Text;
                    stock.Product = productComboBox.Text;
                    stock.Category = categoryComboBox.Text;
                    stock.ManufacturedDate = menufactureDateTimePicker1.Value.ToString();
                    stock.Quantity = Convert.ToDouble(quantityTextBox.Text);
                    stock.UnitPrice = Convert.ToDouble(unitPriceTextBox.Text);
                    stock.MRP = Convert.ToDouble(MRPTextBox.Text);
                    stock.Profit = profit;
                    if (!_purchaseManager.IsStockProductName(productComboBox.Text))
                    {
                        _purchaseManager.AddStock(stock);
                    }
                    else
                    {
                        _purchaseManager.UpdateStock(stock);
                    }
                }
            }
            else
            {
                MessageBox.Show("No purchased,Check purchasing Details..");
            }
        }

        public void SL()
        {
            int i = 1;
            foreach (DataGridViewRow rows in showPurchaseDataGridView.Rows)
            {
                rows.Cells[0].Value = i;
                i++;
            }
        }

        public void Clear()
        {
            //supplierDateTextBox.Text = "";
            billTextBox.Clear();
            supplierComboBox.Text = "";
            categoryComboBox.Text = "";
            productComboBox.Text = "";
            codeTextBox.Clear();
            aQuantityTextBox.Clear();
            //manufacturedDateTextBox.Text = "";
            //expireDateTextBox.Text = "";
            remarksTextBox.Clear();
            quantityTextBox.Clear();
            unitPriceTextBox.Clear();
            totalPriceTextBox.Clear();
            pUnitPriceTextBox.Clear();
            pMRPTextBox.Clear();
            MRPTextBox.Clear();
        }

        private void EditAction()
        {
            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            Editlink.UseColumnTextForLinkValue = true;
            Editlink.HeaderText = "Action";
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            Editlink.Text = "Edit";
            showPurchaseDataGridView.Columns.Add(Editlink);
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            purchase.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue.ToString());

            product.Name = "--Select--";
            List<Product> loadProducts = _purchaseManager.SelectProduct(purchase);
            loadProducts.Insert(0, product);
            productComboBox.DataSource = loadProducts;
        }

        
        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            purchase.ProductId = Convert.ToInt32(productComboBox.SelectedValue.ToString());
            string productName = productComboBox.Text;
            //Random random = new Random();
            //string randNumber = "2019-00" + random.Next(10, 99).ToString();
            //codeTextBox.Text = randNumber;
            

            int productWiseQuantity = _purchaseManager.ProductWiseQuantity(productName);
            aQuantityTextBox.Text = productWiseQuantity.ToString();

            codeTextBox.Text = _purchaseManager.SelectProductCode(productName).ToString();

            purchase.ProductId = Convert.ToInt32(productComboBox.SelectedValue.ToString());
            DataTable dataTable = _purchaseManager.SelectPreviousMRP(purchase.ProductId);

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
                pUnitPriceTextBox.Text = "";
                pMRPTextBox.Text = "";
            }
              
        }

        private void unitPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (quantityTextBox.Text != "")
                {
                    purchase.Quantity = Convert.ToDouble(quantityTextBox.Text);
                    purchase.UnitPrice = Convert.ToDouble(unitPriceTextBox.Text);
                } 
            }
            catch (Exception)

            {
                MessageBox.Show("Please field out this field by numeric value");
            }

            double totalPrice = purchase.Quantity * purchase.UnitPrice;
            totalPriceTextBox.Text = totalPrice.ToString();

            double MRP = purchase.UnitPrice + purchase.UnitPrice * 25 / 100;
            MRPTextBox.Text = MRP.ToString();
        }
        string randNumber;
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

            foreach (DataRow dr in dataTable.Rows)
            {
                if (i == 0)
                {
                    countRecord = _purchaseManager.CountRecord();
                    i++;
                }
                randNumber = "2019-000" + ++countRecord;
                codeTextBox.Text = randNumber;


                purchaseDetails.BillNo = billTextBox.Text;
                purchaseDetails.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue.ToString());
                purchaseDetails.ProductId = Convert.ToInt32(productComboBox.SelectedValue.ToString());
                purchaseDetails.Code = codeTextBox.Text;
                purchaseDetails.Category = categoryComboBox.Text;
                purchaseDetails.Product = dr["Product"].ToString();
                purchaseDetails.ManufacturedDate = menufactureDateTimePicker1.Value.ToString();
                purchaseDetails.ExpireDate = eDateTimePicker2.Value.ToString();
                purchaseDetails.Quantity = Convert.ToDouble(quantityTextBox.Text);
                purchaseDetails.UnitPrice = Convert.ToDouble(unitPriceTextBox.Text);
                purchaseDetails.TotalPrice = Convert.ToDouble(totalPriceTextBox.Text);
                purchaseDetails.MRP = Convert.ToDouble(MRPTextBox.Text);
                purchaseDetails.Remarks = remarksTextBox.Text;

                bool isAddPurchaseItem = _purchaseManager.AddPurchaseItem(purchaseDetails);

                //_purchaseManager.DeleteProduct(productId);
            }

            //product.Name = "--Select--";
            //List<Product> loadProducts = _purchaseManager.LoadProduct();
            //loadProducts.Insert(0, product);
            //productComboBox.DataSource = loadProducts;

            //int countProducts = _purchaseManager.CountProduct(product.Name);
            //aQuantityTextBox.Text = countProducts.ToString();

            dataTable.Clear();
            purchaseDataGridView.DataSource = dataTable;
            MessageBox.Show("Iserted Successfully..");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                total = 0;
                dataTable.Rows.RemoveAt(Convert.ToInt32(purchaseDataGridView.CurrentCell.RowIndex.ToString()));
                int totRows = dataTable.Rows.Count;
                if (totRows == 0)
                {
                    //totalLabel.Text = "0";
                }
                foreach (DataRow dataRow1 in dataTable.Rows)
                {
                    total = total + Convert.ToInt32(dataRow1["TotalPrice"].ToString());
                    //totalLabel.Text = total.ToString();

                    
                }
            }
            catch (Exception)
            {
                //totalLabel.Text = "0";
                MessageBox.Show("No available data");
            }
        }

        private void FalsePurchaseDataGridView()
        {
            purchaseDataGridView.Visible = false;
            submitButton.Visible = false;
            button1.Visible = false; //Delete Button
        }

        private void TruePurchaseDataGridView()
        {
            purchaseDataGridView.Visible = true;
            submitButton.Visible = true;
            button1.Visible = true; //Delete Button
        }

        private void TrueShowDataGridView()
        {
            showPurchaseDataGridView.Visible = true;
            deleteButton.Visible = true;
        }

        private void FalseShowDataGridView()
        {
            showPurchaseDataGridView.Visible = false;
            deleteButton.Visible = false;
        }


        private void showButton_Click(object sender, EventArgs e)
        {
            FalsePurchaseDataGridView();
            TrueShowDataGridView();
            List<PurchaseDetails> purchaseViews = _purchaseManager.DisplayPurchaeItem();
            showPurchaseDataGridView.DataSource = purchaseViews;
            SL();
            addButton.Text = "Add";
            //Clear();
            return;
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void showPurchaseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (showPurchaseDataGridView.CurrentRow.Index != -1)
            {

                FalsePurchaseDataGridView();
                addButton.Text = "Update";
                id = Convert.ToInt32(showPurchaseDataGridView.CurrentRow.Cells[1].Value.ToString());
                billTextBox.Text = showPurchaseDataGridView.CurrentRow.Cells[2].Value.ToString();
                //codeTextBox.Text = showPurchaseDataGridView.CurrentRow.Cells[3].Value.ToString();
                productComboBox.Text = showPurchaseDataGridView.CurrentRow.Cells[6].Value.ToString();
                //mDateTimePicker.Text = showDataGridView.CurrentRow.Cells[7].Value.ToString();
                //eDateTimePicker.Text = showDataGridView.CurrentRow.Cells[8].Value.ToString();
                quantityTextBox.Text = showPurchaseDataGridView.CurrentRow.Cells[9].Value.ToString();
                unitPriceTextBox.Text = showPurchaseDataGridView.CurrentRow.Cells[10].Value.ToString();
                totalPriceTextBox.Text = showPurchaseDataGridView.CurrentRow.Cells[11].Value.ToString();
                MRPTextBox.Text = showPurchaseDataGridView.CurrentRow.Cells[12].Value.ToString();
                remarksTextBox.Text = showPurchaseDataGridView.CurrentRow.Cells[13].Value.ToString();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string criteria = searchTextBox.Text;
            if (criteria == "")
            {
                MessageBox.Show("To searching field is required..");
            }

            List<PurchaseDetails> searchProducts = _purchaseManager.SearchProduct(criteria);
            showPurchaseDataGridView.DataSource = searchProducts;
            SL();
        }

        private void searchDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            string searchDate = purchaseDetails.ManufacturedDate = searchDateTimePicker.Value.ToString();
            searchTextBox.Text = searchDate;
        }

        private void supplierDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
