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
    public class SupplierRepository
    {
        string connectionString = @"Server = HABIB; Database = SmallBusinessManagementSystem;
                Integrated Security = true";

        Supplier supplier = new Supplier();

        public bool AddSupplier(Supplier supplier)
        {
            bool isAdd = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO Supplier(Code, Name, Address, Email,Contact, ContactPerson)" +
                "VALUES('" + supplier.Code + "','" + supplier.Name + "','" + supplier.Address + "','" + supplier.Email + "','" + supplier.Contact + "'," + supplier.ContactPerson + ")";
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

        public bool UpdateSupplier(Supplier supplier, int id)
        {
            bool isUpdate = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "UPDATE Supplier SET Code = '" + supplier.Code + "', Name = '" + supplier.Name + "',Address = '" + supplier.Address + "'," +
                "Email = '" + supplier.Email + "',Contact = '" + supplier.Contact + "',ContactPerson = '" + supplier.ContactPerson + "'" +
                "WHERE Id = " + id + "";
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

        public bool DeleteSupplier(int id)
        {
            bool isDelete = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = "DELETE Supplier WHERE Id = " + id + "";
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

        public List<Supplier> DisplaySupplier()
        {
            List<Supplier> suppliers = new List<Supplier>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT * FROM Supplier";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Supplier supplier = new Supplier();
                supplier.SL = sqlDataReader["SL"].ToString();
                supplier.Id = Convert.ToInt32(sqlDataReader["Id"]);
                supplier.Code = sqlDataReader["Code"].ToString();
                supplier.Name = sqlDataReader["Name"].ToString();
                supplier.Address = sqlDataReader["Address"].ToString();
                supplier.Email = sqlDataReader["Email"].ToString();
                supplier.Contact = sqlDataReader["Contact"].ToString();
                supplier.ContactPerson = sqlDataReader["ContactPerson"].ToString();

                suppliers.Add(supplier);
            }
            sqlConnection.Close();

            return suppliers;
        }

        public bool IsExistCode(Supplier supplier)
        {
            bool IsExistCode = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Code FROM Supplier WHERE Code = '" + supplier.Code + "'";
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

        public bool IsExistContact(Supplier supplier)
        {
            bool IsExistCode = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Contact FROM Supplier WHERE Contact = '" + supplier.Contact + "'";
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

        public bool IsExistContactPerson(Supplier supplier)
        {
            bool IsExistCode = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Contact FROM Supplier WHERE ContactPerson = '" + supplier.ContactPerson + "'";
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

        public bool IsExistEmail(Supplier supplier)
        {
            bool IsExistCode = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Email FROM Supplier WHERE Email = '" + supplier.Email + "'";
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

        public List<Supplier> SearchSupplier(string criteria)
        {
            List<Supplier> suppliers = new List<Supplier>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT * FROM Supplier WHERE Name = '" + criteria + "' OR Contact = '" + criteria + "' OR Email = '" + criteria + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Supplier supplier = new Supplier();
                supplier.SL = sqlDataReader["SL"].ToString();
                supplier.Id = Convert.ToInt32(sqlDataReader["Id"]);
                supplier.Code = sqlDataReader["Code"].ToString();
                supplier.Name = sqlDataReader["Name"].ToString();
                supplier.Address = sqlDataReader["Address"].ToString();
                supplier.Email = sqlDataReader["Email"].ToString();
                supplier.Contact = sqlDataReader["Contact"].ToString();
                supplier.ContactPerson = sqlDataReader["ContactPerson"].ToString();

                suppliers.Add(supplier);
            }
            sqlConnection.Close();

            return suppliers;
        }
    }
}
