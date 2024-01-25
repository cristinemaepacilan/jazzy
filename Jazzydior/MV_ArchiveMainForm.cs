using Jazzydior.BusinessClass;
using Jazzydior.DBClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jazzydior
{
    public partial class MV_ArchiveMainForm : Form
    {

        private DataGridViewRow currentServicesSelection;
        private DataGridViewRow currentStaffSelection;


        public MV_ArchiveMainForm()
        {
            InitializeComponent();

        }

        // Load Inputted Data to DataGrid
        private void MV_Archive_Load(object sender, EventArgs e)
        {
            LoadServiceArchive();
            LoadStaffArchive();
        }


        private void LoadServiceArchive()
        {


            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText ="  SELECT [arcServ_ID] ,[arcServ_Name],[arcServ_Category],[arcServ_LeadTime] ,[arcServ_Price],sc.serv_CategoryName" +
                " FROM archiveService  ar INNER JOIN  servicesCategory sc ON ar.arcServ_Category = sc.serv_CatID";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable("archive");
            dt.Load(sdr);
            var tname = dt.TableName;
            con.Close();

            dtgArchiveServices.DataSource = dt;

            // Change the Column Name
            dtgArchiveServices.Columns["arcServ_ID"].Visible = false;
            dtgArchiveServices.Columns["arcServ_Name"].HeaderText = "Service Name";
            dtgArchiveServices.Columns["arcServ_Category"].Visible = false;
            dtgArchiveServices.Columns["serv_CategoryName"].HeaderText = "Category";
            dtgArchiveServices.Columns["arcServ_LeadTime"].HeaderText = "Lead Time";
            dtgArchiveServices.Columns["arcServ_Price"].HeaderText = "Price";

            


        }

        private void LoadStaffArchive()
        {


            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=JazzyBL_SalesMS_&_CustomersReceipt;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText ="spGetArchivedStaff";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable("staffArchive");
            dt.Load(sdr);
            var tname = dt.TableName;
            con.Close();

            dtgArchiveStaffs.DataSource = dt;


            dtgArchiveStaffs.Columns["Staff Name"].HeaderText = "Staff Name";
            dtgArchiveStaffs.Columns["staff_Sex"].HeaderText = "Sex";
            dtgArchiveStaffs.Columns["Position"].HeaderText = "Position";
            dtgArchiveStaffs.Columns["staff_Street"].HeaderText = "Street";
            dtgArchiveStaffs.Columns["staff_BuildingNo"].HeaderText = "Building No";
            dtgArchiveStaffs.Columns["staff_HouseNo"].HeaderText = "House No";
            dtgArchiveStaffs.Columns["staff_Purok"].HeaderText = "Purok";
            dtgArchiveStaffs.Columns["staff_Brgy"].HeaderText = "Brgy";
            dtgArchiveStaffs.Columns["staff_City"].HeaderText = "City";
            dtgArchiveStaffs.Columns["staff_Province"].HeaderText = "Province";
            dtgArchiveStaffs.Columns["staff_Country"].HeaderText = "Country";
            dtgArchiveStaffs.Columns["staff_ContactNo"].HeaderText = "Contact No";
            dtgArchiveStaffs.Columns["staff_Email"].HeaderText = "Email Address";
            dtgArchiveStaffs.Columns["staff_Status"].HeaderText = "Status";
            dtgArchiveStaffs.Columns["archive_ID"].Visible = false;
            dtgArchiveStaffs.Columns["staff_FName"].Visible=false;
            dtgArchiveStaffs.Columns["staff_LName"].Visible=false;




        }




        private void dtgArchiveServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgArchiveStaffs.ClearSelection();
            currentStaffSelection = null;
            currentServicesSelection = dtgArchiveServices.SelectedRows[0];
           
        }

        private void dtgArchiveStaffs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgArchiveServices.ClearSelection();
            currentServicesSelection = null;
            currentStaffSelection = dtgArchiveStaffs.SelectedRows[0];
        }
           
        private void btnArchiveServiceDelete_Click(object sender, EventArgs e)
        {
              if(currentStaffSelection == null && currentServicesSelection == null)
                    {
                return;
                    }
                if(currentServicesSelection != null)
                {
                DeleteArchive<DataGridView, DataGridViewRow>(dtgArchiveServices, currentServicesSelection, true);
                 }
                else if( currentStaffSelection != null)
                {
                DeleteArchive<DataGridView, DataGridViewRow>(dtgArchiveStaffs, currentStaffSelection, false);
                }
                  
               
           
        }

     
        private void DeleteArchive<T, S>(T DGV, S SelectionRow, bool isService)
            where T : DataGridView
            where S : DataGridViewRow
        {

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                var table = isService ? "archiveService" : "staffs_archive";
                var criteria = isService ? "arcServ_ID" : "archive_ID";
                string deleteStatement = $" DELETE FROM {table}  WHERE {criteria} = @criteriaID";


                SqlCommand insertCommand = new SqlCommand(deleteStatement, connection);

                insertCommand.Parameters.AddWithValue("@criteriaID",(int)SelectionRow.Cells[criteria].Value);

                try
                {
                    connection.Open();
                    insertCommand.ExecuteNonQuery();
                }

                catch (SqlException ex)
                {
                    throw ex;
                }

                DGV.Rows.Remove(SelectionRow);
                if(isService )
                {
                    LoadServiceArchive();
                    currentServicesSelection = null;
                }
                else
                {
                    LoadStaffArchive();
                    currentStaffSelection = null;
                }


                DGV.ClearSelection();




            }







        }
        private void RestoreArchive<T, S>(T DGV, S SelectionRow, bool isService)
          where T : DataGridView
          where S : DataGridViewRow
        {

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                var table = isService ? "archiveService" : "staffs_archive";
                var restoretable = isService ? "[services]" : "[staffs]";
                var criteria = isService ? "arcServ_ID" : "archive_ID";
                string uniqueID = new Random().Next(1000,5000).ToString();
                var id = (int)SelectionRow.Cells[criteria].Value;

                var columnsServices = "serv_Name, serv_CategoryID, serv_LeadTime, serv_Price";
                var columnsStaff = "staff_FName,"+
                                    "staff_LName,"+
                                   " staff_PositionID,"+
                                    "staff_Sex,"+
                                   " staff_Street,"+
                                   " staff_BuildingNo,"+
                                   " staff_HouseNo,"+
                                   " staff_Purok,"+
                                   " staff_Brgy,"+
                                   " staff_City,"+
                                   " staff_Province,"+
                                   " staff_Country,"+
                                   " staff_ContactNo,"+
                                   " staff_Email,"+
                                  "  staff_Status";
                var columns = isService ? columnsServices : columnsStaff;

                //string deleteStatement = $" DELETE FROM {table}  WHERE {criteria} = @criteriaID";
                var sqlStatement = $"SELECT * INTO #{table+uniqueID} FROM {table} WHERE {criteria} = @criteriaID" +
                                    $" ALTER TABLE #{table+uniqueID} " +
                                    $" DROP COLUMN {criteria}" +
                                    $" INSERT INTO {restoretable} ({columns}) SELECT * FROM #{table+uniqueID}" +
                                    $" DELETE FROM {table} WHERE {criteria} = @criteriaID " +
                                    $" DROP TABLE #{table+uniqueID}";




                SqlCommand insertCommand = new SqlCommand(sqlStatement, connection);

                insertCommand.Parameters.AddWithValue("@criteriaID", (int)SelectionRow.Cells[criteria].Value);

                try
                {
                    connection.Open();
                    insertCommand.ExecuteNonQuery();
                }

                catch (SqlException ex)
                {
                    throw ex;
                }

                DGV.Rows.Remove(SelectionRow);
                if (isService)
                {
                    LoadServiceArchive();
                    currentServicesSelection = null;
                }
                else
                {
                    LoadStaffArchive();
                    currentStaffSelection = null;
                }


                DGV.ClearSelection();




            }







        }

        private void btnArchiveServiceRestore_Click(object sender, EventArgs e)
        {
            if (currentStaffSelection == null && currentServicesSelection == null)
            {
                return;
            }
            if (currentServicesSelection != null)
            {
                RestoreArchive<DataGridView, DataGridViewRow>(dtgArchiveServices, currentServicesSelection, true);
            }
            else if (currentStaffSelection != null)
            {
                RestoreArchive<DataGridView, DataGridViewRow>(dtgArchiveStaffs, currentStaffSelection, false);
            }
        }
    }
}
