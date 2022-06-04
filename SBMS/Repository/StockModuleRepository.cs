using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Repository
{
    public class StockModuleRepository
    {
        DBConnection dBConnection = new DBConnection();
        public DataTable DisplayStockInfo()
        {
            string connectionString = dBConnection.ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT * FROM FinalStockView";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable DisplayStockByDate(string categoryName, string productName, string startDate, string endDate)
        {
            string connectionString = dBConnection.ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT * FROM FinalStockView WHERE PurchaseDate BETWEEN '" + startDate + "' AND '" + endDate + "' OR Category = '" + categoryName + "' AND Product = '" + productName + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
