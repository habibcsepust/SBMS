using SBMS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Repository
{
    public class LoginRegisterRepository
    {
        string connectionString = @"Server = HABIB; Database = SmallBusinessManagementSystem;
                Integrated Security = true";

        public bool Login(Register register)
        {
            bool isLogin = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Registration WHERE UserName = '" + register.UserName + "' AND Password = '" + register.Password + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            int isFill = sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                isLogin = true;
            }
            return isLogin;
        }
    }
}
