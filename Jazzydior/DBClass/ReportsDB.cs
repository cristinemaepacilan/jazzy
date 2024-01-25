using Jazzydior.BusinessClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazzydior.DBClass
{
    public class ReportsDB
    {
        //Add New Transaction Details
        public static int AddReports(Reports reports)
        {
            SqlConnection connection = DBConnection.GetConnection();

            string insertStatement =
                  "INSERT reports " +
                  "(transact_No, trans_CustName, transact_StaffID, transact_Discount " +
                  ", transact_AmountTendered, transact_AmountDue, transact_VATSales, transact_VATAmount, transact_total)" +
                  "VALUES (@trans_No, @trans_CustName, @trans_StaffID, @trans_Discount " +
                  ", @trans_AmountTendered, @trans_AmountDue, @trans_VATSales, @trans_VATAmount, @trans_total)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@trans_ID", reports.TransactionID);
            insertCommand.Parameters.AddWithValue("@trans_No", reports.TransactionNo);
            insertCommand.Parameters.AddWithValue("@trans_CustName", reports.CustomerName);
            //insertCommand.Parameters.AddWithValue("@trans_Service", reports.TransService);
            insertCommand.Parameters.AddWithValue("@trans_StaffID", reports.TransStaffID);
            insertCommand.Parameters.AddWithValue("@trans_Discount", reports.Discount);
            insertCommand.Parameters.AddWithValue("@trans_total", reports.TransTotalAmount);
           
            insertCommand.Parameters.AddWithValue("@trans_AmountTendered", reports.TransAmountTendered);
            insertCommand.Parameters.AddWithValue("@trans_AmountDue", reports.TransAmountDue);
            insertCommand.Parameters.AddWithValue("@trans_VATSales", reports.TransVATSales);
            insertCommand.Parameters.AddWithValue("@trans_VATAmount", reports.TransVATAmount);
         


            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('reports') FROM reports";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

                int trans_ID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return trans_ID;
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

        //// Delete Transaction Details
        //    public static void DeleteServices(Transaction services)
        //{

        //    SqlConnection connection = DBConnection.GetConnection();

        //    string deleteStatement = " DELETE FROM services " +
        //                             " WHERE serv_ID = @serv_ID";


        //    SqlCommand insertCommand = new SqlCommand(deleteStatement, connection);

        //    insertCommand.Parameters.AddWithValue("@serv_ID", services.ServiceID);


        //    try
        //    {
        //        connection.Open();
        //        insertCommand.ExecuteNonQuery();
        //    }

        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }

        //    finally
        //    {
        //        connection.Close();
        //    }
        //}

    }
}
