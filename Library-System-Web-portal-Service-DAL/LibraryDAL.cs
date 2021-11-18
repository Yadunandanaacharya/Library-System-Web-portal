using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Library_System_Web_portal_Service_DAL
{
    public class LibraryDAL
    {
        #region User Details sign up
        public static string InsertUserSignUpDetails(MySqlConnection conn, string memberID, string passWord, string fullName,
            string dob, string contactNo, string email, string state, string city, string pinCode, string fullAddress)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            sqlCmdBuilder.Append(" INSERT INTO LIB_MEMBER_MASTER (FMEMBER_ID,FPASSWORD,FACCOUNT_STATUS,FFULL_NAME,FDOB, ");
            sqlCmdBuilder.Append("  FCONTACT_NO, FEMAIL, FSTATE, FCITY, FPINCODE,FULL_ADDRESS) ");
            sqlCmdBuilder.Append(" VALUES(@MEMBER_ID,@PASSWORD,@ACCOUNT_STATUS,@FULL_NAME,@DOB,@CONTACT_NO,@EMAIL,@STATE, ");
            sqlCmdBuilder.Append(" @CITY,@PINCODE,@FULL_ADDRESS); ");
            sqlCmdBuilder.Append(" SELECT LAST_INSERT_ID(); ");

            MySqlCommand dbCmd = new MySqlCommand(sqlCmdBuilder.ToString(), conn);
            //DbCommand dbCmd = db.CreateCommand(sqlCmdBuilder.ToString());
            //DbCommand dbCmd = db.GetSqlStringCommand(sqlCmdBuilder.ToString());
            dbCmd.CommandType = CommandType.Text;

            //db.AddInParameter(dbCmd, ":MEMBER_ID", DbType.Int32, memberID);
            //db.AddInParameter(dbCmd, ":PASSWORD", DbType.String, passWord);
            //db.AddInParameter(dbCmd, ":ACCOUNT_STATUS", DbType.String, "Pending");
            //db.AddInParameter(dbCmd, ":FULL_NAME", DbType.String, fullName);
            //db.AddInParameter(dbCmd, ":DOB", DbType.String, dob);
            //db.AddInParameter(dbCmd, ":CONTACT_NO", DbType.String, contactNo);
            //db.AddInParameter(dbCmd, ":EMAIL", DbType.String, email);
            //db.AddInParameter(dbCmd, ":STATE", DbType.String, state);
            //db.AddInParameter(dbCmd, ":CITY", DbType.String, state);
            //db.AddInParameter(dbCmd, ":PINCODE", DbType.String, pinCode);
            //db.AddInParameter(dbCmd, ":FULL_ADDRESS", DbType.String, fullAddress);

            dbCmd.Parameters.AddWithValue("@MEMBER_ID", memberID);
            dbCmd.Parameters.AddWithValue("@PASSWORD", passWord);
            dbCmd.Parameters.AddWithValue("@ACCOUNT_STATUS", "Pending");
            dbCmd.Parameters.AddWithValue("@FULL_NAME", fullName);
            dbCmd.Parameters.AddWithValue("@DOB", dob);
            dbCmd.Parameters.AddWithValue("@CONTACT_NO", contactNo);
            dbCmd.Parameters.AddWithValue("@EMAIL", email);
            dbCmd.Parameters.AddWithValue("@STATE", state);
            dbCmd.Parameters.AddWithValue("@CITY", city);
            dbCmd.Parameters.AddWithValue("@PINCODE", pinCode);
            dbCmd.Parameters.AddWithValue("@FULL_ADDRESS", fullAddress);

            //MySqlDataReader sqlDataReader = dbCmd.ExecuteReader();

            //db.ExecuteNonQuery(dbCmd);

            //return Convert.ToInt32(db.GetParameterValue(dbCmd, ":MEMBER_ID"));
            //return Convert.ToString(dbCmd.ExecuteScalar());
            
            return dbCmd.ExecuteScalar().ToString();

        }

        //checking in lib_admin_login table whether user exists
        public static IDataReader CheckUserExists(MySqlConnection conn, string memberID)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            sqlCmdBuilder.Append(" SELECT * FROM LIB_MEMBER_MASTER WHERE FMEMBER_ID=@MEMBER_ID ");

            MySqlCommand dbCmd = new MySqlCommand(sqlCmdBuilder.ToString(), conn);
            dbCmd.CommandType = CommandType.Text;

            dbCmd.Parameters.AddWithValue("@MEMBER_ID", memberID);
            return dbCmd.ExecuteReader();
        }

        //checking in lib_admin_login table whether user exists
        public static IDataReader CheckUserExistsAdminTable(MySqlConnection conn, string memberID, string passWord)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            sqlCmdBuilder.Append(" SELECT * FROM LIB_ADMIN_LOGIN WHERE FMEMBER_ID=@MEMBER_ID ");

            MySqlCommand dbCmd = new MySqlCommand(sqlCmdBuilder.ToString(), conn);
            dbCmd.CommandType = CommandType.Text;

            dbCmd.Parameters.AddWithValue("@MEMBER_ID", memberID);
            dbCmd.Parameters.AddWithValue("@PASSWORD", passWord);
            return dbCmd.ExecuteReader();
        }
        #endregion

        #region LoginInfo UserLogin and AdminLogin
        public static IDataReader GetUserDetails(string memberID, string passWord)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            sqlCmdBuilder.Append(" SELECT COUNT(*) as FTOTAL, ");
            sqlCmdBuilder.Append(" IFNULL(FMEMBER_ID,'') AS FMEMBER_ID, IFNULL(FPASSWORD,'') AS FPASSWORD, IFNULL(FFULL_NAME,'') AS FFULL_NAME, IFNULL(FACCOUNT_STATUS,0) AS FACCOUNT_STATUS ");
            sqlCmdBuilder.Append(" FROM LIB_MEMBER_MASTER WHERE FMEMBER_ID=@MEMBER_ID AND FPASSWORD=@PASSWORD ");

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringMySQL"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand dbCmd = new MySqlCommand(sqlCmdBuilder.ToString(), connection);
            dbCmd.CommandType = CommandType.Text;

            dbCmd.Parameters.AddWithValue("@MEMBER_ID", memberID.Trim());
            dbCmd.Parameters.AddWithValue("@PASSWORD", passWord.Trim());
            return dbCmd.ExecuteReader();
        }

        public static IDataReader CheckUserAdmin(string memberID, string passWord)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            sqlCmdBuilder.Append(" SELECT COUNT(*) as FTOTAL, ");
            sqlCmdBuilder.Append(" IFNULL(FMEMBER_ID,'') AS FMEMBER_ID, IFNULL(FPASSWORD,'') AS FPASSWORD, IFNULL(FFULL_NAME,'') AS FFULL_NAME ");
            sqlCmdBuilder.Append(" FROM LIB_ADMIN_LOGIN WHERE FMEMBER_ID=@MEMBER_ID AND FPASSWORD=@PASSWORD ");

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringMySQL"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand dbCmd = new MySqlCommand(sqlCmdBuilder.ToString(), connection);
            dbCmd.CommandType = CommandType.Text;

            dbCmd.Parameters.AddWithValue("@MEMBER_ID", memberID);
            dbCmd.Parameters.AddWithValue("@PASSWORD", passWord);
            return dbCmd.ExecuteReader();
        }
        #endregion

        #region Author Infos
        public static IDataReader CheckAuthorExist(MySqlConnection connection, string authorID)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            sqlCmdBuilder.Append(" SELECT COUNT(*) as FTOTAL, ");
            sqlCmdBuilder.Append(" IFNULL(FAUTHOR_ID,'') AS FAUTHOR_ID, IFNULL(FAUTHOR_NAME,'') AS FAUTHOR_NAME ");
            sqlCmdBuilder.Append(" FROM LIB_AUTHOR_MASTER WHERE FAUTHOR_ID=@AUTHOR_ID ");

            MySqlCommand dbCmd = new MySqlCommand(sqlCmdBuilder.ToString(), connection);
            dbCmd.CommandType = CommandType.Text;

            dbCmd.Parameters.AddWithValue("@AUTHOR_ID", authorID);
            return dbCmd.ExecuteReader();
        }

        public static IDataReader GetAuthorData(MySqlConnection connection,string authorID, int pageStart, int pageEnd)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            sqlCmdBuilder.Append(" SELECT  "); //if you use ftotal here it will return coutn 3 but only one row from db
            sqlCmdBuilder.Append(" IFNULL(FAUTHOR_ID,'') AS FAUTHOR_ID, IFNULL(FAUTHOR_NAME,'') AS FAUTHOR_NAME ");
            sqlCmdBuilder.Append(" FROM LIB_AUTHOR_MASTER ");

            if (authorID != "")
                sqlCmdBuilder.Append(" WHERE FAUTHOR_ID=@AUTHOR_ID ");

            MySqlCommand dbCmd = new MySqlCommand(sqlCmdBuilder.ToString(), connection);
            dbCmd.CommandType = CommandType.Text;

            dbCmd.Parameters.AddWithValue("@AUTHOR_ID", authorID);
            dbCmd.Parameters.AddWithValue("@PAGE_S", authorID);
            dbCmd.Parameters.AddWithValue("@AUTHOR_ID", authorID);
            return dbCmd.ExecuteReader();
        }

        public static DataTable CheckAuthorExistTable(Database db, string authorID)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            sqlCmdBuilder.Append(" SELECT COUNT(*) as FTOTAL, ");
            sqlCmdBuilder.Append(" IFNULL(FAUTHOR_ID,'') AS FAUTHOR_ID, IFNULL(FAUTHOR_NAME,'') AS FAUTHOR_NAME ");
            sqlCmdBuilder.Append(" FROM LIB_AUTHOR_MASTER WHERE FAUTHOR_ID=@AUTHOR_ID ");

            DbCommand dbCmd = db.GetSqlStringCommand(sqlCmdBuilder.ToString());
            dbCmd.CommandType = CommandType.Text;

            //MySqlCommand dbCmd = new MySqlCommand(sqlCmdBuilder.ToString(), db);
            //dbCmd.CommandType = CommandType.Text;

            //dbCmd.Parameters.AddWithValue("@AUTHOR_ID", authorID);
            db.AddInParameter(dbCmd, "@AUTHOR_ID", DbType.AnsiString, authorID);
            return db.ExecuteDataSet(dbCmd).Tables[0];
            
        }

        //public static DataTable CheckAuthorExistTables(MySqlConnection connection, string authorID)
        //{
        //    StringBuilder sqlCmdBuilder = new StringBuilder();
        //    sqlCmdBuilder.Append(" SELECT COUNT(*) as FTOTAL, ");
        //    sqlCmdBuilder.Append(" IFNULL(FAUTHOR_ID,'') AS FAUTHOR_ID, IFNULL(FAUTHOR_NAME,'') AS FAUTHOR_NAME ");
        //    sqlCmdBuilder.Append(" FROM LIB_AUTHOR_MASTER WHERE FAUTHOR_ID=@AUTHOR_ID ");

        //    MySqlCommand dbCmd = new MySqlCommand(sqlCmdBuilder.ToString(), connection);
        //    dbCmd.CommandType = CommandType.Text;

        //    dbCmd.Parameters.AddWithValue("@AUTHOR_ID", authorID);
        //    DataTable dataTable = new DataTable();
        //    dataTable.Load(dbCmd.ExecuteReader());
        //    dbCmd.ExecuteScalar();
        //    //connection.execut
        //    return dataTable;
        //}

        public static bool InsertAuthor(MySqlConnection connection, string authorID, String authorName)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            sqlCmdBuilder.Append(" INSERT INTO LIB_AUTHOR_MASTER (FAUTHOR_ID, FAUTHOR_NAME)  ");
            sqlCmdBuilder.Append(" VALUES (@AUTHOR_ID,@AUTHOR_NAME) ");

            MySqlCommand dbCmd = new MySqlCommand(sqlCmdBuilder.ToString(), connection);
            dbCmd.CommandType = CommandType.Text;

            dbCmd.Parameters.AddWithValue("@AUTHOR_ID", authorID);
            dbCmd.Parameters.AddWithValue("@AUTHOR_NAME", authorName);
            dbCmd.ExecuteNonQuery();
            return true;
        }

        public static IDataReader UpdateAuthor(MySqlConnection connection, string authorID, String authorName)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            sqlCmdBuilder.Append(" UPDATE LIB_AUTHOR_MASTER SET FAUTHOR_NAME=@AUTHOR_NAME ");
            sqlCmdBuilder.Append(" WHERE FAUTHOR_ID=@AUTHOR_ID ");

            MySqlCommand dbCmd = new MySqlCommand(sqlCmdBuilder.ToString(), connection);
            dbCmd.CommandType = CommandType.Text;

            dbCmd.Parameters.AddWithValue("@AUTHOR_ID", authorID);
            dbCmd.Parameters.AddWithValue("@AUTHOR_NAME", authorName);
            return dbCmd.ExecuteReader();
        }

        public static IDataReader DeleteAuthor(MySqlConnection connection, string authorID)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            sqlCmdBuilder.Append(" DELETE FROM LIB_AUTHOR_MASTER ");
            sqlCmdBuilder.Append(" WHERE FAUTHOR_ID=@AUTHOR_ID ");

            MySqlCommand dbCmd = new MySqlCommand(sqlCmdBuilder.ToString(), connection);
            dbCmd.CommandType = CommandType.Text;

            dbCmd.Parameters.AddWithValue("@AUTHOR_ID", authorID);
            return dbCmd.ExecuteReader();
        }


        #endregion
    }
}
