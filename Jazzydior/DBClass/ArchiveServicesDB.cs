using Jazzydior.BusinessClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazzydior.DBClass
{
    public static class ArchiveServicesDB
    {
    //// Delete Service Details in Archive
    //    public static void DeleteAServices(Services services)
    //    {

    //        SqlConnection connection = DBConnection.GetConnection();

    //        string deleteStatement = " DELETE FROM services " +
    //                                 " WHERE serv_ID = @serv_ID";


    //        SqlCommand insertCommand = new SqlCommand(deleteStatement, connection);

    //        insertCommand.Parameters.AddWithValue("@serv_ID", services.ServiceID);


    //        try
    //        {
    //            connection.Open();
    //            insertCommand.ExecuteNonQuery();
    //        }

    //        catch (SqlException ex)
    //        {
    //            throw ex;
    //        }

    //        finally
    //        {
    //            connection.Close();
    //        }
    //    }
    }
}
