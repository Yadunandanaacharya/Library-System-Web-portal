using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
//using Library_System_Web_portal_Service.Library;
using Library_System_Web_portal_Service_DAL;
using System.Configuration;
using Library_System_Web_portal_Service.Library;

namespace Library_System_Web_portal_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LibraryService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LibraryService.svc or LibraryService.svc.cs at the Solution Explorer and start debugging.
    public class LibraryService : ILibraryService
    {
        #region user sign up, login
        public string InsertUpdateUserDetails(SignUpDetails signUp)
        {
            IDataReader dataReader = null;
            try
            {
                string insert = "";
                //Database db = DatabaseFactory.CreateDatabase("ConnectionStringMySQL");

                //string connStr = "server=localhost;database=ELIBRARY_SYSTEM;uid=root;pwd=1234;";
                //MySqlConnection conn = new MySqlConnection(connStr);

                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringMySQL"].ConnectionString;
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                LibraryDAL dAL = new LibraryDAL();
                dataReader = LibraryDAL.CheckUserExists(connection, signUp.MemberID);
                if(dataReader.Read())
                {
                    dataReader.Close();
                    connection.Close();

                }
                else
                {
                    dataReader.Close();
                    signUp.MemberID = LibraryDAL.InsertUserSignUpDetails(connection, signUp.MemberID, signUp.Password, signUp.FullName,
                    signUp.DOB, signUp.ContactNo, signUp.EmailID, signUp.State, signUp.City, signUp.Pincode, signUp.FullAddress);
                     insert = "true";
                }
                return insert;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public SignUpDetailLists CheckUserExists(SignUpDetails signUp)
        {
            IDataReader dataReader = null;
            try
            {
                SignUpDetailLists signUpDetailLists = new SignUpDetailLists();
                List<SignUpDetails> signUpIs = new List<SignUpDetails>();
                string exist;

                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringMySQL"].ConnectionString;
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                var memberID = signUp.MemberID;
                LibraryDAL dAL = new LibraryDAL();

                //In admin table check whether user exists or not
                dataReader = dAL.CheckUserExistsAdminTable(connection, signUp.MemberID, signUp.Password);
                while (dataReader.Read())
                {
                    SignUpDetails signUpDetails = new SignUpDetails();
                    signUpDetails.MemberID = dataReader.GetString(dataReader.GetOrdinal("FMEMBER_ID"));
                    signUpDetailLists.SignUpDetails.Add(signUpDetails);

                    #region Session variables
                    #endregion
                }
                dataReader.Close();
                return signUpDetailLists;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                    dataReader.Close();
            }
            
        }
        #endregion
    }
}
