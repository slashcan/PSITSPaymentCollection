using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dbsys.AppData;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dbsys
{
    
    public class UserRepository
    {
        private DBSYSEntities db;
        public UserRepository()
        {
            db = new DBSYSEntities();
        }

        public ErrorCode NewUser(UserAccount aUserAccount, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                db.UserAccount.Add(aUserAccount);
                db.SaveChanges();

                outMessage = "Inserted";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }

        public ErrorCode CreateUserUsingStoredProf(String username, String password, int role, String status, int createdBy, ref String szResponse)
        {
            try
            {
                using (db = new DBSYSEntities())
                {
                    // Call the create stored procedure
                    //
                    db.sp_InsertUserAccount(username, password, role, status, createdBy);
                    szResponse = "Created";
                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                szResponse = "Error";
                return ErrorCode.Error;
            }
        }


        public ErrorCode UpdateUser(int? userId, String username, String password, int role, String status, ref String outMessage)
        {
           
            try
            {
                using (db = new DBSYSEntities())
                {
                    // Call the create stored procedure
                    //
                    db.sp_UpdateUser(userId, username, password, role, status);
                    outMessage = "Updated";
                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                outMessage = "Error";
                return ErrorCode.Error;
            }
            

        }

        public ErrorCode UpdateEvent(int? userId, String eventName, DateTime eventDate, int price,  ref String outMessage)
        {
            
            try
            {
                using (db = new DBSYSEntities())
                {
                    // Call the create stored procedure
                    //
                    db.sp_UpdateEvent(userId, eventName, eventDate, price);
                    outMessage = "Updated";
                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                outMessage = "Error";
                return ErrorCode.Error;
            }
        }

        public ErrorCode UpdateMisc(int? userId, String miscName, int price, ref String outMessage)
        {

            try
            {
                using (db = new DBSYSEntities())
                {
                    // Call the create stored procedure
                    //
                    db.sp_UpdateMisc(userId, miscName, price);
                    outMessage = "Updated";
                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                outMessage = "Error";
                return ErrorCode.Error;
            }


        }

        public DataTable FilterEvent(string eventname, ref String outMessage)
        {
            try
            {
                using (db = new DBSYSEntities())
                {
                    // Create a DataTable to store the results
                    DataTable dataTable = new DataTable();

                    // Call the stored procedure and fill the DataTable
                    using (var command = db.Database.Connection.CreateCommand())
                    {
                        command.CommandText = "sp_EventFilter";
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters if necessary
                        command.Parameters.Add(new SqlParameter("@EventName", eventname));

                        db.Database.Connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }

                    outMessage = "Sorted";
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                outMessage = "Error: " + ex.Message;
                return null; // Return null to indicate an error
            }
        }

        public DataTable FilterMisc(string miscname, ref String outMessage)
        {
            try
            {
                using (db = new DBSYSEntities())
                {
                    // Create a DataTable to store the results
                    DataTable dataTable = new DataTable();

                    // Call the stored procedure and fill the DataTable
                    using (var command = db.Database.Connection.CreateCommand())
                    {
                        command.CommandText = "sp_MiscFilter";
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters if necessary
                        command.Parameters.Add(new SqlParameter("@miscname", miscname));

                        db.Database.Connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }

                    outMessage = "Sorted";
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                outMessage = "Error: " + ex.Message;
                return null; // Return null to indicate an error
            }
        }



        public ErrorCode RemoveUser(int? userId, ref String outMessage)
        {
      
            try
            {
                using (db = new DBSYSEntities())
                {
                    // Remove the user
                    db.sp_DeleteUserAccount(userId);
                outMessage = "Deleted";
                return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                outMessage = "Error";
                return ErrorCode.Error;
            }
        
        }

        public ErrorCode RemoveEvent(int? eventId, ref String outMessage)
        {

            try
            {
                using (db = new DBSYSEntities())
                {
                    // Remove the user
                    db.sp_DeleteEvent(eventId);
                    outMessage = "Deleted";
                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                outMessage = "Error";
                return ErrorCode.Error;
            }

        }

        public ErrorCode RemoveMisc(int? miscId, ref String outMessage)
        {

            try
            {
                using (db = new DBSYSEntities())
                {
                    // Remove the user
                    db.sp_DeleteMisc(miscId);
                    outMessage = "Deleted";
                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                outMessage = "Error";
                return ErrorCode.Error;
            }

        }


        public UserAccount GetUserByUsername(String username)
        {
            // re-initialize db object because sometimes data in the list not updated
            using (db = new DBSYSEntities())
            {
                // SELECT TOP 1 * FROM USERACCOUNT WHERE userName == username
                return db.UserAccount.Where(s => s.userName == username).FirstOrDefault();
            }    
        }
        public List<UserAccount> UserAccounts()
        {
            using (db = new DBSYSEntities())
            {
                return db.UserAccount.ToList();
            }  
        }

        public List<vw_all_user_role> AllUserRole()
        {
            using (db = new DBSYSEntities())
            {
                return db.vw_all_user_role.ToList();
            }
        }

        public List<vw_total_event_sales> ShowEventSales()
        {
            using (db = new DBSYSEntities())
            {
                return db.vw_total_event_sales.ToList();
            }
        }

        public List<vw_total_applicants_1styr> ShowTotalEventApplicants1stYear()
        {
            using (db = new DBSYSEntities())
            {
                return db.vw_total_applicants_1styr.ToList();
            }
        }

        public List<vw_total_applicants_2ndyr> ShowTotalEventApplicants2ndYear()
        {
            using (db = new DBSYSEntities())
            {
                return db.vw_total_applicants_2ndyr.ToList();
            }
        }


        public List<vw_total_applicants_3rdyr> ShowTotalEventApplicants3rdYear()
        {
            using (db = new DBSYSEntities())
            {
                return db.vw_total_applicants_3rdyr.ToList();
            }
        }


        public List<vw_total_applicants_4thyr> ShowTotalEventApplicants4thYear()
        {
            using (db = new DBSYSEntities())
            {
                return db.vw_total_applicants_4thyr.ToList();
            }
        }


        public List<vw_total_misc_sales> ShowMiscSales() 
        {
            using (db = new DBSYSEntities())
            {
                return db.vw_total_misc_sales.ToList();
            }
        }

        public List<Events> ShowEvents()
        {
            using (db = new DBSYSEntities())
            {
                return db.Events.ToList();
            }
        }

        public List<Misc> ShowMisc()
        {
            using (db = new DBSYSEntities())
            {
                return db.Misc.ToList();
            }
        }

        public List<payment> ShowStatus()
        {
            using (db = new DBSYSEntities())
            {
                return db.payment.ToList();
            }
        }

    }
}
