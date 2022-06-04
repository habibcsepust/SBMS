using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBMS.BLL;
using SBMS.Model;

namespace SBMS
{
    public partial class CustomerUI : Form
    {
        CustomerManager _customerManager = new CustomerManager();
        Customer customer = new Customer();
        int id;

        public CustomerUI()
        {
            InitializeComponent();
        }

        public bool CheckIfNumeric(string input)
        {
            return input.IsNumeric();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            customer.Code = codeTextBox.Text;
            customer.Name = nameTextBox.Text;
            customer.Address = addressTextBox.Text;
            customer.Email = emailTextBox.Text;
            customer.Contact = contactTextBox.Text;
            if (Convert.ToDouble(loyaltyPointTextBox.Text)<0)
            {
                MessageBox.Show("Please Enter positive Loyality Point");
                loyaltyPointTextBox.Clear();
                return;
            }
            string loyalty = loyaltyPointTextBox.Text;

            

            if (customer.Code == "")
            {
                MessageBox.Show("Code Filed is Required");
                codeTextBox.Clear();
                return;
            }
            else if (!CheckIfNumeric(customer.Code))
            {
                MessageBox.Show("Please enter numeric code.");
                codeTextBox.Clear();
                return;
            }
            else if (customer.Code.Length != 4)
            {
                MessageBox.Show("Code filed is required 4 digit length");
                codeTextBox.Clear();
                return;
            }
            else if (_customerManager.IsExistCode(customer))
            {
                MessageBox.Show("Code is already exist");
                codeTextBox.Clear();
                return;
            }

            if (saveButton.Text == "Update")
            {
                if (_customerManager.UpdateCustomer(customer, loyalty, id))
                {
                    MessageBox.Show("Customer Updated Successfully");
                    //Edit();
                    List<Customer> customers = _customerManager.DisplayCustomer();
                    customerDataGridView.DataSource = customers;
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


            if (customer.Name == "")
            {
                MessageBox.Show("Name Filed is Required");
                nameTextBox.Clear();
                return;
            }
            else if (CheckIfNumeric(customer.Name))
            {
                MessageBox.Show("Required Name in this field.");
                nameTextBox.Clear();
                return;
            }
            

            if (customer.Address == "")
            {
                MessageBox.Show("Adress Field is required..");
                addressTextBox.Clear();
                return;
            }

            if (customer.Email == "")
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
            else if (_customerManager.IsExistEmail(customer))
            {
                MessageBox.Show("Email is already exist");
                contactTextBox.Clear();
                return;
            }


            if (customer.Contact == "")
            {
                MessageBox.Show("Contact Field is required..");
                contactTextBox.Clear();
                return;
            }
            else if (!CheckIfNumeric(customer.Contact))
            {
                MessageBox.Show("Please enter numeric Contact.");
                loyaltyPointTextBox.Clear();
                return;
            }
            else if (customer.Contact.Length != 11)
            {
                MessageBox.Show("Contact filed is required 11 digit length");
                contactTextBox.Clear();
                return;
            }
            else if (_customerManager.IsExistContact(customer))
            {
                MessageBox.Show("Contact number is already exist");
                contactTextBox.Clear();
                return;
            }


            if (loyaltyPointTextBox.Text == "")
            {
                MessageBox.Show("LoyaltyPoint Field is required..");
                loyaltyPointTextBox.Clear();
                return;
            }
            else if (!CheckIfNumeric(loyaltyPointTextBox.Text))
            {
                MessageBox.Show("Please enter numeric LoyaltyPoint.");
                loyaltyPointTextBox.Clear();
                return;
            }

            customer.LoyaltyPoint = Convert.ToDouble(loyaltyPointTextBox.Text);


            if (_customerManager.AddCustomer(customer))
            {
                MessageBox.Show("Customer Added Successfully");
                //Edit();
                List<Customer> customers = _customerManager.DisplayCustomer();
                customerDataGridView.DataSource = customers;
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
            foreach (DataGridViewRow rows in customerDataGridView.Rows)
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
            customerDataGridView.Columns.Add(Editlink);
        }


        private void Clear()
        {
            codeTextBox.Clear();
            nameTextBox.Clear();
            addressTextBox.Clear();
            emailTextBox.Clear();
            contactTextBox.Clear();
            loyaltyPointTextBox.Clear();
        }

        private void CustomerUI_Load(object sender, EventArgs e)
        {
            loyaltyPointTextBox.Text = customer.LoyaltyPoint.ToString();

            List<Customer> customers = _customerManager.DisplayCustomer();
            customerDataGridView.DataSource = customers;
            SL();
            EditAction();
        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (customerDataGridView.CurrentRow.Index != -1)
            {
                saveButton.Text = "Update";
                id = Convert.ToInt32(customerDataGridView.CurrentRow.Cells[1].Value.ToString());
                codeTextBox.Text = customerDataGridView.CurrentRow.Cells[2].Value.ToString();
                nameTextBox.Text = customerDataGridView.CurrentRow.Cells[3].Value.ToString();
                addressTextBox.Text = customerDataGridView.CurrentRow.Cells[4].Value.ToString();
                emailTextBox.Text = customerDataGridView.CurrentRow.Cells[5].Value.ToString();
                contactTextBox.Text = customerDataGridView.CurrentRow.Cells[6].Value.ToString();
                loyaltyPointTextBox.Text = customerDataGridView.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (_customerManager.DeleteCustomer(id))
            {
                MessageBox.Show("Customer Deleted Successfully");
                //Edit();
                List<Customer> customers = _customerManager.DisplayCustomer();
                customerDataGridView.DataSource = customers;
                saveButton.Text = "Save";
                SL();
                Clear();
                return;
            }
            else
            {
                MessageBox.Show("Customer Not Delete, Check details");
                return;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<Customer> customers = _customerManager.SearchCustomer(searchTextBox.Text);
            customerDataGridView.DataSource = customers;
            SL();
            Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            saveButton.Text = "Save";
            List<Customer> customers = _customerManager.DisplayCustomer();
            customerDataGridView.DataSource = customers;
            SL();
            Clear();
        }

        private void loyaltyPointTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
