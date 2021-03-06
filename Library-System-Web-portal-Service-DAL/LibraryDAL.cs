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
            dbCmd.Parameters.AddWithValue("@ACCOUNT_STATUS", "I");
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
            //if you use ftotal here it will return coutn 3 but only one row from db
            sqlCmdBuilder.Append(" SET @ROW_NUMBER=0;  "); //if you use ftotal here it will return coutn 3 but only one row from db
            sqlCmdBuilder.Append(" SELECT IFNULL(FAUTHOR_ID,'') AS FAUTHOR_ID, IFNULL(FAUTHOR_NAME,'') AS FAUTHOR_NAME ");
            sqlCmdBuilder.Append(" ,(@ROW_NUMBER := @ROW_NUMBER +1) as ROWNUM,(SELECT COUNT(*) FROM LIB_AUTHOR_MASTER) AS FTOTAL ");
            sqlCmdBuilder.Append(" FROM LIB_AUTHOR_MASTER ");

            if (authorID != "" && authorID != null)
                sqlCmdBuilder.Append(" WHERE FAUTHOR_ID=@AUTHOR_ID ");

            //below query ORDER BY LENGTH(FAUTHOR_ID) is very important because of that if l1,l10,l11,l2 displayed as l1,l2,l10,l11
            //for more understanding you can run this query in database.
            if (pageStart >= 0 )
            {
                sqlCmdBuilder.Append(" ORDER BY LENGTH(FAUTHOR_ID), ROWNUM  LIMIT @PAGE_START,@PAGE_END ");
            }

            MySqlCommand dbCmd = new MySqlCommand(sqlCmdBuilder.ToString(), connection);
            dbCmd.CommandType = CommandType.Text;

            //for @AUTHOR_ID I have to use if condition if it's not empty then only I need to use it or else, your output becomes wrong with
            //addparameter
            if (authorID != "" && authorID!= null)
                dbCmd.Parameters.AddWithValue("@AUTHOR_ID", authorID);
            if (pageStart >= 0)
            {
                dbCmd.Parameters.AddWithValue("@PAGE_START", pageStart);
                dbCmd.Parameters.AddWithValue("@PAGE_END", pageEnd);
            }
                
            return dbCmd.ExecuteReader();
        }

        public static DataTable CheckAuthorExistTable(Database db, string authorID)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            sqlCmdBuilder.Append(" SELECT ");
            sqlCmdBuilder.Append(" IFNULL(FAUTHOR_ID,'') AS FAUTHOR_ID, IFNULL(FAUTHOR_NAME,'') AS FAUTHOR_NAME, (SELECT COUNT(*) FROM LIB_AUTHOR_MASTER) AS FTOTAL ");
            sqlCmdBuilder.Append(" FROM LIB_AUTHOR_MASTER WHERE FAUTHOR_ID=@AUTHOR_ID ");

            DbCommand dbCmd = db.GetSqlStringCommand(sqlCmdBuilder.ToString());
            dbCmd.CommandType = CommandType.Text;

            //MySqlCommand dbCmd = new MySqlCommand(sqlCmdBuilder.ToString(), db);
            //dbCmd.CommandType = CommandType.Text;

            //dbCmd.Parameters.AddWithValue("@AUTHOR_ID", authorID);
            db.AddInParameter(dbCmd, "@AUTHOR_ID", DbType.AnsiString, authorID);
            return db.ExecuteDataSet(dbCmd).Tables[0];
            
        }

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
            sqlCmdBuilder.Append(" UPDATE LIB_AUTHOR_MASTER SET FAUTHOR_NAME=@AUTHOR_NAME,FAUTHOR_ID=@AUTHOR_ID ");
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

        #region Publisher Management details
        public static IDataReader CheckPublisherExist(MySqlConnection connection, string publisherID)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            sqlCmdBuilder.Append(" SELECT COUNT(*) as FTOTAL, ");
            sqlCmdBuilder.Append(" IFNULL(FPUBLISHER_ID,'') AS FPUBLISHER_ID, IFNULL(FPUBLISHER_NAME,'') AS FPUBLISHER_NAME ");
            sqlCmdBuilder.Append(" FROM LIB_PUBLISHER_MASTER WHERE FPUBLISHER_ID=@PUBLISHER_ID ");

            MySqlCommand dbCmd = new MySqlCommand(sqlCmdBuilder.ToString(), connection);
            dbCmd.CommandType = CommandType.Text;

            dbCmd.Parameters.AddWithValue("@PUBLISHER_ID", publisherID);
            return dbCmd.ExecuteReader();
        }

        public static IDataReader GetPublisherData(MySqlConnection connection, string publisherID, int pageStart, int pageEnd)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            //if you use ftotal here it will return coutn 3 but only one row from db
            sqlCmdBuilder.Append(" SET @ROW_NUMBER=0;  "); //if you use ftotal here it will return coutn 3 but only one row from db
            sqlCmdBuilder.Append(" SELECT IFNULL(FPUBLISHER_ID,'') AS FPUBLISHER_ID, IFNULL(FPUBLISHER_NAME,'') AS FPUBLISHER_NAME ");
            sqlCmdBuilder.Append(" ,(@ROW_NUMBER := @ROW_NUMBER +1) as ROWNUM,(SELECT COUNT(*) FROM LIB_PUBLISHER_MASTER) AS FTOTAL ");
            sqlCmdBuilder.Append(" FROM LIB_PUBLISHER_MASTER ");

            if (publisherID != "" && publisherID != null)
                sqlCmdBuilder.Append(" WHERE FPUBLISHER_ID=@PUBLISHER_ID ");

            //below query ORDER BY LENGTH(FAUTHOR_ID) is very important because of that if l1,l10,l11,l2 displayed as l1,l2,l10,l11
            //for more understanding you can run this query in database.
            if (pageStart >= 0)
            {
                sqlCmdBuilder.Append(" ORDER BY LENGTH(FPUBLISHER_ID), ROWNUM  LIMIT @PAGE_START,@PAGE_END ");
            }

            MySqlCommand dbCmd = new MySqlCommand(sqlCmdBuilder.ToString(), connection);
            dbCmd.CommandType = CommandType.Text;

            //for @AUTHOR_ID I have to use if condition if it's not empty then only I need to use it or else, your output becomes wrong with
            //addparameter
            if (publisherID != "" && publisherID != null)
                dbCmd.Parameters.AddWithValue("@PUBLISHER_ID", publisherID);
            if (pageStart >= 0)
            {
                dbCmd.Parameters.AddWithValue("@PAGE_START", pageStart);
                dbCmd.Parameters.AddWithValue("@PAGE_END", pageEnd);
            }

            return dbCmd.ExecuteReader();
        }

        public static DataTable CheckPublisherTable(Database db, string publisherID)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            sqlCmdBuilder.Append(" SELECT COUNT(*) as FTOTAL, ");
            sqlCmdBuilder.Append(" IFNULL(FPUBLISHER_ID,'') AS FPUBLISHER_ID, IFNULL(FPUBLISHER_NAME,'') AS FPUBLISHER_NAME ");
            sqlCmdBuilder.Append(" FROM LIB_PUBLISHER_MASTER WHERE FPUBLISHER_ID=@PUBLISHER_ID ");

            DbCommand dbCmd = db.GetSqlStringCommand(sqlCmdBuilder.ToString());
            dbCmd.CommandType = CommandType.Text;

            //MySqlCommand dbCmd = new MySqlCommand(sqlCmdBuilder.ToString(), db);
            //dbCmd.CommandType = CommandType.Text;

            //dbCmd.Parameters.AddWithValue("@AUTHOR_ID", authorID);
            db.AddInParameter(dbCmd, "@PUBLISHER_ID", DbType.AnsiString, publisherID);
            return db.ExecuteDataSet(dbCmd).Tables[0];
        }

        public static bool InsertPublisher(MySqlConnection connection, string publisherID, String publisherName)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            sqlCmdBuilder.Append(" INSERT INTO LIB_PUBLISHER_MASTER (FPUBLISHER_ID, FPUBLISHER_NAME)  ");
            sqlCmdBuilder.Append(" VALUES (@PUBLISHER_ID,@PUBLISHER_NAME) ");

            MySqlCommand dbCmd = new MySqlCommand(sqlCmdBuilder.ToString(), connection);
            dbCmd.CommandType = CommandType.Text;

            dbCmd.Parameters.AddWithValue("@PUBLISHER_ID", publisherID);
            dbCmd.Parameters.AddWithValue("@PUBLISHER_NAME", publisherName);
            dbCmd.ExecuteNonQuery();
            return true;
        }

        public static IDataReader UpdatePublisher(MySqlConnection connection, string publisherID, String publisherName)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            sqlCmdBuilder.Append(" UPDATE LIB_PUBLISHER_MASTER SET FPUBLISHER_ID=@PUBLISHER_ID,FPUBLISHER_NAME=@PUBLISHER_NAME ");
            sqlCmdBuilder.Append(" WHERE FPUBLISHER_ID=@PUBLISHER_ID ");

            MySqlCommand dbCmd = new MySqlCommand(sqlCmdBuilder.ToString(), connection);
            dbCmd.CommandType = CommandType.Text;

            dbCmd.Parameters.AddWithValue("@PUBLISHER_ID", publisherID);
            dbCmd.Parameters.AddWithValue("@PUBLISHER_NAME", publisherName);
            return dbCmd.ExecuteReader();
        }

        public static IDataReader DeletePublisher(MySqlConnection connection, string publisherID)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            sqlCmdBuilder.Append(" DELETE FROM LIB_PUBLISHER_MASTER ");
            sqlCmdBuilder.Append(" WHERE FPUBLISHER_ID=@PUBLISHER_ID ");

            MySqlCommand dbCmd = new MySqlCommand(sqlCmdBuilder.ToString(), connection);
            dbCmd.CommandType = CommandType.Text;

            dbCmd.Parameters.AddWithValue("@PUBLISHER_ID", publisherID);
            return dbCmd.ExecuteReader();
        }
        #endregion

        #region member management
        //use below method for check whether memberid exists and also to fetch all details from db related to this table
        public static IDataReader LoadMemberDetails(Database db, string memberID, int pageStart, int recordsPerPage)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            sqlCmdBuilder.Append(" SET @ROW_NUMBER=0; ");
            sqlCmdBuilder.Append(" SELECT IFNULL(FMEMBER_ID,'') AS FMEMBER_ID, IFNULL(FACCOUNT_STATUS,'') AS FACCOUNT_STATUS,IFNULL(FFULL_NAME,'') AS FFULL_NAME, ");
            sqlCmdBuilder.Append(" IFNULL(FDOB,'') AS FDOB, IFNULL(FCONTACT_NO,'') AS FCONTACT_NO,IFNULL(FEMAIL,'') AS FEMAIL,IFNULL(FSTATE,'') AS FSTATE, ");
            sqlCmdBuilder.Append(" IFNULL(FCITY,'') AS FCITY, IFNULL(FPINCODE,'') AS FPINCODE,IFNULL(FULL_ADDRESS,'') AS FULL_ADDRESS ");
            sqlCmdBuilder.Append(" ,(@ROW_NUMBER := @ROW_NUMBER +1) as ROWNUM,(SELECT COUNT(*) FROM LIB_MEMBER_MASTER) AS FTOTAL ");
            sqlCmdBuilder.Append(" FROM LIB_MEMBER_MASTER ");

            if (memberID != "" && memberID != null)
                sqlCmdBuilder.Append(" WHERE FMEMBER_ID=@MEMBER_ID ");

            //below query ORDER BY LENGTH(FAUTHOR_ID) is very important because of that if l1,l10,l11,l2 displayed as l1,l2,l10,l11
            //for more understanding you can run this query in database.
            if (pageStart >= 0)
            {
                sqlCmdBuilder.Append(" ORDER BY LENGTH(FMEMBER_ID), ROWNUM  LIMIT @PAGE_START,@PAGE_END ");
            }
            System.Data.Common.DbCommand dbCmd = db.GetSqlStringCommand(sqlCmdBuilder.ToString());
            dbCmd.CommandType = CommandType.Text;

            db.AddInParameter(dbCmd, "@MEMBER_ID", DbType.AnsiString, memberID);
            if (pageStart >= 0)
            {
                db.AddInParameter(dbCmd, "@PAGE_START", DbType.Int32, pageStart);
                db.AddInParameter(dbCmd, "@PAGE_END", DbType.Int32, recordsPerPage);
            }
            return db.ExecuteReader(dbCmd);
        }

        public static bool UpdateAccountStatus(Database db, string memberID, string accoutnStatus)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            sqlCmdBuilder.Append(" UPDATE LIB_MEMBER_MASTER SET FACCOUNT_STATUS=@ACCOUNT_STATUS WHERE FMEMBER_ID=@MEMBER_ID ");
            
            System.Data.Common.DbCommand dbCmd = db.GetSqlStringCommand(sqlCmdBuilder.ToString());
            dbCmd.CommandType = CommandType.Text;

            db.AddInParameter(dbCmd, "@MEMBER_ID", DbType.AnsiString, memberID);
            db.AddInParameter(dbCmd, "@ACCOUNT_STATUS", DbType.AnsiString, accoutnStatus);
            db.ExecuteReader(dbCmd);
            return true;
        }

        public static bool DeleteMember(Database db, string memberID, string accoutnStatus)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            sqlCmdBuilder.Append(" DELETE FROM LIB_MEMBER_MASTER  WHERE FMEMBER_ID=@MEMBER_ID ");
            
            System.Data.Common.DbCommand dbCmd = db.GetSqlStringCommand(sqlCmdBuilder.ToString());
            dbCmd.CommandType = CommandType.Text;

            db.AddInParameter(dbCmd, "@MEMBER_ID", DbType.AnsiString, memberID);
            db.AddInParameter(dbCmd, "@ACCOUNT_STATUS", DbType.AnsiString, accoutnStatus);
            db.ExecuteReader(dbCmd);
            return true;
        }


        #endregion
    }
}
