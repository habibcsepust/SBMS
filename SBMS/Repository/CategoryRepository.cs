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
    public class CategoryRepository
    {
        string connectionString = @"Server = HABIB; Database = SmallBusinessManagementSystem;
                Integrated Security = true";

        public bool IsAddCategory(Category category)
        {
            bool isAdd = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO Category(Code, Name)" +
                "VALUES('" + category.Code + "','" + category.Name + "')";
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

        public bool IsUpdateCategory(Category category,int id)
        {
            bool isUpdate = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "UPDATE Category SET Code = '"+category.Code+"', Name = '"+category.Name+"'" +
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

        public List<Category> DisplayCategory()
        {
            List<Category> categories = new List<Category>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT * FROM Category";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Category category = new Category();
                category.Id = Convert.ToInt32(sqlDataReader["Id"]);
                category.Code = sqlDataReader["Code"].ToString();
                category.Name = sqlDataReader["Name"].ToString();

                categories.Add(category);
            }
            sqlConnection.Close();

            return categories;
        }

        public bool IsExistCode(Category category)
        {
            bool IsExistCode = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Code FROM Category WHERE Code = '"+category.Code+"'";
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

        public List<Category> SearchCategory(string criteria)
        {
            List<Category> categories = new List<Category>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT * FROM Category WHERE Code = '" + criteria + "' OR Name = '" + criteria + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Category cat = new Category();
                cat.Id = Convert.ToInt32(sqlDataReader["Id"]);
                cat.Code = sqlDataReader["Code"].ToString();
                cat.Name = sqlDataReader["Name"].ToString();

                categories.Add(cat);
            }
            sqlConnection.Close();

            return categories;
        }

        public bool IsExistName(Category category)
        {
            bool IsExistCode = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "SELECT Name FROM Category WHERE Name = '" + category.Name + "'";
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

        public bool DeleteCategory(Category category)
        {
            bool isDelete = false;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = "DELETE Category WHERE Code = '" + category.Code + "'";
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

        public bool IsCodeExist(Category category)
        {
            bool isExist = false;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string commandString = @"SELECT Id FROM Categories WHERE Code='" + category.Code + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    int codewiseID = 0;
                    codewiseID = Int32.Parse(dataTable.Rows[0]["Id"].ToString());
                    if (category.Id != codewiseID)
                    {
                        isExist = true;
                    }
                }


                sqlConnection.Close();

            }
            catch (Exception exeption)
            {

            }
            return isExist;
        }

    }
}
