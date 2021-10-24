﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;
using MySql.Data.MySqlClient;

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

        public IDataReader CheckUserExists(MySqlConnection conn, string memberID)
        {
            StringBuilder sqlCmdBuilder = new StringBuilder();
            sqlCmdBuilder.Append(" SELECT * FROM LIB_MEMBER_MASTER WHERE FMEMBER_ID=@MEMBER_ID ");

            MySqlCommand dbCmd = new MySqlCommand(sqlCmdBuilder.ToString(), conn);
            dbCmd.CommandType = CommandType.Text;

            dbCmd.Parameters.AddWithValue("@MEMBER_ID", memberID);
            return dbCmd.ExecuteReader();
        }

        #endregion

    }
}
