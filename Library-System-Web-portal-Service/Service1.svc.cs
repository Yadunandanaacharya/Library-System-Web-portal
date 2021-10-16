using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using MySql.Data.MySqlClient;
using System.Data;
using Library_System_Web_portal_Service.Library;
using Library_System_Web_portal_Service_DAL;
using System.Configuration;

namespace Library_System_Web_portal_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string InsertUpdateUserDetails(SignUp signUp)
        {
            IDataReader dataReader = null;
            try
            {
                //Database db = DatabaseFactory.CreateDatabase("ConnectionStringMySQL");

                //string connStr = "server=localhost;database=ELIBRARY_SYSTEM;uid=root;pwd=1234;";
                //MySqlConnection conn = new MySqlConnection(connStr);

                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringMySQL"].ConnectionString;
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();

                if (signUp.MemberID == 0)
                {
                    signUp.MemberID = LibraryDAL.InsertUserSignUpDetails(conn, signUp.MemberID, signUp.Password, signUp.FullName,
                    signUp.DOB, signUp.ContactNo, signUp.EmailID, signUp.State, signUp.City, signUp.Pincode, signUp.FullAddress);
                }
                return signUp.MemberID.ToString();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

    }
}
