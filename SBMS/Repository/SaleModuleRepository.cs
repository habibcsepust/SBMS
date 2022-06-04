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
    public class SaleModuleRepository
    {
        string connectionString = @"Server = HABIB; Database = SmallBusinessManagementSystem;
                Integrated Security = true";
        int rowCount;
        int productQty;

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

        public List<SupplierPurchaseDetails> LoadProduct()
        {
            List<SupplierPurchaseDetails> stocks = new List<SupplierPurchaseDetails>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Id,Product FROM SupplierPurchaseDetails";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                SupplierPurchaseDetails stock = new SupplierPurchaseDetails();
                stock.Id = Convert.ToInt32(sqlDataReader["Id"]);
                stock.Product = sqlDataReader["Product"].ToString();

                stocks.Add(stock);
            }
            sqlConnection.Close();

            return stocks;
        }

        public List<SupplierPurchaseDetails> SelectProduct(int catId)
        {
            List<SupplierPurchaseDetails> stocks = new List<SupplierPurchaseDetails>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Id,Product FROM SupplierPurchaseDetails WHERE CategoryId = " + catId + "";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                SupplierPurchaseDetails stock = new SupplierPurchaseDetails();
                stock.Id = Convert.ToInt32(sqlDataReader["Id"]);
                stock.Product = sqlDataReader["Product"].ToString();

                stocks.Add(stock);
            }
            sqlConnection.Close();

            return stocks;
        }

        public int CountProduct(string product)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT AvailableQuantity FROM SupplierPurchaseDetails WHERE Product = '" + product + "'";
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
        //public int CountProduct(int productId)
        //{
        //    SqlConnection sqlConnection = new SqlConnection(connectionString);
        //    sqlConnection.Open();
        //    string query = "SELECT AvailableQuantity FROM SupplierPurchaseDetails WHERE productId = " + productId + "";
        //    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

        //    DataTable dataTable = new DataTable();
        //    int isFill = sqlDataAdapter.Fill(dataTable);

        //    if (dataTable.Rows.Count > 0)
        //    {
        //        rowCount = int.Parse(dataTable.Rows[0][0].ToString());
        //    }
        //    else
        //    {
        //        rowCount = 0;
        //    }
        //    return rowCount;
        //}

        public bool SaveSale(Sale sale)
        {
            bool isAdd = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"INSERT INTO Sale VALUES(" + sale.CustomerId + ",'" + sale.Date + "'," +
                "" + sale.LoyalityPoint + ")";
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

        int saleMaxId;
        public int MaxIdOfSale()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT MAX(Id) FROM Sale ";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            int isFill = sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                saleMaxId = int.Parse(dataTable.Rows[0][0].ToString());
            }
            else
            {
                saleMaxId = 0;
            }
            return saleMaxId;
        }

        public bool SaveDetailsSale(DetailSaleInfo saleDetails, double unitPrice, double profit)
        {
            bool isAdd = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"INSERT INTO SaleDetails(Code,SaleId,CategoryId,ProductId,Category,Product,AvailableQuantity,Quantity,MRP,TotalMRP,UnitPrice,Profit)
            VALUES('" + saleDetails.Code + "'," + saleDetails.SaleId + "," + saleDetails.CategoryId + "," + saleDetails.ProductId + ",'" + saleDetails.Category + "','" + saleDetails.Product + "'," +
            "" + saleDetails.Quantity + "," + saleDetails.Quantity + "," + saleDetails.MRP + "," + saleDetails.TotalMRP + "," + unitPrice + "," + profit + ")";
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

        public int CountRecord()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT COUNT(*) FROM SaleDetails";
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

        public List<Sale> CustomerLoyalityPoint(int customerId)
        {
            List<Sale> sales = new List<Sale>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT LoyalityPoint FROM Sale WHERE CustomerId = " + customerId + "";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Sale sale = new Sale();
                sale.LoyalityPoint = Convert.ToDouble(sqlDataReader["LoyalityPoint"].ToString());

                sales.Add(sale);
            }
            sqlConnection.Close();

            return sales;
        }

        public List<TemporaryLoyalityPoint> SelectTempLoyality(int customerId)
        {
            List<TemporaryLoyalityPoint> temporaryLoyalityPoints = new List<TemporaryLoyalityPoint>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT LoyalityPoint FROM TemporaryLoyalityPoint WHERE CustomerId = " + customerId + "";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                TemporaryLoyalityPoint temporaryLoyalityPoint = new TemporaryLoyalityPoint();
                temporaryLoyalityPoint.LoyalityPoint = Convert.ToDouble(sqlDataReader["LoyalityPoint"].ToString());

                temporaryLoyalityPoints.Add(temporaryLoyalityPoint);
            }
            sqlConnection.Close();

            return temporaryLoyalityPoints;
        }

        public DataTable MRPCalculate(string product)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT UnitPrice,MRP FROM SupplierPurchaseDetails WHERE Product = '" + product + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public bool IsSalesProductName(string productName)
        {
            bool isStock = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT * FROM SaleDetails WHERE Product = '" + productName + "'";
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

        public bool UpdateSalesProductQty(DetailSaleInfo saleDetails, double profit)
        {
            bool isUpdate = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = @"UPDATE SaleDetails SET AvailableQuantity = AvailableQuantity + " + saleDetails.Quantity + ",MRP = "+ saleDetails .MRP+ ",Quantity = "+saleDetails.Quantity+"," +
                "TotalMRP = "+saleDetails.TotalMRP+ ",UnitPrice = "+saleDetails.UnitPrice+",Profit = " + profit + " WHERE Product = '" + saleDetails.Product + "'";
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

        public bool UpdateStockQty(double qty, string product)
        {
            bool isUpdate = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"UPDATE SupplierPurchaseDetails SET AvailableQuantity = AvailableQuantity - " + qty + " WHERE Product = '" + product + "'";
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

        public List<SalesView> DisplaySalesInfo()
        {
            List<SalesView> salesViews = new List<SalesView>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string commandString = @"SELECT * FROM SalesView";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                SalesView salesView = new SalesView();
                salesView.SL = sqlDataReader["SL"].ToString();
                salesView.Id = Convert.ToInt32(sqlDataReader["Id"].ToString());
                salesView.Date = sqlDataReader["Date"].ToString();
                salesView.Code = sqlDataReader["Code"].ToString();
                salesView.Category = sqlDataReader["Category"].ToString();
                salesView.Product = sqlDataReader["Product"].ToString();
                salesView.SoldQty = Convert.ToDouble(sqlDataReader["SoldQty"].ToString());
                salesView.MRP = Convert.ToDouble(sqlDataReader["MRP"].ToString());
                salesView.TotalMRP = Convert.ToDouble(sqlDataReader["TotalMRP"].ToString());
                salesView.CP = Convert.ToDouble(sqlDataReader["CP"].ToString());
                salesView.Profit = Convert.ToDouble(sqlDataReader["Profit"].ToString());
                salesViews.Add(salesView);
            }
            sqlConnection.Close();
            return salesViews;
        }

        public List<SalesView> SearchSalesRecord(string startDate, string endDate)
        {
            List<SalesView> salesViews = new List<SalesView>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string commandString = @"SELECT * FROM SalesView WHERE Date BETWEEN '" + startDate + "' AND '" + endDate + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                SalesView salesView = new SalesView();
                salesView.SL = sqlDataReader["SL"].ToString();
                salesView.Id = Convert.ToInt32(sqlDataReader["Id"].ToString());
                salesView.Date = sqlDataReader["Date"].ToString();
                salesView.Code = sqlDataReader["Code"].ToString();
                salesView.Category = sqlDataReader["Category"].ToString();
                salesView.Product = sqlDataReader["Product"].ToString();
                salesView.SoldQty = Convert.ToDouble(sqlDataReader["SoldQty"].ToString());
                salesView.MRP = Convert.ToDouble(sqlDataReader["MRP"].ToString());
                salesView.TotalMRP = Convert.ToDouble(sqlDataReader["TotalMRP"].ToString());
                salesView.CP = Convert.ToDouble(sqlDataReader["CP"].ToString());
                salesView.Profit = Convert.ToDouble(sqlDataReader["Profit"].ToString());
                salesViews.Add(salesView);
            }
            sqlConnection.Close();
            return salesViews;
        }

        public DataTable CustomerEndLoyalityPoint(int customerId)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT TOP 1 LoyalityPoint FROM Sale WHERE CustomerId = " + customerId + " ORDER BY Id DESC";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        double loyalityPoint;
        public double LoyalityPoint(int customerId)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT LoyaltyPoint FROM Customers WHERE Id = " + customerId + "";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            int isFill = sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {

                loyalityPoint = double.Parse(dataTable.Rows[0][0].ToString());
            }
            return loyalityPoint;
        }

        public bool AddLoyalityPoint(TemporaryLoyalityPoint lPoint, double lp)
        {
            bool isAdd = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"INSERT INTO TemporaryLoyalityPoint VALUES(" + lPoint.CustomerId + "," + lp + ")";
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

        public bool IsExistCustomer(int customerId)
        {
            bool isStock = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT CustomerId FROM TemporaryLoyalityPoint WHERE CustomerId = '" + customerId + "'";
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

        public bool UpdateCustomerLty(double loyatiPoint, int customerId)
        {
            bool isUpdate = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = @"UPDATE TemporaryLoyalityPoint SET LoyalityPoint = " + loyatiPoint + " WHERE CustomerId = " + customerId + "";
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

        public bool DeleteLoyalityPoint(int customerId)
        {
            bool isDelete = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = "DELETE TemporaryLoyalityPoint WHERE CustomerId = " + customerId + "";
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

        public bool AddSaleStock(DetailSaleInfo saleDetails)
        {
            bool isAdd = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"INSERT INTO SoldIn(SaleId,Category,Product,Quantity)
            VALUES(" + saleDetails.SaleId + ",'" + saleDetails.Category + "','" + saleDetails.Product + "',"+saleDetails.Quantity+")";
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
