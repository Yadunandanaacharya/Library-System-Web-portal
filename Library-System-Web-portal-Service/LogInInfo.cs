using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
using System.Runtime.Serialization;
using Library_System_Web_portal_Service_DAL;
using Library_System_Web_portal_Service.Library;

namespace Library_System_Web_portal_Service
{
   
    public class LogInInfo 
    {
        
        
        public static LoginInfo GetCurrentUserInfo(string memberID, string passWord)
        {
            IDataReader dataReader = null;
            LoginInfo logInInfo = null;

            try
            {
                dataReader = LibraryDAL.GetUserDetails(memberID,passWord);
               
                while (dataReader.Read())
                {
                    logInInfo = new LoginInfo();
                    logInInfo.FullName = dataReader.GetString(dataReader.GetOrdinal("FFULL_NAME"));
                    logInInfo.MemberID = dataReader.GetString(dataReader.GetOrdinal("FMEMBER_ID"));
                    logInInfo.Password = dataReader.GetString(dataReader.GetOrdinal("FPASSWORD"));
                    logInInfo.AccountStatus = dataReader.GetString(dataReader.GetOrdinal("FACCOUNT_STATUS"));
                    logInInfo.Count = dataReader.GetInt32(dataReader.GetOrdinal("FTOTAL"));
                    //Session["Role"] = "User";
                }
                dataReader.Close();
                return logInInfo;
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
        }

        public static LoginInfo GetCurrentAdminInfo(string memberID, string passWord)
        {
            IDataReader dataReader = null;
            LoginInfo logInInfo = null;

            try
            {
                dataReader = LibraryDAL.CheckUserAdmin(memberID, passWord);

                while (dataReader.Read())
                {
                    logInInfo = new LoginInfo();
                    logInInfo.FullName = dataReader.GetString(dataReader.GetOrdinal("FFULL_NAME"));
                    logInInfo.MemberID = dataReader.GetString(dataReader.GetOrdinal("FMEMBER_ID"));
                    logInInfo.Password = dataReader.GetString(dataReader.GetOrdinal("FPASSWORD"));
                    logInInfo.Count = dataReader.GetInt32(dataReader.GetOrdinal("FTOTAL"));
                    //Session["Role"] = "User";
                }
                dataReader.Close();
                return logInInfo;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
        }

    }
}