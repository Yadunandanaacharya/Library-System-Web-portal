using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;


namespace Library_System_Web_portal_Service_DAL
{
    public class LibraryDAL
    {
        #region User Details sign up
        public static int InsertUserSignUpDetails(Database db,int memberID, string passWord, string fullName,
            string dob, string contactNo, string email, string state, string city, string pinCode, string fullAddress)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            sqlCmdBuilder.Append(" INSERT INTO LIB_MEMBER_MASTER (FMEMBER_ID,FPASSWORD,FACCOUNT_STATUS,FFULL_NAME,FDOB, ");
            sqlCmdBuilder.Append("  FCONTACT_NO, FEMAIL, FSTATE, FCITY, FPINCODE,FULL_ADDRESS) ");
            sqlCmdBuilder.Append(" VALUES(0,:PASSWORD,:ACCOUNT_STATUS,:FULL_NAME,:DOB,:CONTACT_NO,:EMAIL,:STATE, ");
            sqlCmdBuilder.Append(" :CITY,:PINCODE,:FULL_ADDRESS); ");
            sqlCmdBuilder.Append("  ");

            DbCommand dbCmd = db.GetSqlStringCommand(sqlCmdBuilder.ToString());
            dbCmd.CommandType = CommandType.Text;

            db.AddInParameter(dbCmd, ":MEMBER_ID", DbType.Int32, memberID);
            db.AddInParameter(dbCmd, ":PASSWORD", DbType.String, passWord);
            db.AddInParameter(dbCmd, ":ACCOUNT_STATUS", DbType.String, "Pending");
            db.AddInParameter(dbCmd, ":FULL_NAME", DbType.String, fullName);
            db.AddInParameter(dbCmd, ":DOB", DbType.String, dob);
            db.AddInParameter(dbCmd, ":CONTACT_NO", DbType.String, contactNo);
            db.AddInParameter(dbCmd, ":EMAIL", DbType.String, email);
            db.AddInParameter(dbCmd, ":STATE", DbType.String, state);
            db.AddInParameter(dbCmd, ":CITY", DbType.String, state);
            db.AddInParameter(dbCmd, ":PINCODE", DbType.String, pinCode);
            db.AddInParameter(dbCmd, ":FULL_ADDRESS", DbType.String, fullAddress);

            db.ExecuteNonQuery(dbCmd);
            return Convert.ToInt32(db.GetParameterValue(dbCmd, ":MEMBER_ID"));
        }
        #endregion
    }
}
