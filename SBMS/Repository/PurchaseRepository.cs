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
    public class PurchaseRepository
    {
        string connectionString = @"Server = HABIB; Database = SmallBusinessManagementSystem;
                Integrated Security = true";

        int rowCount;

        Purchase purchase = new Purchase();

        public List<Supplier> LoadSupplier()
        {
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

        public List<Product> SelectProduct(Purchase purchase)
        {
            List<Product> products = new List<Product>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Id,Name FROM Products WHERE CategoryId = "+purchase.CategoryId+"";
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
        public int ProductWiseQuantity(string productName)
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
                productQty = int.Parse(dataTable.Rows[0][0].ToString());
            }
            return productQty;
        }

        public int SelectProductCode(string productName)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Code FROM Products WHERE Name = '" + productName + "'";
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

        public bool SavePurchaseItem(Purchase purchase)
        {
            bool isAdd = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string query = "INSERT INTO Purchase(Date,BillNo,SupplierId,CategoryId,ProductId,Code," +
                "AvailableQuantity,ManufacturedDate,ExpireDate,Remarks,Quantity,UnitPrice,TotalPrice," +
                "PreviousUnitPrice,PreviousMRP,MRP)" +
                "VALUES('" + purchase.Date + "','" + purchase.BillNo + "'," + purchase.SupplierId + "," +
                "" + purchase.CategoryId + "," + purchase.ProductId + ",'"+purchase.Code+"',"+purchase.AvailableQuantity + "," +
                "'"+purchase.ManufacturedDate+"','"+purchase.ExpireDate+"','"+purchase.Remarks + "'," +
                ""+purchase.Quantity+","+purchase.UnitPrice+","+purchase.TotalPrice+","+purchase.PreviousUnitPrice+","+purchase.PreviousMRP+","+purchase.MRP+")";

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

        public List<PurchaseDetails> DisplayPurchaeItem()
        {
            List<PurchaseDetails> purchaseDetails = new List<PurchaseDetails>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT * FROM PurchaseDetails";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {

                PurchaseDetails purchaseDetail = new PurchaseDetails();

                purchaseDetail.SL = sqlDataReader["SL"].ToString();
                purchaseDetail.Id = Convert.ToInt32(sqlDataReader["Id"]);
                purchaseDetail.BillNo = sqlDataReader["BillNo"].ToString();
                purchaseDetail.CategoryId = Convert.ToInt32(sqlDataReader["CategoryId"]);
                purchaseDetail.ProductId = Convert.ToInt32(sqlDataReader["ProductId"]);
                purchaseDetail.Code = sqlDataReader["Code"].ToString();
                purchaseDetail.Category = sqlDataReader["Category"].ToString();
                purchaseDetail.Product = sqlDataReader["Product"].ToString();
                purchaseDetail.ManufacturedDate = sqlDataReader["ManufacturedDate"].ToString();
                purchaseDetail.ExpireDate = sqlDataReader["ExpireDate"].ToString();
                purchaseDetail.Quantity = Convert.ToDouble(sqlDataReader["Quantity"].ToString());
                purchaseDetail.UnitPrice = Convert.ToDouble(sqlDataReader["UnitPrice"].ToString());
                purchaseDetail.TotalPrice = Convert.ToDouble(sqlDataReader["TotalPrice"].ToString());
                purchaseDetail.MRP = Convert.ToDouble(sqlDataReader["MRP"].ToString());
                purchaseDetail.Remarks = sqlDataReader["Remarks"].ToString();

                purchaseDetails.Add(purchaseDetail);
            }
            sqlConnection.Close();

            return purchaseDetails;
        }

        public bool UpdatePurchaseItem(PurchaseDetails purchaseDetails, int id)
        {
            bool isUpdate = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "UPDATE PurchaseDetails SET  BillNo = '" + purchaseDetails.BillNo + "', " +
                "CategoryId = " + purchaseDetails.CategoryId + ",ProductId = " + purchaseDetails.ProductId + ",Code = '" + purchaseDetails.Code + "', " +
                "Product = '" + purchaseDetails.Product + "',ManufacturedDate = '" + purchaseDetails.ManufacturedDate + "'," +
                "ExpireDate = '" + purchaseDetails.ExpireDate + "',Quantity = " + purchaseDetails.Quantity + "," +
                "UnitPrice = " + purchaseDetails.UnitPrice + ",TotalPrice = " + purchaseDetails.TotalPrice + "," +
                "MRP = " + purchaseDetails.MRP + ",Remarks = '" + purchaseDetails.Remarks + "' WHERE Id = " + id + "";

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

        public bool AddPurchaseItem(PurchaseDetails purchaseDetails)
        {
            bool isAdd = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"INSERT INTO PurchaseDetails VALUES('"+ purchaseDetails .SL+ "','" + purchaseDetails.BillNo + "'," + purchaseDetails.CategoryId + "," +
                ""+ purchaseDetails.ProductId + ",'"+ purchaseDetails .Code+ "','"+ purchaseDetails .Category+ "','" + purchaseDetails.Product + "','" + purchaseDetails.ManufacturedDate.ToString() + "'," +
                "'" + purchaseDetails.ExpireDate.ToString() + "'," + purchaseDetails.Quantity + "," + purchaseDetails.UnitPrice + "," +
                ""+purchaseDetails.TotalPrice + ","+purchaseDetails.MRP + ",'"+purchaseDetails.Remarks+"')";
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

        public bool IsStockProductName(string product)
        {
            bool isStock = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT * FROM Stock WHERE Product = '" + product + "'";
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

        public bool AddStock(Stock stock)
        {
            bool isAdd = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"INSERT INTO Stock(Code,Product,Category,ManufacturedDate,Quantity,UnitPrice,MRP,Profit) VALUES('" + stock.Code + "','" + stock.Product + "'," +
                "'" + stock.Category + "','"+stock.ManufacturedDate+"',"+stock.Quantity+","+stock.UnitPrice+","+stock.MRP+","+ stock.Profit + ")";
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

        public bool UpdateStock(Stock stock)
        {
            bool isUpdate = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"UPDATE Stock SET Code = '"+ stock .Code+ "', Quantity = Quantity + " + stock.Quantity + ",UnitPrice = "+stock.UnitPrice+"" +
                ",MRP = "+stock.MRP+ ",Profit = "+stock.Profit+" WHERE Product = '" + stock.Product + "'";
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

        public bool IsExistBillNo(string invoiceNo)
        {
            bool IsExistCode = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT BillNo FROM Purchase WHERE BillNo = '" + invoiceNo + "'";
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

        public DataTable SelectPreviousMRP(int productId)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT TOP 1 UnitPrice FROM PurchaseDetails WHERE ProductId = " + productId + "";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public bool DeleteProduct(int productId)
        {
            bool isDelete = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = "DELETE Products WHERE Id = " + productId + "";
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

        public List<PurchaseDetails> SearchProduct(string criteria)
        {
            List<PurchaseDetails> purchaseDetails = new List<PurchaseDetails>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT * FROM PurchaseDetails WHERE ManufacturedDate = '" + criteria + "'OR Code = '" + criteria + "' OR Product = '" + criteria + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                PurchaseDetails purchaseDetail = new PurchaseDetails();

                purchaseDetail.SL = sqlDataReader["SL"].ToString();
                purchaseDetail.Id = Convert.ToInt32(sqlDataReader["Id"]);
                purchaseDetail.BillNo = sqlDataReader["BillNo"].ToString();
                purchaseDetail.CategoryId = Convert.ToInt32(sqlDataReader["CategoryId"]);
                purchaseDetail.ProductId = Convert.ToInt32(sqlDataReader["ProductId"]);
                purchaseDetail.Code = sqlDataReader["Code"].ToString();
                purchaseDetail.Category = sqlDataReader["Category"].ToString();
                purchaseDetail.Product = sqlDataReader["Product"].ToString();
                purchaseDetail.ManufacturedDate = sqlDataReader["ManufacturedDate"].ToString();
                purchaseDetail.ExpireDate = sqlDataReader["ExpireDate"].ToString();
                purchaseDetail.Quantity = Convert.ToDouble(sqlDataReader["Quantity"].ToString());
                purchaseDetail.UnitPrice = Convert.ToDouble(sqlDataReader["UnitPrice"].ToString());
                purchaseDetail.TotalPrice = Convert.ToDouble(sqlDataReader["TotalPrice"].ToString());
                purchaseDetail.MRP = Convert.ToDouble(sqlDataReader["MRP"].ToString());
                purchaseDetail.Remarks = sqlDataReader["Remarks"].ToString();

                purchaseDetails.Add(purchaseDetail);
            }
            sqlConnection.Close();

            return purchaseDetails;
        }

        public int CountRecord()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT COUNT(*) FROM PurchaseDetails";
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

        public DataTable CodeSelect(string productName)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT Code FROM Products WHERE Name = '" + productName + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        int purchaseMaxId;
        public int MaxIdOfPurchase()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT MAX(Id) FROM PurchaseSupplier ";
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

    }
}
