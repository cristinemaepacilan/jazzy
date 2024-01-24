using Jazzydior.BusinessClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazzydior.DBClass
{
    public static class StaffsDB
    {
        //Add New Staffs Details
            public static int AddStaffs(Staffs staffs)
        {
            SqlConnection connection = DBConnection.GetConnection();

            string insertStatement =
                  "INSERT staffs " +
                  "(staff_FName, staff_LName, staff_PositionID, staff_Sex, staff_Street, staff_BuildingNo, staff_HouseNo, " +
                            "staff_Purok, staff_Brgy, staff_City, staff_Province, staff_Country, staff_ContactNo, " +
                            "staff_Email, staff_Status) " +
                  "VALUES (@staff_FName, @staff_LName, @staff_PositionID, @staff_Sex, @staff_Street, @staff_BuildingNo, " +
                            "@staff_HouseNo, @staff_Purok, @staff_Brgy, @staff_City, @staff_Province, @staff_Country, @staff_ContactNo, " +
                            "@staff_Email, @staff_Status )";

            
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@staff_FName", staffs.StaffFName);
            insertCommand.Parameters.AddWithValue("@staff_LName", staffs.StaffLName);
            insertCommand.Parameters.AddWithValue("@staff_PositionID", staffs.StaffPositionID);
            insertCommand.Parameters.AddWithValue("@staff_Sex", staffs.StaffSex);
            insertCommand.Parameters.AddWithValue("@staff_Street", staffs.StaffStreet);
            insertCommand.Parameters.AddWithValue("@staff_BuildingNo", staffs.StaffBuildingNo);
            insertCommand.Parameters.AddWithValue("@staff_HouseNo", staffs.StaffHouseNo);
            insertCommand.Parameters.AddWithValue("@staff_Purok", staffs.StaffPurok);
            insertCommand.Parameters.AddWithValue("@staff_Brgy", staffs.StaffBarangay);
            insertCommand.Parameters.AddWithValue("@staff_City", staffs.StaffCity);
            insertCommand.Parameters.AddWithValue("@staff_Province", staffs.StaffProvince);
            insertCommand.Parameters.AddWithValue("@staff_Country", staffs.StaffCountry);
            insertCommand.Parameters.AddWithValue("@staff_ContactNo", staffs.StaffContactNo);
            insertCommand.Parameters.AddWithValue("@staff_Email", staffs.StaffEmail);
            insertCommand.Parameters.AddWithValue("@staff_Status", staffs.StaffStatus);
            insertCommand.Parameters.AddWithValue("@staff_ID", staffs.StaffID);

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('staffs') FROM staffs";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

                int staff_ID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return staff_ID;

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

        //Update Staffs Details
            public static void UpdateStaffs(Staffs staffs)
        {
            SqlConnection connection = DBConnection.GetConnection();

            string updateStatement =
                  "UPDATE staffs SET staff_FName = @staff_FName," +
                  "staff_LName = @staff_LName, staff_PositionID = @staff_PositionID, staff_Sex = @staff_Sex," +
                  "staff_Street = @staff_Street, staff_BuildingNo = @staff_BuildingNo, staff_HouseNo = @staff_HouseNo," +
                  "staff_Purok = @staff_Purok, staff_Brgy = @staff_Brgy, staff_City = @staff_City, staff_Province = @staff_Province," +
                  "staff_Country = @staff_Country, staff_ContactNo = @staff_ContactNo," +
                  "staff_Email = @staff_Email, staff_Status = @staff_Status " +
                  "WHERE staff_ID = @staff_ID";

            SqlCommand insertCommand = new SqlCommand(updateStatement, connection);

            insertCommand.Parameters.AddWithValue("@staff_FName", staffs.StaffFName);
            insertCommand.Parameters.AddWithValue("@staff_LName", staffs.StaffLName);
            insertCommand.Parameters.AddWithValue("@staff_PositionID", staffs.StaffPositionID);
            insertCommand.Parameters.AddWithValue("@staff_Sex", staffs.StaffSex);
            insertCommand.Parameters.AddWithValue("@staff_Street", staffs.StaffStreet);
            insertCommand.Parameters.AddWithValue("@staff_BuildingNo", staffs.StaffBuildingNo);
            insertCommand.Parameters.AddWithValue("@staff_HouseNo", staffs.StaffHouseNo);
            insertCommand.Parameters.AddWithValue("@staff_Purok", staffs.StaffPurok);
            insertCommand.Parameters.AddWithValue("@staff_Brgy", staffs.StaffBarangay);
            insertCommand.Parameters.AddWithValue("@staff_City", staffs.StaffCity);
            insertCommand.Parameters.AddWithValue("@staff_Province", staffs.StaffProvince);
            insertCommand.Parameters.AddWithValue("@staff_Country", staffs.StaffCountry);
            insertCommand.Parameters.AddWithValue("@staff_ContactNo", staffs.StaffContactNo);
            insertCommand.Parameters.AddWithValue("@staff_Email", staffs.StaffEmail);
            insertCommand.Parameters.AddWithValue("@staff_Status", staffs.StaffStatus);
            insertCommand.Parameters.AddWithValue("@staff_ID", staffs.StaffID);


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

        // Delete Staff Details
            public static void DeleteStaffs(Staffs staffs)
        {

            SqlConnection connection = DBConnection.GetConnection();

            string deleteStatement = " DELETE FROM staffs " +
                                     " WHERE staff_ID = @staff_ID";


            SqlCommand insertCommand = new SqlCommand(deleteStatement, connection);

            insertCommand.Parameters.AddWithValue("@staff_ID", staffs.StaffID);


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
