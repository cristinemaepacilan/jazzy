using Jazzydior.BusinessClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazzydior.DBClass
{
    public static class ServicePackageDB
    {
        //Add New Package Details
        public static int AddServicesPackage(ServicePackage servicePackage)
        {
            SqlConnection connection = DBConnection.GetConnection();

            string insertStatement =
                  "INSERT servicePackage " +
                  "(pckg_Name, pckg_Serv1, pckg_Serv2, pckg_Serv3, pckg_Serv4, pckg_Serv5, pckg_LeadTime, pckg_Price)" +
                  "VALUES (@pckg_Name, @pckg_Serv1, @pckg_Serv2, @pckg_Serv3, @pckg_Serv4, @pckg_Serv5, @pckg_LeadTime, @pckg_Price)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@pckg_Name", servicePackage.PackageName);
            insertCommand.Parameters.AddWithValue("@pckg_Serv1", servicePackage.Service1);
            insertCommand.Parameters.AddWithValue("@pckg_Serv2", servicePackage.Service2);
            insertCommand.Parameters.AddWithValue("@pckg_Serv3", servicePackage.Service3);
            insertCommand.Parameters.AddWithValue("@pckg_Serv4", servicePackage.Service4);
            insertCommand.Parameters.AddWithValue("@pckg_Serv5", servicePackage.Service5);
            insertCommand.Parameters.AddWithValue("@pckg_LeadTime", servicePackage.PackageLeadTime);
            insertCommand.Parameters.AddWithValue("@pckg_Price", servicePackage.PackagePrice);
            insertCommand.Parameters.AddWithValue("@pckg_ID", servicePackage.PackageID);

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('servicePackage') FROM servicePackage";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

                int pckg_ID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return pckg_ID;

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

        //Update Package Details
        public static void UpdateServicesPackage(ServicePackage servicePackage)
        {

            SqlConnection connection = DBConnection.GetConnection();

            string updateStatement =
                " UPDATE servicePackage SET pckg_Name = @pckg_Name, " +
                " pckg_Serv1 = @pckg_Serv1, pckg_Serv2 = @pckg_Serv2, pckg_Serv3 = @pckg_Serv3, " +
                " pckg_Serv4 = @pckg_Serv4, pckg_Serv5 = @pckg_Serv5, pckg_LeadTime = @pckg_LeadTime, pckg_Price = @pckg_Price" +
                " WHERE pckg_ID = @pckg_ID";



            SqlCommand insertCommand = new SqlCommand(updateStatement, connection);

            insertCommand.Parameters.AddWithValue("@pckg_ID", servicePackage.PackageID);
            insertCommand.Parameters.AddWithValue("@pckg_Name", servicePackage.PackageName);
            insertCommand.Parameters.AddWithValue("@pckg_Serv1", servicePackage.Service1);
            insertCommand.Parameters.AddWithValue("@pckg_Serv2", servicePackage.Service2);
            insertCommand.Parameters.AddWithValue("@pckg_Serv3", servicePackage.Service3);
            insertCommand.Parameters.AddWithValue("@pckg_Serv4", servicePackage.Service4);
            insertCommand.Parameters.AddWithValue("@pckg_Serv5", servicePackage.Service5);
            insertCommand.Parameters.AddWithValue("@pckg_LeadTime", servicePackage.PackageLeadTime);
            insertCommand.Parameters.AddWithValue("@pckg_Price", servicePackage.PackagePrice);

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

        //Delete Package Details
        public static void DeleteServicesPackage(ServicePackage servicePackage)
        {

            SqlConnection connection = DBConnection.GetConnection();

            string deleteStatement = " DELETE FROM servicePackage " +
                                     " WHERE pckg_ID = @pckg_ID";


            SqlCommand insertCommand = new SqlCommand(deleteStatement, connection);

            insertCommand.Parameters.AddWithValue("@pckg_ID", servicePackage.PackageID);


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
