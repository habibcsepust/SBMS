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
using System.Text.RegularExpressions;

namespace SBMS
{
    public partial class ProductUI : Form
    {
        ProdcutManager _prodcutManager = new ProdcutManager();
        Product product = new Product();
        int id;

        public ProductUI()
        {
            InitializeComponent();
        }

        private void Edit()
        {
            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            Editlink.UseColumnTextForLinkValue = true;
            Editlink.HeaderText = "Action";
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            Editlink.Text = "Edit";
            showDataGridView.Columns.Add(Editlink);
        }

        private void ProductUI_Load(object sender, EventArgs e)
        {
            product.Name = "--Select--";
            List<Product> loadProducts = _prodcutManager.LoadProducts();
            loadProducts.Insert(0,product);
            categoryComboBox.DataSource = loadProducts;

            List<ProductView> productViews = _prodcutManager.DisplayProduct();
            showDataGridView.DataSource = productViews;
            SL();
            Edit();

            string ROL = product.ReorderLevel;
            reorderTextBox.Text = ROL;
        }

        string categoryCombo = "";
        private void saveButton_Click(object sender, EventArgs e)
        {
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
            product.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
            product.Code = codeTextBox.Text;
            product.Name = nameTextBox.Text;
            if (codeTextBox.Text == "")
            {
                MessageBox.Show("Rquired code field.. ");
                return;
            }

            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Name field is required.. ");
                return;
            }

            if (descriptionTextBox.Text == "")
            {
                MessageBox.Show("Description field is required.... ");
                return;
            }
            if (Convert.ToDouble(reorderTextBox.Text)<0)
            {
                MessageBox.Show("Enter Positive ReorderLevel Number");
                reorderTextBox.Clear();
                return;
            }
            product.ReorderLevel = reorderTextBox.Text;
            product.Description = descriptionTextBox.Text;

            string value = "";
            try
            {
                value = categoryComboBox.SelectedValue.ToString();

                if (Convert.ToInt32(value) <= 0)
                {
                    MessageBox.Show("Please,, Select any categoory..");
                    return;
                }
            }
            catch (Exception excp)
            {
                //MessageBox.Show(excp.Message);
                MessageBox.Show("Please,, Select any categoory..");
                return;
            }


            if (product.Code == "")
            {
                MessageBox.Show("Code Filed is Required");
                codeTextBox.Clear();
                return;
            }
            else if (!CheckIfNumeric(product.Code))
            {
                MessageBox.Show("Please enter numeric code.");
                codeTextBox.Clear();
                return;
            }
            else if (product.Code.Length != 4)
            {
                MessageBox.Show("Code filed is required 4 digit length");
                codeTextBox.Clear();
                return;
            }
            else if (_prodcutManager.IsExistCode(product))
            {
                MessageBox.Show("Code is already exist");
                codeTextBox.Clear();
                return;
            }


            if (saveButton.Text == "Update")
            {
                if (_prodcutManager.IsExistCode(product))
                {
                    MessageBox.Show("Code is already exist");
                    codeTextBox.Clear();
                    return;
                }
                if (_prodcutManager.IsUpdateCategory(product, value, id))
                {
                    MessageBox.Show("Product Updated Successfully");
                    //Edit();
                    List<ProductView> productViews = _prodcutManager.DisplayProduct();
                    showDataGridView.DataSource = productViews;
                    saveButton.Text = "Save";
                    SL();
                    Clear();
                    return;
                }
                else
                {
                    MessageBox.Show("Product Not Updated, Check details");
                    return;
                }
            }

            if (product.Name == "")
            {
                MessageBox.Show("Name Filed is Required");
                return;
            }
            else if (CheckIfNumeric(product.Name))
            {
                MessageBox.Show("Required Name in this field.");
                nameTextBox.Clear();
                return;
            }

            if (_prodcutManager.AddProduct(product))
            {
                MessageBox.Show("Product added Successfully..");
                List<ProductView> productViews = _prodcutManager.DisplayProduct();
                showDataGridView.DataSource = productViews;
                SL();
                Clear();
            }
            else
            {
                MessageBox.Show("No Addedd,Check Inserting Details..");
            }
        }

        public bool CheckIfNumeric(string input)
        {
            return input.IsNumeric();
        }

        private void Clear()
        {
            categoryComboBox.Text = "";
            codeTextBox.Clear();
            nameTextBox.Clear();
            reorderTextBox.Clear();
            descriptionTextBox.Clear();
        }


        public void SL()
        {
            int i = 1;
            foreach (DataGridViewRow rows in showDataGridView.Rows)
            {
                rows.Cells[0].Value = i;
                i++;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (_prodcutManager.DeleteProduct(id))
            {
                MessageBox.Show("Product Deleted Successfully..");
                Clear();
                List<ProductView> productViews = _prodcutManager.DisplayProduct();
                showDataGridView.DataSource = productViews;
                SL();
                saveButton.Text = "Save";
            }
            else
            {
                MessageBox.Show("Product Not Deleted..");
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            List<ProductView> productViews = _prodcutManager.DisplayProduct();
            showDataGridView.DataSource = productViews;
            SL();
            saveButton.Text = "Save";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string criteria = searchTextBox.Text;
            if (criteria == "")
            {
                MessageBox.Show("To searching field is required..");
            }

            List<ProductView> searchProducts = _prodcutManager.SearchProduct(criteria);
            showDataGridView.DataSource = searchProducts;
            SL();
        }

        private void productDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (showDataGridView.CurrentRow.Index != -1)
            {
                saveButton.Text = "Update";
                id = Convert.ToInt32(showDataGridView.CurrentRow.Cells[1].Value.ToString());
                categoryComboBox.Text = showDataGridView.CurrentRow.Cells[2].Value.ToString();
                codeTextBox.Text = showDataGridView.CurrentRow.Cells[3].Value.ToString();
                nameTextBox.Text = showDataGridView.CurrentRow.Cells[4].Value.ToString();
                reorderTextBox.Text = showDataGridView.CurrentRow.Cells[5].Value.ToString();
                descriptionTextBox.Text = showDataGridView.CurrentRow.Cells[6].Value.ToString();
            }
        }
    }
}

public static class StringExtensions
{
    public static bool IsNumeric(this string input)
    {
        return Regex.IsMatch(input, @"^\d+$");
    }
}
