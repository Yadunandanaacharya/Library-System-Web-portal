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
using Quintsys.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;

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

        public SignUpDetailLists CheckUserExists(SignUpDetail signUp)
        {
            IDataReader dataReader = null;
            try
            {
                SignUpDetailLists signUpDetailLists = new SignUpDetailLists();
                List<SignUpDetail> signUpIs = new List<SignUpDetail>();

                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringMySQL"].ConnectionString;
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                var memberID = signUp.MemberID;

                //In admin table check whether user exists or not
                dataReader = LibraryDAL.CheckUserExistsAdminTable(connection, signUp.MemberID, signUp.Password);
                while (dataReader.Read())
                {
                    SignUpDetail signUpDetails = new SignUpDetail();
                    signUpDetails.MemberID = dataReader.GetString(dataReader.GetOrdinal("FMEMBER_ID"));
                    signUpDetailLists.SignUpDetail.Add(signUpDetails);
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

        #region Check author exists
        public AuthorManage CheckAuthor(string authorID)
        {
            IDataReader dataReader = null;
            try
            {
                AuthorManage authorManage = new AuthorManage();
                List<AuthorDetails> authorDetails = new List<AuthorDetails>();

                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringMySQL"].ConnectionString;
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                //In admin table check whether user exists or not
                dataReader = LibraryDAL.CheckAuthorExist(connection, authorID);
                while (dataReader.Read())
                {
                    AuthorDetails authorDetailIs = new AuthorDetails();
                    authorDetailIs.AuthorID = dataReader.GetString(dataReader.GetOrdinal("FAUTHOR_ID"));
                    authorDetailIs.AuthorName = dataReader.GetString(dataReader.GetOrdinal("FAUTHOR_NAME"));
                    authorManage.AuthorDetails.Add(authorDetailIs);

                    if (authorManage.TotalRecords == 0)
                        authorManage.TotalRecords = dataReader.GetInt32(dataReader.GetOrdinal("FTOTAL"));
                }
                dataReader.Close();
                return authorManage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                    dataReader.Close();
            }
        }

        public List<AuthorDetails> GetAuthorDetails(BasicFilter basicFilter)
        {
            IDataReader dataReader = null;
            try
            {
                AuthorManage authorManage = new AuthorManage();
                List<AuthorDetails> authorDetails = new List<AuthorDetails>();

                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringMySQL"].ConnectionString;
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                //In admin table check whether user exists or not
                dataReader = LibraryDAL.GetAuthorData(connection, basicFilter.AuthorID,basicFilter.PageStart,basicFilter.PageEnd);
               
                while (dataReader.Read())
                {
                    AuthorDetails authors = new AuthorDetails();
                    authors.AuthorID = dataReader.GetString(dataReader.GetOrdinal("FAUTHOR_ID"));
                    authors.AuthorName = dataReader.GetString(dataReader.GetOrdinal("FAUTHOR_NAME"));
                    authorDetails.Add(authors);
                    authorManage.AuthorDetails.Add(authors);
                   
                }
                dataReader.Close();
                return authorDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                    dataReader.Close();
            }
        }

        public bool InsertAuthor(AuthorDetails authorDetails)
        {
            IDataReader dataReader = null;
            try
            {
                AuthorManage authorManage = new AuthorManage();
                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                var db = factory.Create("ConnectionStringMySQL");
                //Database db = DatabaseFactory.CreateDatabase("ConnectionStringMySQL");

                bool authorAlreadyInserted = false;//here =false is needed if not throws error in !authorInserted if condition
                //unassigned variables

                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringMySQL"].ConnectionString;
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                #region tried to use datatable but not returning any row
                //In admin table check whether user exists or not
                //DataTable dataTable = LibraryDAL.CheckAuthorExistTable(db, authorDetails.AuthorID);
                //if (dataTable.Rows.Count > 0)
                //{
                //    authorAlreadyInserted = true;
                //}

                //if (!authorAlreadyInserted)
                //{
                //    LibraryDAL.InsertAuthor(connection, authorDetails.AuthorID, authorDetails.AuthorName);
                //}
                #endregion

                dataReader = LibraryDAL.CheckAuthorExist(connection, authorDetails.AuthorID);
                if (dataReader.Read())
                {
                    authorManage.TotalRecords = dataReader.GetInt32(dataReader.GetOrdinal("FTOTAL"));
                }
                dataReader.Close();
                if (authorManage.TotalRecords==0)
                {
                    LibraryDAL.InsertAuthor(connection, authorDetails.AuthorID, authorDetails.AuthorName);
                    authorAlreadyInserted = true; //when true means author inserted to db. If false means author already there
                }

                return authorAlreadyInserted;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                    dataReader.Close();
            }
        }

        public bool UpdateAuthor(AuthorDetails authorDetails)
        {
            IDataReader dataReader = null;
            try
            {
                bool authorExist = false;

                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringMySQL"].ConnectionString;
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                //In admin table check whether user exists or not
                //DataTable dataTable = LibraryDAL.CheckAuthorExistTable(db, authorDetails.AuthorID);
                //if (dataTable.Rows.Count > 0)
                //{
                //    authorExist = true;
                //}
                //if (authorExist)
                //{
                //    LibraryDAL.UpdateAuthor(connection, authorDetails.AuthorID, authorDetails.AuthorName);
                //}
                //else if (!authorExist)
                //{
                //    LibraryDAL.InsertAuthor(connection, authorDetails.AuthorID, authorDetails.AuthorName);
                //    authorExist = true;
                //}

                AuthorManage authorManage = new AuthorManage();
                dataReader = LibraryDAL.CheckAuthorExist(connection, authorDetails.AuthorID);
                if (dataReader.Read())
                {
                    authorManage.TotalRecords = dataReader.GetInt32(dataReader.GetOrdinal("FTOTAL"));
                }
                dataReader.Close();
                if (authorManage.TotalRecords >0)
                {
                    LibraryDAL.UpdateAuthor(connection, authorDetails.AuthorID, authorDetails.AuthorName);
                    authorExist = true; //if true author existed and updated
                }
                else if (authorManage.TotalRecords == 0)
                {
                    LibraryDAL.InsertAuthor(connection, authorDetails.AuthorID, authorDetails.AuthorName);
                    authorExist = false; //if false author doesn't exist so it inserted
                }

                return authorExist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                    dataReader.Close();
            }
        }

        public bool DeleteAuthor(string authorID)
        {
            IDataReader dataReader = null;
            try
            {
                bool authorExist = false;

                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringMySQL"].ConnectionString;
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                
                AuthorManage authorManage = new AuthorManage();
                dataReader = LibraryDAL.CheckAuthorExist(connection,  authorID);
                if (dataReader.Read())
                {
                    authorManage.TotalRecords = dataReader.GetInt32(dataReader.GetOrdinal("FTOTAL"));
                }
                dataReader.Close();
                if (authorManage.TotalRecords > 0)
                {
                    LibraryDAL.DeleteAuthor(connection, authorID);
                    authorExist = true; //if true means author deleted, if false means author doesn't exist
                }

                return authorExist;
            }
            catch (Exception ex)
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
