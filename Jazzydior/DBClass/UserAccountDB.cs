using Jazzydior.BusinessClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazzydior.DBClass
{
    public static class UserAccountDB
    {
        //Add New User Details
            public static int AddUser(UserAccount userAccount)
        {
            SqlConnection connection = DBConnection.GetConnection();

            string insertStatement =
                  "INSERT userAccount " +
                  "(user_FName, user_LName, user_PositionID, user_Status, user_Username, user_Pass, user_DateCreated)" +
                  "VALUES (@user_FName, @user_LName, @user_PositionID, @user_Status, @user_Username, @user_Pass, @user_DateCreated)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@user_FName", userAccount.UserFName);
            insertCommand.Parameters.AddWithValue("@user_LName", userAccount.UserLName);
            insertCommand.Parameters.AddWithValue("@user_PositionID", userAccount.UserPositionID);
            insertCommand.Parameters.AddWithValue("@user_Status", userAccount.UserStatus);
            insertCommand.Parameters.AddWithValue("@user_Username", userAccount.Username);
            insertCommand.Parameters.AddWithValue("@user_Pass", userAccount.UserPassword);
            insertCommand.Parameters.AddWithValue("@user_DateCreated", userAccount.UserDateCreated);
            insertCommand.Parameters.AddWithValue("@user_ID", userAccount.UserID);


            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('userAccount') FROM userAccount";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

                int user_ID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return user_ID;
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

        //Update User Details
            public static void UpdateUser(UserAccount userAccount)
        {
            SqlConnection connection = DBConnection.GetConnection();

            string updateStatement =
                  "UPDATE userAccount SET user_FName = @user_FName, " +
                  "user_LName = @user_LName, user_PositionID = @user_PositionID, user_Status = @user_Status," +
                  "user_Username = @user_Username, user_Pass = @user_Pass, user_DateCreated = @user_DateCreated" +
                  " WHERE user_ID = @user_ID";

            SqlCommand insertCommand = new SqlCommand(updateStatement, connection);

            insertCommand.Parameters.AddWithValue("@user_FName", userAccount.UserFName);
            insertCommand.Parameters.AddWithValue("@user_LName", userAccount.UserLName);
            insertCommand.Parameters.AddWithValue("@user_PositionID", userAccount.UserPositionID);
            insertCommand.Parameters.AddWithValue("@user_Status", userAccount.UserStatus);
            insertCommand.Parameters.AddWithValue("@user_Username", userAccount.Username);
            insertCommand.Parameters.AddWithValue("@user_Pass", userAccount.UserPassword);
            insertCommand.Parameters.AddWithValue("@user_DateCreated", userAccount.UserDateCreated);
            insertCommand.Parameters.AddWithValue("@user_ID", userAccount.UserID);


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

        // Delete User Details
            public static void DeleteUser(UserAccount userAccount)
        {

            SqlConnection connection = DBConnection.GetConnection();

            string deleteStatement = " DELETE FROM userAccount " +
                                     " WHERE user_ID = @user_ID";


            SqlCommand insertCommand = new SqlCommand(deleteStatement, connection);

            insertCommand.Parameters.AddWithValue("@user_ID", userAccount.UserID);


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
