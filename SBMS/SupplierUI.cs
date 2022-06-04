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
    public partial class SupplierUI : Form
    {
        SupplierManager _supplierManager = new SupplierManager();
        Supplier supplier = new Supplier();
        int id;

        public SupplierUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            supplier.Code = codeTextBox.Text;
            supplier.Name = nameTextBox.Text;
            supplier.Address = addressTextBox.Text;
            supplier.Email = emailTextBox.Text;
            supplier.Contact = contactTextBox.Text;
            supplier.ContactPerson = contactPersonTextBox.Text;


            if (supplier.Code == "")
            {
                MessageBox.Show("Code Filed is Required");
                codeTextBox.Clear();
                return;
            }
            else if (!CheckIfNumeric(supplier.Code))
            {
                MessageBox.Show("Please enter numeric code.");
                codeTextBox.Clear();
                return;
            }
            else if (supplier.Code.Length != 4)
            {
                MessageBox.Show("Code filed is required 4 digit length");
                codeTextBox.Clear();
                return;
            }
            else if (_supplierManager.IsExistCode(supplier))
            {
                MessageBox.Show("Code is already exist");
                codeTextBox.Clear();
                return;
            }

            if (saveButton.Text == "Update")
            {
                if (_supplierManager.UpdateSupplier(supplier, id))
                {
                    MessageBox.Show("Supplier Updated Successfully");
                    //Edit();
                    List<Supplier> suppliers = _supplierManager.DisplaySupplier();
                    supplierDataGridView.DataSource = suppliers;
                    saveButton.Text = "Save";
                    SL();
                    Clear();
                    return;
                }
                else
                {
                    MessageBox.Show("Supplier Not Updated, Check details");
                    return;
                }
            }


            if (supplier.Name == "")
            {
                MessageBox.Show("Name Filed is Required");
                nameTextBox.Clear();
                return;
            }
            else if (CheckIfNumeric(supplier.Name))
            {
                MessageBox.Show("Required Name in this field.");
                nameTextBox.Clear();
                return;
            }

            if (supplier.Address == "")
            {
                MessageBox.Show("Adress Field is required..");
                addressTextBox.Clear();
                return;
            }

            if (supplier.Email == "")
            {
                MessageBox.Show("Email Field is required..");
                emailTextBox.Clear();
                return;
            }

            string pattern = @"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|" +

                             @"0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z]" +

                             @"[a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$";
            System.Text.RegularExpressions.Match match =
            Regex.Match(emailTextBox.Text, pattern, RegexOptions.IgnoreCase);
            if (!match.Success)
            {
                MessageBox.Show("Ivalid Email. Please Enter Correct email.");
                return;
            }
            else if (_supplierManager.IsExistEmail(supplier))
            {
                MessageBox.Show("Email is already exist");
                emailTextBox.Clear();
                return;
            }

            if (supplier.Contact == "")
            {
                MessageBox.Show("Contact Field is required..");
                contactTextBox.Clear();
                return;
            }
            else if (!CheckIfNumeric(supplier.Contact))
            {
                MessageBox.Show("Please enter numeric Contact.");
                contactPersonTextBox.Clear();
                return;
            }
            else if (supplier.Contact.Length != 11)
            {
                MessageBox.Show("Contact filed is required 11 digit length");
                contactTextBox.Clear();
                return;
            }
            else if (_supplierManager.IsExistContact(supplier))
            {
                MessageBox.Show("Contact number is already exist");
                contactTextBox.Clear();
                return;
            }

            if (contactPersonTextBox.Text == "")
            {
                MessageBox.Show("Contactperson Field is required..");
                contactPersonTextBox.Clear();
                return;
            }
            else if (!CheckIfNumeric(supplier.ContactPerson))
            {
                MessageBox.Show("Please enter numeric Contactperson.");
                contactPersonTextBox.Clear();
                return;
            }
            else if (supplier.ContactPerson.Length != 11)
            {
                MessageBox.Show("Contactperson filed is required 11 digit length");
                contactPersonTextBox.Clear();
                return;
            }
            else if (_supplierManager.IsExistContactPerson(supplier))
            {
                MessageBox.Show("Contactperson number is already exist");
                contactPersonTextBox.Clear();
                return;
            }


            if (_supplierManager.AddSupplier(supplier))
            {
                MessageBox.Show("Customer Added Successfully");
                //Edit();
                List<Supplier> suppliers = _supplierManager.DisplaySupplier();
                supplierDataGridView.DataSource = suppliers;
                //saveButton.Text = "Update";
                SL();
                Clear();
            }
            else
            {
                MessageBox.Show("Customer Not Added");
            }
        }

        public void SL()
        {
            int i = 1;
            foreach (DataGridViewRow rows in supplierDataGridView.Rows)
            {
                rows.Cells[0].Value = i;
                i++;
            }
        }

        private void EditAction()
        {
            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            Editlink.UseColumnTextForLinkValue = true;
            Editlink.HeaderText = "EditAction";
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            Editlink.Text = "Edit";
            supplierDataGridView.Columns.Add(Editlink);
        }

        private void Clear()
        {
            codeTextBox.Clear();
            nameTextBox.Clear();
            addressTextBox.Clear();
            emailTextBox.Clear();
            contactTextBox.Clear();
            contactPersonTextBox.Clear();
        }


        public bool CheckIfNumeric(string input)
        {
            return input.IsNumeric();
        }

        private void SupplierUI_Load(object sender, EventArgs e)
        {
            List<Supplier> suppliers = _supplierManager.DisplaySupplier();
            supplierDataGridView.DataSource = suppliers;
            SL();
            EditAction();
        }

        private void supplierDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (supplierDataGridView.CurrentRow.Index != -1)
            {
                saveButton.Text = "Update";
                id = Convert.ToInt32(supplierDataGridView.CurrentRow.Cells[1].Value.ToString());
                codeTextBox.Text = supplierDataGridView.CurrentRow.Cells[2].Value.ToString();
                nameTextBox.Text = supplierDataGridView.CurrentRow.Cells[3].Value.ToString();
                addressTextBox.Text = supplierDataGridView.CurrentRow.Cells[4].Value.ToString();
                emailTextBox.Text = supplierDataGridView.CurrentRow.Cells[5].Value.ToString();
                contactTextBox.Text = supplierDataGridView.CurrentRow.Cells[6].Value.ToString();
                contactPersonTextBox.Text = supplierDataGridView.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            List<Supplier> suppliers = _supplierManager.DisplaySupplier();
            supplierDataGridView.DataSource = suppliers;
            SL();
            EditAction();
            saveButton.Text = "Save";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (_supplierManager.DeleteSupplier(id))
            {
                MessageBox.Show("Supplier Deleted Successfully");
                //Edit();
                List<Supplier> suppliers = _supplierManager.DisplaySupplier();
                supplierDataGridView.DataSource = suppliers;
                saveButton.Text = "Save";
                SL();
                Clear();
                return;
            }
            else
            {
                MessageBox.Show("Supplier Not Deleted, Check details");
                return;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<Supplier> suppliers = _supplierManager.SearchSupplier(searchTextBox.Text);
            supplierDataGridView.DataSource = suppliers;
            SL();
            Clear();
            EditAction();
        }
    }
}
