using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Model;

namespace SBMS.Repository
{
    public class CustomerRepository
    {
        string connectionString = @"Server = HABIB; Database = SmallBusinessManagementSystem;
                Integrated Security = true";

        Customer customer = new Customer();

        public bool AddCustomer(Customer customer)
        {
            bool isAdd = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO Customers(Code, Name, Address, Email,Contact, LoyaltyPoint)" +
                "VALUES('" + customer.Code + "','" + customer.Name + "','"+customer.Address+"','"+customer.Email+"','"+customer.Contact+"',"+customer.LoyaltyPoint+")";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlConnection.Open();
            int isExecute = sqlCommand.ExecuteNonQuery();
            if (isExecute > 0)
            {
                isAdd = true;
            }
            sqlConnection.Close();
            return isAdd;
        }

        public bool UpdateCustomer(Customer customer, string loyalty, int id)
        {
            bool isUpdate = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "UPDATE Customers SET Code = '" + customer.Code + "', Name = '" + customer.Name + "',Address = '"+customer.Address+"'," +
                "Email = '"+customer.Email+"',Contact = '"+customer.Contact+ "',LoyaltyPoint = " + Convert.ToDouble(loyalty)+"" +
                "WHERE Id = "+id+"";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlConnection.Open();
            int isExecute = sqlCommand.ExecuteNonQuery();
            if (isExecute > 0)
            {
                isUpdate = true;
            }
            sqlConnection.Close();
            return isUpdate;
        }

        public bool DeleteCustomer(int id)
        {
            bool isDelete = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = "DELETE Customers WHERE Id = " + id + "";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecute = sqlCommand.ExecuteNonQuery();

            if (isExecute > 0)
            {
                isDelete = true;
            }
            sqlConnection.Close();
            return isDelete;
        }

        public List<Customer> DisplayCustomer()
        {
            List<Customer> customers = new List<Customer>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT * FROM Customers";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Customer customer = new Customer();
                customer.SL = sqlDataReader["SL"].ToString();
                customer.Id = Convert.ToInt32(sqlDataReader["Id"]);
                customer.Code = sqlDataReader["Code"].ToString();
                customer.Name = sqlDataReader["Name"].ToString();
                customer.Address = sqlDataReader["Address"].ToString();
                customer.Email = sqlDataReader["Email"].ToString();
                customer.Contact = sqlDataReader["Contact"].ToString();
                customer.LoyaltyPoint = Convert.ToDouble(sqlDataReader["LoyaltyPoint"]);

                customers.Add(customer);
            }
            sqlConnection.Close();

            return customers;
        }

        public bool IsExistCode(Customer customer)
        {
            bool IsExistCode = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Code FROM Customers WHERE Code = '" + customer.Code + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            int isFill = sqlDataAdapter.Fill(dataTable);

            if (isFill > 0)
            {
                IsExistCode = true;
            }
            return IsExistCode;
        }

        public bool IsExistContact(Customer customer)
        {
            bool IsExistCode = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Contact FROM Customers WHERE Contact = '" + customer.Contact + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            int isFill = sqlDataAdapter.Fill(dataTable);

            if (isFill > 0)
            {
                IsExistCode = true;
            }
            return IsExistCode;
        }

        public bool IsExistEmail(Customer customer)
        {
            bool IsExistCode = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Email FROM Customers WHERE Email = '" + customer.Email + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            int isFill = sqlDataAdapter.Fill(dataTable);

            if (isFill > 0)
            {
                IsExistCode = true;
            }
            return IsExistCode;
        }

        public List<Customer> SearchCustomer(string criteria)
        {
            List<Customer> customers = new List<Customer>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT * FROM Customers WHERE Name = '" + criteria + "' OR Contact = '" + criteria + "' OR Email = '"+criteria+"'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Customer customer = new Customer();
                customer.SL = sqlDataReader["SL"].ToString();
                customer.Id = Convert.ToInt32(sqlDataReader["Id"]);
                customer.Code = sqlDataReader["Code"].ToString();
                customer.Name = sqlDataReader["Name"].ToString();
                customer.Address = sqlDataReader["Address"].ToString();
                customer.Email = sqlDataReader["Email"].ToString();
                customer.Contact = sqlDataReader["Contact"].ToString();
                customer.LoyaltyPoint = Convert.ToDouble(sqlDataReader["LoyaltyPoint"]);

                customers.Add(customer);
            }
            sqlConnection.Close();

            return customers;
        }

    }
}
