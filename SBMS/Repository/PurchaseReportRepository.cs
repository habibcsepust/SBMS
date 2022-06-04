using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.ViewModel;

namespace SBMS.Repository
{
    public class PurchaseReportRepository
    {
        DBConnection dBConnection = new DBConnection();
        public DataTable SelectPurchaseInfo(string startDate, string endDate)
        {
            string connectionString = dBConnection.ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT * FROM PurchaseModuleView WHERE Date BETWEEN '" + startDate + "' AND '"+endDate+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable DisplayAllPurchaseInfo()
        {
            string connectionString = dBConnection.ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT * FROM PurchaseModuleView";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        //public List<PurchaseModuleView> DisplayAllPurchaseInfo()
        //{
        //    List<PurchaseModuleView> purchaseModuleViews = new List<PurchaseModuleView>();
        //    string connectionString = dBConnection.ConnectionString;
        //    SqlConnection sqlConnection = new SqlConnection(connectionString);
        //    sqlConnection.Open();
        //    string commandString = @"SELECT * FROM PurchaseModuleView";
        //    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

        //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

        //    while (sqlDataReader.Read())
        //    {
        //        PurchaseModuleView purchaseModuleView = new PurchaseModuleView();

        //        purchaseModuleView.SL = Convert.ToInt32(sqlDataReader["SL"].ToString());
        //        purchaseModuleView.Id = Convert.ToInt32(sqlDataReader["Id"]);
        //        purchaseModuleView.Code = sqlDataReader["Code"].ToString();
        //        purchaseModuleView.Name = sqlDataReader["Name"].ToString();
        //        purchaseModuleView.Category = sqlDataReader["Category"].ToString(); 
        //        purchaseModuleView.Date = sqlDataReader["Date"].ToString();
        //        purchaseModuleView.StockQty = Convert.ToDouble(sqlDataReader["StockQty"]);
        //        purchaseModuleView.CP = Convert.ToDouble(sqlDataReader["CP"].ToString());
        //        purchaseModuleView.SalesPrice = Convert.ToDouble(sqlDataReader["SalesPrice"].ToString());
        //        purchaseModuleView.Profit = Convert.ToDouble(sqlDataReader["Profit"]);


        //        purchaseModuleViews.Add(purchaseModuleView);
        //    }
        //    sqlConnection.Close();

        //    return purchaseModuleViews;
        //}
    }
}
