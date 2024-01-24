using Jazzydior.BusinessClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazzydior.DBClass
{
    public static class ServicesCategoryDB
    {
        //Add New Category Details
            public static int AddServicesCategory(ServicesCategory servicesCategory)
        {
            SqlConnection connection = DBConnection.GetConnection();

            string insertStatement =
                  "INSERT servicesCategory " +
                  "(serv_CategoryName)" +
                  "VALUES (@serv_CategoryName)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@serv_CategoryName", servicesCategory.CategoryName);

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('servicesCategory') FROM servicesCategory";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

                int serv_CatID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return serv_CatID;
            }

            catch (SqlException ex)
            {
                throw ex;
            }

            finally
            {
                connection.Close();
            }
        }

        //Delete Category Details
            public static void DeleteServicesCategory(ServicesCategory servicesCategory)
        {

            SqlConnection connection = DBConnection.GetConnection();

            string deleteStatement = " DELETE FROM servicesCategory " +
                                     " WHERE serv_CatID = @serv_CatID";


            SqlCommand insertCommand = new SqlCommand(deleteStatement, connection);

            insertCommand.Parameters.AddWithValue("@serv_CatID", servicesCategory.CategoryID);


            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                throw ex;
            }

            finally
            {
                connection.Close();
            }
        }
    }
}
