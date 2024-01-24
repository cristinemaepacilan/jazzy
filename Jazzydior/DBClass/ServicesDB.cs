using Jazzydior.BusinessClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazzydior.DBClass
{
    public static class ServicesDB
    {

    //Add New Service Details
        public static int AddServices(Services services)
        {
            SqlConnection connection = DBConnection.GetConnection();

            string insertStatement =
                  "INSERT services " +
                  "(serv_Name, serv_CategoryID, serv_LeadTime, serv_Price)" +
                  "VALUES (@serv_Name, @serv_CategoryID, @serv_LeadTime, @serv_Price)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@serv_Name", services.ServiceName);
            insertCommand.Parameters.AddWithValue("@serv_CategoryID", services.ServiceCategoryID);
            insertCommand.Parameters.AddWithValue("@serv_LeadTime", services.ServiceLeadTime);
            insertCommand.Parameters.AddWithValue("@serv_Price", services.ServicePrice);


            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('services') FROM services";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

                int serv_ID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return serv_ID;
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

    //Update Service Details
        public static void UpdateServices(Services services)
        {

            SqlConnection connection = DBConnection.GetConnection();

            string updateStatement =
                " UPDATE services SET serv_Name = @serv_Name, "+
                " serv_CategoryID = @serv_CategoryID,  serv_LeadTime = @serv_LeadTime, serv_Price = @serv_Price " +
                " WHERE serv_ID = @serv_ID";



            SqlCommand insertCommand = new SqlCommand(updateStatement, connection);

            insertCommand.Parameters.AddWithValue("@serv_Name", services.ServiceName);
            insertCommand.Parameters.AddWithValue("@serv_CategoryID", services.ServiceCategoryID);
            insertCommand.Parameters.AddWithValue("@serv_LeadTime", services.ServiceLeadTime);
            insertCommand.Parameters.AddWithValue("@serv_Price", services.ServicePrice);
            insertCommand.Parameters.AddWithValue("@serv_ID", services.ServiceID);


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


        // Delete Service Details
        public static void DeleteServices(Services services)
        {

            SqlConnection connection = DBConnection.GetConnection();

            string deleteStatement = " DELETE FROM services "+
                                     " WHERE serv_ID = @serv_ID";


            SqlCommand insertCommand = new SqlCommand(deleteStatement, connection);
            
            insertCommand.Parameters.AddWithValue("@serv_ID", services.ServiceID);


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
