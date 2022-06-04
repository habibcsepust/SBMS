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
    public class PurchaseModuleRepository
    {
        int rowCount = 0;
        DBConnection dBConnection = new DBConnection();
        
        public List<Supplier> LoadSupplier()
        {
            string connectionString = dBConnection.ConnectionString;
            List<Supplier> suppliers = new List<Supplier>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Id,Name FROM Supplier";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Supplier supplier = new Supplier();
                supplier.Id = Convert.ToInt32(sqlDataReader["Id"]);
                supplier.Name = sqlDataReader["Name"].ToString();

                suppliers.Add(supplier);
            }
            sqlConnection.Close();

            return suppliers;
        }

        public List<Category> LoadCategory()
        {
            string connectionString = dBConnection.ConnectionString;
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

        public List<Product> LoadProduct()
        {
            string connectionString = dBConnection.ConnectionString;
            List<Product> products = new List<Product>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Id,Name FROM Products";
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

        public List<Product> SelectProduct(int categoryId)
        {
            string connectionString = dBConnection.ConnectionString;
            List<Product> products = new List<Product>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Id,Name FROM Products WHERE CategoryId = " + categoryId + "";
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

        int productQty = 0;
        public int ProductWiseQuantity(int productId)
        {
            string connectionString = dBConnection.ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT AvailableQuantity FROM SupplierPurchaseDetails WHERE ProductId = " + productId + "";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            int isFill = sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                productQty = int.Parse(dataTable.Rows[0][0].ToString());
            }
            else
            {
                productQty = 0;
            }
            return productQty;
        }

        public int SelectProductCode(int productId)
        {
            string connectionString = dBConnection.ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Code FROM Products WHERE Id = '" + productId + "'";
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

        public DataTable SelectPreviousMRP(int productId)
        {
            string connectionString = dBConnection.ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT TOP 1 UnitPrice FROM SupplierPurchaseDetails WHERE ProductId = " + productId + "";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public bool SaveSupplierPurchase(SupplierPurchase supplierPurchase)
        {
            string connectionString = dBConnection.ConnectionString;
            bool isAdd = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"INSERT INTO SupplierPurchase(Date,BillNo,SupplierId) VALUES('" + supplierPurchase.Date + "','" + supplierPurchase.BillNo + "'," +
                "" + supplierPurchase.SupplierId + ")";
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

        int purchaseMaxId;
        public int MaxIdOfPurchase()
        {
            string connectionString = dBConnection.ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT MAX(Id) FROM SupplierPurchase ";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            int isFill = sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                purchaseMaxId = int.Parse(dataTable.Rows[0][0].ToString());
            }
            else
            {
                purchaseMaxId = 0;
            }
            return purchaseMaxId;
        }

        public int CountRecord()
        {
            string connectionString = dBConnection.ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT COUNT(*) FROM SupplierPurchaseDetails";
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

        public bool AddPurchaseItem(SupplierPurchaseDetails purchaseDetails)
        {
        string connectionString = dBConnection.ConnectionString;
            bool isAdd = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"INSERT INTO SupplierPurchaseDetails(SupplierPurchaseId,CategoryId,ProductId,Product,PurchaseCode,Code,
           AvailableQuantity,ManufacturedDate,ExpireDate,Remarks,Quantity,UnitPrice,TotalPrice,PreviousUnitPrice,
           PreviousMRP,MRP) VALUES(" + purchaseDetails.SupplierPurchaseId + "," + purchaseDetails.CategoryId + "," + purchaseDetails.ProductId + ",'"+purchaseDetails.Product+"'," +
                "'" + purchaseDetails.PurchaseCode + "','" + purchaseDetails.Code + "'," + purchaseDetails.AvailableQuantity + purchaseDetails.Quantity + ",'" + purchaseDetails.ManufacturedDate + "','" + purchaseDetails.ExpireDate + "'," +
                "'" + purchaseDetails.Remarks + "'," + purchaseDetails.Quantity + "," + purchaseDetails.UnitPrice + "," +
                "" + purchaseDetails.TotalPrice + "," + purchaseDetails.PreviousUnitPrice + "," + purchaseDetails.PreviousMRP + "," + purchaseDetails.MRP + ")";
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

        public bool IsPurchaseProductName(int productId)
        {
            string connectionString = dBConnection.ConnectionString;
            bool isStock = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT * FROM SupplierPurchaseDetails WHERE ProductId = '" + productId + "'";
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

        public bool UpdatePurchaseProductQty(SupplierPurchaseDetails purchaseDetails)
        {
            string connectionString = dBConnection.ConnectionString;
            bool isUpdate = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = @"UPDATE SupplierPurchaseDetails SET AvailableQuantity = AvailableQuantity + " + purchaseDetails.Quantity + "," +
            "UnitPrice = "+ purchaseDetails .UnitPrice+ ",PreviousUnitPrice = "+ purchaseDetails.PreviousUnitPrice+ ",PreviousMRP = "+ purchaseDetails.PreviousMRP+ "," +
            "MRP = " + purchaseDetails .MRP+ " WHERE ProductId = '" + purchaseDetails.ProductId + "'";
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

        public bool AddStock(SupplierPurchaseDetails purchaseDetails)
        {
            string connectionString = dBConnection.ConnectionString;
            bool isAdd = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"INSERT INTO StockIn(SupplierPurchaseId,Category,Product,Quantity,PurchaseCode) VALUES(" + purchaseDetails.SupplierPurchaseId + ",'" + purchaseDetails.Category + "','" + purchaseDetails.Product + "'," +
                ""+purchaseDetails.Quantity+",'" + purchaseDetails.PurchaseCode + "')";
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
    }
}
