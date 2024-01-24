using Jazzydior.BusinessClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazzydior.DBClass
{
    public class PositionDB
    {
     //Add New Position Details
        public static int AddPosition(Position position)
        {
            SqlConnection connection = DBConnection.GetConnection();

            string insertStatement =
                  "INSERT position " +
                  "(position_Name)" +
                  "VALUES (@position_Name)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@position_Name", position.PositionName);


            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('position') FROM position";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

                int position_ID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return position_ID;
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
        public static void UpdatePosition(Position position)
        {

            SqlConnection connection = DBConnection.GetConnection();

            string updateStatement =
                " UPDATE position SET position_Name = @position_Name " +
                " WHERE position_ID = @position_ID";



            SqlCommand insertCommand = new SqlCommand(updateStatement, connection);

            insertCommand.Parameters.AddWithValue("@position_Name", position.PositionName);
            insertCommand.Parameters.AddWithValue("@position_ID", position.PositionID);


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
        public static void DeletePosition(Position position)
        {

            SqlConnection connection = DBConnection.GetConnection();

            string deleteStatement = " DELETE FROM position " +
                                     " WHERE position_ID = @position_ID";


            SqlCommand insertCommand = new SqlCommand(deleteStatement, connection);

            insertCommand.Parameters.AddWithValue("@position_ID", position.PositionID);


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
