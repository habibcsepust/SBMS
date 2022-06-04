using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Model;
using SBMS.ViewModel;

namespace SBMS.Repository
{
    public class ProductRepository
    {
        string connectionString = @"Server = HABIB; Database = SmallBusinessManagementSystem;
                Integrated Security = true";

        public List<Product> LoadProducts()
        {
            List<Product> products = new List<Product>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Id,Name FROM Category";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Product product = new Product();
                product.Id = Convert.ToInt32(sqlDataReader["Id"]);
                product.Name = sqlDataReader["Name"].ToString();

                products.Add(product);
            }
            sqlConnection.Close();

            return products;
        }

        public bool AddProduct(Product product)
        {
            bool isAdd = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO Products(CategoryId,Code, Name,ReorderLevel,Description)" +
                "VALUES("+ product .CategoryId+ ",'" + product.Code + "','" + product.Name + "','"+product.ReorderLevel+"','"+product.Description+"')";
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

        public List<ProductView> DisplayProduct()
        {
            List<ProductView> productViews = new List<ProductView>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT * FROM ProductView";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                ProductView productView = new ProductView();

                productView.Serial = Convert.ToInt32(sqlDataReader["Serial"]);
                productView.Id = Convert.ToInt32(sqlDataReader["Id"]);
                productView.Category = sqlDataReader["Category"].ToString();
                productView.Code = sqlDataReader["Code"].ToString();
                productView.Product = sqlDataReader["Product"].ToString();
                productView.ReorderLevel = sqlDataReader["ReorderLevel"].ToString();
                productView.Description = sqlDataReader["Description"].ToString();

                productViews.Add(productView);
            }
            sqlConnection.Close();

            return productViews;
        }

        public bool IsExistCode(Product product)
        {
            bool IsExistCode = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Code FROM Products WHERE Code = '" + product.Code + "'";
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

        public bool IsExistName(Product product)
        {
            bool IsExistCode = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Name FROM Products WHERE Name = '" + product.Name + "'";
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

        public bool IsUpdateCategory(Product product,string value, int id)
        {
            bool isUpdate = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "UPDATE Products SET CategoryId = " + Convert.ToInt32(value) + ", Code = '"+product.Code+"', " +
                "Name = '" + product.Name + "',ReorderLevel = '"+product.ReorderLevel+ "',Description = '"+product.Description+"'" +
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

        public bool DeleteProduct(int id)
        {
            bool isDelete = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = "DELETE Products WHERE Id = '" + id + "'";
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

        public List<ProductView> SearchProduct(string criteria)
        {
            List<ProductView> productViews = new List<ProductView>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT * FROM ProductView WHERE Category = '" + criteria + "'OR Code = '" + criteria + "' OR Product = '" + criteria + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                ProductView productView = new ProductView();

                productView.Serial = Convert.ToInt32(sqlDataReader["Serial"]);
                productView.Id = Convert.ToInt32(sqlDataReader["Id"]);
                productView.Category = sqlDataReader["Category"].ToString();
                productView.Code = sqlDataReader["Code"].ToString();
                productView.Product = sqlDataReader["Product"].ToString();
                productView.ReorderLevel = sqlDataReader["ReorderLevel"].ToString();
                productView.Description = sqlDataReader["Description"].ToString();

                productViews.Add(productView);
            }
            sqlConnection.Close();

            return productViews;
        }
    }
}
