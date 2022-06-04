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
    public class SalesRepository
    {
        string connectionString = @"Server = HABIB; Database = SmallBusinessManagementSystem;
                Integrated Security = true";

        int rowCount;

        public List<Customer> LoadCustomer()
        {
            List<Customer> customers = new List<Customer>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Id,Name FROM Customers";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Customer customer = new Customer();
                customer.Id = Convert.ToInt32(sqlDataReader["Id"]);
                customer.Name = sqlDataReader["Name"].ToString();

                customers.Add(customer);
            }
            sqlConnection.Close();

            return customers;
        }

        public List<Category> LoadCategory()
        {
            List<Category> categories = new List<Category>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Id,Name FROM Category";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Category category = new Category();
                category.Id = Convert.ToInt32(sqlDataReader["Id"]);
                category.Name = sqlDataReader["Name"].ToString();

                categories.Add(category);
            }
            sqlConnection.Close();

            return categories;
        }

        public List<PurchaseDetails> LoadProduct()
        {
            List<PurchaseDetails> products = new List<PurchaseDetails>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Id,Product FROM PurchaseDetails";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                PurchaseDetails product = new PurchaseDetails();
                product.Id = Convert.ToInt32(sqlDataReader["Id"]);
                product.Product = sqlDataReader["Product"].ToString();

                products.Add(product);
            }
            sqlConnection.Close();

            return products;
        }

        //public bool SaveSalesItem(Sales sales)
        //{
        //    bool isAdd = false;
        //    SqlConnection sqlConnection = new SqlConnection(connectionString);

        //    string query = "INSERT INTO Sales(CustomerId,Date,LoyalityPoint,CategoryId,ProductId,AvailableQuantity,Quantity,MRP,TotalMRP)" +
        //        "VALUES(" + sales.CustomerId + ",'" + sales.Date + "'," + sales.LoyalityPoint + "," +
        //        "" + sales.CategoryId + "," + sales.ProductId + "," + sales.AvailableQuantity + "," +
        //        "" + sales.Quantity + "," + sales.MRP + "," + sales.TotalMRP + ")";

        //    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

        //    sqlConnection.Open();
        //    int isExecute = sqlCommand.ExecuteNonQuery();
        //    if (isExecute > 0)
        //    {
        //        isAdd = true;
        //    }
        //    sqlConnection.Close();
        //    return isAdd;
        //}

        public List<PurchaseDetails> SelectProduct(Sales sales)
        {
            List<PurchaseDetails> products = new List<PurchaseDetails>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Id,Product FROM PurchaseDetails WHERE CategoryId = " + sales.CategoryId + "";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                PurchaseDetails product = new PurchaseDetails();
                product.Id = Convert.ToInt32(sqlDataReader["Id"]);
                product.Product = sqlDataReader["Product"].ToString();

                products.Add(product);
            }
            sqlConnection.Close();

            return products;
        }

        public int CountProduct(string productName)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Quantity FROM Stock WHERE Product = '" + productName + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            int isFill = sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                rowCount = int.Parse(dataTable.Rows[0][0].ToString());
            }
            else
            {
                rowCount = 0;
            }
            return rowCount;
        }

        public bool AddSalesItem(Sales_Details sales_Details,double soldPrice,double profit)
        {
            bool isAdd = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);                                                   
            string commandString = @"INSERT INTO Sales_Details(SL,CustomerId,Date,LoyalityPoint,CategoryId,ProductId,SalesCode,Product,AvailableQuantity,Quantity,MRP,SalePrice,Profit,TotalMRP) 
            VALUES('" + sales_Details .SL+ "'," + sales_Details.CustomerId + ",'" + sales_Details.Date + "'," + sales_Details.LoyalityPoint + ","+ sales_Details.CategoryId + "," + sales_Details.ProductId + "," +
            "'" + sales_Details.SalesCode + "','" + sales_Details.Product + "',"+ sales_Details.AvailableQuantity + "," + sales_Details.Quantity + "," + sales_Details.MRP + ","+ soldPrice + ","+ profit + "," + sales_Details.TotalMRP + ")";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecute = sqlCommand.ExecuteNonQuery();

            if (isExecute > 0)
            {
                isAdd = true;
            }
            sqlConnection.Close();
            return isAdd;
        }

        public bool AddSalesAmount(Sales_Amount sales_Amount)
        {
            bool isAdd = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"INSERT INTO Sales_Amount VALUES(" + sales_Amount.CategoryId + "," + sales_Amount.ProductId + "," +
                "" + sales_Amount.GrandTotal + "," + sales_Amount.Discount + "," + sales_Amount.DiscountAmount + "," +
                "" + sales_Amount.PayableAmount + ")";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecute = sqlCommand.ExecuteNonQuery();

            if (isExecute > 0)
            {
                isAdd = true;
            }
            sqlConnection.Close();
            return isAdd;
        }

        public bool UpdateStockQty(Sales_Details sales_Details)
        {
            bool isUpdate = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"UPDATE Stock SET Quantity = Quantity - " + sales_Details.Quantity + " WHERE Product = '" + sales_Details.Product + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecute = sqlCommand.ExecuteNonQuery();

            if (isExecute > 0)
            {
                isUpdate = true;
            }
            sqlConnection.Close();
            return isUpdate;
        }

        public int CountRecord()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT COUNT(*) FROM Sales_Details";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            int isFill = sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                rowCount = int.Parse(dataTable.Rows[0][0].ToString());
            }
            return rowCount;
        }

        public List<Sales_Details> DisplaySalesItem()
        {
            List<Sales_Details> sales_Details = new List<Sales_Details>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT * FROM Sales_Details";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {

                Sales_Details sales_Detail = new Sales_Details();

                sales_Detail.SL = sqlDataReader["SL"].ToString();
                sales_Detail.Id = Convert.ToInt32(sqlDataReader["Id"]);
                sales_Detail.CustomerId = Convert.ToInt32(sqlDataReader["CustomerId"]);
                sales_Detail.Date = sqlDataReader["Date"].ToString(); 
                sales_Detail.LoyalityPoint = Convert.ToDouble(sqlDataReader["LoyalityPoint"].ToString());
                sales_Detail.CategoryId = Convert.ToInt32(sqlDataReader["CategoryId"]);
                sales_Detail.ProductId = Convert.ToInt32(sqlDataReader["ProductId"]);
                sales_Detail.SalesCode = sqlDataReader["SalesCode"].ToString();
                sales_Detail.Product = sqlDataReader["Product"].ToString();
                sales_Detail.AvailableQuantity = Convert.ToDouble(sqlDataReader["AvailableQuantity"].ToString());
                sales_Detail.Quantity = Convert.ToDouble(sqlDataReader["Quantity"].ToString());
                sales_Detail.MRP = Convert.ToDouble(sqlDataReader["MRP"].ToString());
                sales_Detail.TotalMRP = Convert.ToDouble(sqlDataReader["TotalMRP"].ToString());

                sales_Details.Add(sales_Detail);
            }
            sqlConnection.Close();

            return sales_Details;
        }

        public List<Sales_Details> SearchProduct(string criteria)
        {
            List<Sales_Details> sales_Details = new List<Sales_Details>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT * FROM Sales_Details WHERE Date = '" + criteria + "'OR SalesCode = '" + criteria + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {

                Sales_Details sales_Detail = new Sales_Details();

                sales_Detail.SL = sqlDataReader["SL"].ToString();
                sales_Detail.Id = Convert.ToInt32(sqlDataReader["Id"]);
                sales_Detail.CustomerId = Convert.ToInt32(sqlDataReader["CustomerId"]);
                sales_Detail.Date = sqlDataReader["Date"].ToString();
                sales_Detail.LoyalityPoint = Convert.ToDouble(sqlDataReader["LoyalityPoint"].ToString());
                sales_Detail.CategoryId = Convert.ToInt32(sqlDataReader["CategoryId"]);
                sales_Detail.ProductId = Convert.ToInt32(sqlDataReader["ProductId"]);
                sales_Detail.SalesCode = sqlDataReader["SalesCode"].ToString();
                sales_Detail.Product = sqlDataReader["Product"].ToString();
                sales_Detail.AvailableQuantity = Convert.ToDouble(sqlDataReader["AvailableQuantity"].ToString());
                sales_Detail.Quantity = Convert.ToDouble(sqlDataReader["Quantity"].ToString());
                sales_Detail.MRP = Convert.ToDouble(sqlDataReader["MRP"].ToString());
                sales_Detail.TotalMRP = Convert.ToDouble(sqlDataReader["TotalMRP"].ToString());

                sales_Details.Add(sales_Detail);
            }
            sqlConnection.Close();

            return sales_Details;
        }

        public bool IsStockProductName(string product)
        {
            bool isStock = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT * FROM Sales_Details WHERE Product = '" + product + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            int i = sqlDataAdapter.Fill(dataTable);
            if (i > 0)
            {
                isStock = true;
            }
            sqlConnection.Close();

            return isStock;
        }

        public bool UpdateSalesItem(Sales_Details sales_Details, int id)
        {
            bool isUpdate = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string query = "UPDATE Sales_Details SET  Product = '" + sales_Details.Product + "', " +
                "AvailableQuantity = " + sales_Details.AvailableQuantity + ",Quantity = " + sales_Details.Quantity + "," +
                "MRP = '" + sales_Details.MRP + "',TotalMRP = "+ sales_Details.TotalMRP+ " WHERE Id = " + id + "";
               

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

        public bool UpdateSalesQty(string product, double qty)
        {
            bool isUpdate = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"UPDATE Sales_Details SET Quantity = Quantity + " + qty + " WHERE Product = '" + product + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecute = sqlCommand.ExecuteNonQuery();

            if (isExecute > 0)
            {
                isUpdate = true;
            }
            sqlConnection.Close();
            return isUpdate;
        }

        public DataTable DisplaySalesInfo()
        {
            string connectionString = @"Server = HABIB; Database = SmallBusinessManagementSystem;
                Integrated Security = true";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT SalesCode,Product,Quantity AS SoldQty,MRP AS CP,SalePrice,Profit FROM Sales_Details";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
