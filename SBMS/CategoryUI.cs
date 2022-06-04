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
using System.Text.RegularExpressions;

namespace SBMS
{
    public partial class CategoryUI : Form
    {
        CategoryManager _categoryManager = new CategoryManager();
        Category category = new Category();
        int id;

        public CategoryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            category.Code = codeTextBox.Text;
            category.Name = nameTextBox.Text;

            

            if (category.Code == "")
            {
                MessageBox.Show("Code Filed is Required");
                codeTextBox.Clear();
                return;
            }
            else if (!CheckIfNumeric(category.Code))
            {
                MessageBox.Show("Please enter numeric code.");
                codeTextBox.Clear();
                return;
            }
            else if (category.Code.Length != 4)
            {
                MessageBox.Show("Code filed is required 4 digit length");
                codeTextBox.Clear();
                return;
            }
            if (_categoryManager.IsCodeExist(category))
            {
                MessageBox.Show("Please Enter Unique Code..");
                return;
            }
            //else if (_categoryManager.IsExistCode(category))
            //{
            //    MessageBox.Show("Code is already exist");
            //    codeTextBox.Clear();
            //    return;
            //}

            if (saveButton.Text == "Update")
            {
                
                if (_categoryManager.IsUpdateCategory(category,id))
                {
                    MessageBox.Show("Category Updated Successfully");
                    //Edit();
                    List<Category> categories = _categoryManager.DisplayCategory();
                    categoryDataGridView.DataSource = categories;
                    saveButton.Text = "Save";
                    SL();
                    Clear();
                    return;
                }
                else
                {
                    MessageBox.Show("Category Not Updated, Check details");
                    return;
                }
            }

            if (category.Name == "")
            {
                MessageBox.Show("Name Filed is Required");
                return;
            }
            else if (CheckIfNumeric(category.Name))
            {
                MessageBox.Show("Required Name in this field.");
                nameTextBox.Clear();
                return;
            }
            else if (_categoryManager.IsExistName(category))
            {
                MessageBox.Show("Name is already exist");
                nameTextBox.Clear();
                return;
            }

            if (_categoryManager.IsAddCategory(category))
            {
                MessageBox.Show("Category Added Successfully");
                //Edit();
                List<Category> categories = _categoryManager.DisplayCategory();
                categoryDataGridView.DataSource = categories;
                //saveButton.Text = "Update";
                SL();
                Clear();
            }
            else
            {
                MessageBox.Show("Category Not Added");
            }
        }

        private void Clear()
        {
            codeTextBox.Clear();
            nameTextBox.Clear();
        }

        public bool CheckIfNumeric(string input)
        {
            return input.IsNumeric();
        }

        private void CategoryUI_Load(object sender, EventArgs e)
        {
            Edit();
            List<Category> categories = _categoryManager.DisplayCategory();
            categoryDataGridView.DataSource = categories;
            SL();
        }

        public void SL()
        {
            int i = 1;
            foreach (DataGridViewRow rows in categoryDataGridView.Rows)
            {
                rows.Cells[0].Value = i;
                i++;
            }
        }

        private void Edit()
        {
            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            Editlink.UseColumnTextForLinkValue = true;
            Editlink.HeaderText = "Action";
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            Editlink.Text = "Edit";
            categoryDataGridView.Columns.Add(Editlink);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string criteria = searchTextBox.Text;
            if (criteria == "")
            {
                MessageBox.Show("To searching field is required..");
            }

            //Edit();
            List<Category> categories = _categoryManager.SearchCategory(criteria);
            categoryDataGridView.DataSource = categories;
            SL();
        }

        //private void deleteButton_Click(object sender, EventArgs e)
        //{
        //    category.Code = codeTextBox.Text;
        //    category.Name = nameTextBox.Text;
        //    if (_categoryManager.DeleteCategory(category))
        //    {
        //        MessageBox.Show("Category Deleted Successfully..");
        //        Clear();
        //        List<Category> categories = _categoryManager.DisplayCategory();
        //        categoryDataGridView.DataSource = categories;
        //        SL();
        //        saveButton.Text = "Save";
        //    }
        //    else
        //    {
        //        MessageBox.Show("Category Not Deleted..");
        //    }
        //}

        private void categoryDataGridView_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (categoryDataGridView.CurrentRow.Index != -1)
            {
                saveButton.Text = "Update";
                id = Convert.ToInt32(categoryDataGridView.CurrentRow.Cells[1].Value.ToString());
                codeTextBox.Text = categoryDataGridView.CurrentRow.Cells[2].Value.ToString();
                nameTextBox.Text = categoryDataGridView.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            List<Category> categories = _categoryManager.DisplayCategory();
            categoryDataGridView.DataSource = categories;
            SL();
            saveButton.Text = "Save";
        }
    }


    public static class StringExtensions
    {
        public static bool IsNumeric(this string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }
    }
}
