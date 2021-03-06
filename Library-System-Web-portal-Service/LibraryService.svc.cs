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

        public AuthorManage GetAuthorDetails(BasicFilter basicFilter)
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
                dataReader = LibraryDAL.GetAuthorData(connection, basicFilter.AuthorID,basicFilter.PageStart,basicFilter.RecordsPerPage);
               
                while (dataReader.Read())
                {
                    AuthorDetails authors = new AuthorDetails();
                    authors.AuthorID = dataReader.GetString(dataReader.GetOrdinal("FAUTHOR_ID"));
                    authors.AuthorName = dataReader.GetString(dataReader.GetOrdinal("FAUTHOR_NAME"));
                    authorDetails.Add(authors);
                    authorManage.AuthorDetails.Add(authors);
                   
                    if(authorManage.TotalRecords == 0)
                        authorManage.TotalRecords = dataReader.GetInt16(dataReader.GetOrdinal("FTOTAL"));
                    authorManage.PageStart = basicFilter.PageStart;
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

        public bool InsertAuthor(AuthorDetails authorDetails)
        {
            IDataReader dataReader = null;
            try
            {
                AuthorManage authorManage = new AuthorManage();

                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                var db = factory.Create("ConnectionStringMySQL");

                bool authorAlreadyInserted = false;//here =false is needed if not throws error in !authorInserted if condition
                //unassigned variables

                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringMySQL"].ConnectionString;
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();   

                #region tried to use datatable but not returning any row
                //In admin table check whether user exists or not
                DataTable dataTable = LibraryDAL.CheckAuthorExistTable(db, authorDetails.AuthorID);
                if (dataTable.Rows.Count > 0)
                {
                    authorAlreadyInserted = true;
                }

                if (!authorAlreadyInserted)
                {
                    LibraryDAL.InsertAuthor(connection, authorDetails.AuthorID, authorDetails.AuthorName);
                }
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

        #region Publisher Management details, don't add author at front of publisher author is different publisher is different
        public PublisherManage CheckPublisher(string publisherID)
        {
            IDataReader dataReader = null;
            try
            {
                PublisherManage publisherManage = new PublisherManage();

                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringMySQL"].ConnectionString;
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                //In admin table check whether user exists or not
                dataReader = LibraryDAL.CheckPublisherExist(connection, publisherID);
                while (dataReader.Read())
                {
                    PublisherDetails publisherDetailIs = new PublisherDetails();
                    publisherDetailIs.PublisherID = dataReader.GetString(dataReader.GetOrdinal("FPUBLISHER_ID"));
                    publisherDetailIs.PublisherName = dataReader.GetString(dataReader.GetOrdinal("FPUBLISHER_NAME"));
                    publisherManage.PublisherDetails.Add(publisherDetailIs);

                    if (publisherManage.TotalRecords == 0)
                        publisherManage.TotalRecords = dataReader.GetInt32(dataReader.GetOrdinal("FTOTAL"));
                }
                dataReader.Close();
                return publisherManage;
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

        public PublisherManage GetPublisherDetails(BasicFilter basicFilter)
        {
            IDataReader dataReader = null;
            try
            {
                PublisherManage publisherManage = new PublisherManage();

                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringMySQL"].ConnectionString;
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                //In admin table check whether user exists or not
                dataReader = LibraryDAL.GetPublisherData(connection, basicFilter.PublisherID, basicFilter.PageStart, basicFilter.RecordsPerPage);

                while (dataReader.Read())
                {
                    PublisherDetails publisherDetailIs = new PublisherDetails();
                    publisherDetailIs.PublisherID = dataReader.GetString(dataReader.GetOrdinal("FPUBLISHER_ID"));
                    publisherDetailIs.PublisherName = dataReader.GetString(dataReader.GetOrdinal("FPUBLISHER_NAME"));
                    //authorDetails.Add(publisherDetailIs);
                    publisherManage.PublisherDetails.Add(publisherDetailIs);

                    if (publisherManage.TotalRecords == 0)
                        publisherManage.TotalRecords = dataReader.GetInt16(dataReader.GetOrdinal("FTOTAL"));
                    publisherManage.PageStart = basicFilter.PageStart;
                }
                dataReader.Close();
                return publisherManage;
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

        public bool InsertPublisher(PublisherDetails publisherDetail)
        {
            IDataReader dataReader = null;
            try
            {
                PublisherManage publisherManage = new PublisherManage();

                //DatabaseProviderFactory factory = new DatabaseProviderFactory();
                //var db = factory.Create("ConnectionStringMySQL");

                //using Microsoft.Practices.EnterpriseLibrary.Data; 
                //Database dbMicrosoftEnter = DatabaseFactory.CreateDatabase("ConnectionStringMySQL");

                bool publisherAlreadyInserted = false;//here =false is needed if not throws error in !authorInserted if condition
                //unassigned variables

                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringMySQL"].ConnectionString;
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                #region tried to use datatable but not returning any row
                //In admin table check whether user exists or not
                //DataTable dataTable = LibraryDAL.CheckPublisherTable(dbMicrosoftEnter, publisherDetail.PublisherID);
                //if (dataTable.Rows.Count > 0)
                //{
                //    publisherAlreadyInserted = true;
                //}

                //if (!authorAlreadyInserted)
                //{
                //    LibraryDAL.InsertAuthor(connection, authorDetails.AuthorID, authorDetails.AuthorName);
                //}
                #endregion

                dataReader = LibraryDAL.CheckPublisherExist(connection, publisherDetail.PublisherID);
                if (dataReader.Read())
                {
                    publisherManage.TotalRecords = dataReader.GetInt32(dataReader.GetOrdinal("FTOTAL"));
                }
                dataReader.Close();
                if (publisherManage.TotalRecords == 0)
                {
                    LibraryDAL.InsertPublisher(connection, publisherDetail.PublisherID, publisherDetail.PublisherName);
                    publisherAlreadyInserted = true; //when true means author inserted to db. If false means author already there
                }

                return publisherAlreadyInserted;
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

        public bool UpdatePublisher(PublisherDetails publisherDetail)
        {
            IDataReader dataReader = null;
            try
            {
                bool publisherExist = false;

                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringMySQL"].ConnectionString;
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                PublisherManage publisherManage = new PublisherManage();
                dataReader = LibraryDAL.CheckPublisherExist
                    (connection, publisherDetail.PublisherID);
                if (dataReader.Read())
                {
                    publisherManage.TotalRecords = dataReader.GetInt32(dataReader.GetOrdinal("FTOTAL"));
                }
                dataReader.Close();
                if (publisherManage.TotalRecords > 0)
                {
                    LibraryDAL.UpdatePublisher(connection, publisherDetail.PublisherID, publisherDetail.PublisherName);
                    publisherExist = true; //if true author existed and updated
                }
                else if (publisherManage.TotalRecords == 0)
                {
                    LibraryDAL.InsertPublisher(connection, publisherDetail.PublisherID, publisherDetail.PublisherName);
                    publisherExist = false; //if false author doesn't exist so it inserted
                }

                return publisherExist;
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

        public bool DeletePublisher(string publisherID)
        {
            IDataReader dataReader = null;
            try
            {
                bool authorExist = false;

                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringMySQL"].ConnectionString;
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                AuthorManage authorManage = new AuthorManage();
                dataReader = LibraryDAL.CheckPublisherExist(connection, publisherID);
                if (dataReader.Read())
                {
                    authorManage.TotalRecords = dataReader.GetInt32(dataReader.GetOrdinal("FTOTAL"));
                }
                dataReader.Close();
                if (authorManage.TotalRecords > 0)
                {
                    LibraryDAL.DeletePublisher(connection, publisherID);
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

        #region Member management page, using DatabaseProviderFactory from microsoft for db connection
        public MemberManage LoadMemberDetails(BasicFilter basicFilter)
        {
            IDataReader dataReader = null;
            try
            {
                MemberManage memberManage = new MemberManage();

                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                var db = factory.Create("ConnectionStringMySQL");

                //In admin table check whether user exists or not
                dataReader = LibraryDAL.LoadMemberDetails(db, basicFilter.MemberID, basicFilter.PageStart, basicFilter.RecordsPerPage);
                while (dataReader.Read())
                {
                    MemberDetails memberDetails = new MemberDetails();
                    memberDetails.MemberID = dataReader.GetString(dataReader.GetOrdinal("FMEMBER_ID"));
                    memberDetails.AccountStatus = dataReader.GetString(dataReader.GetOrdinal("FACCOUNT_STATUS"));
                    memberDetails.FullName = dataReader.GetString(dataReader.GetOrdinal("FFULL_NAME"));
                    memberDetails.DOB = dataReader.GetString(dataReader.GetOrdinal("FDOB"));
                    memberDetails.ContactNo = dataReader.GetString(dataReader.GetOrdinal("FCONTACT_NO"));
                    memberDetails.EmailID = dataReader.GetString(dataReader.GetOrdinal("FEMAIL"));
                    memberDetails.State = dataReader.GetString(dataReader.GetOrdinal("FSTATE"));
                    memberDetails.City = dataReader.GetString(dataReader.GetOrdinal("FCITY"));
                    memberDetails.Pincode = dataReader.GetString(dataReader.GetOrdinal("FPINCODE"));
                    memberDetails.FullAddress = dataReader.GetString(dataReader.GetOrdinal("FULL_ADDRESS"));
                    memberManage.MemberDetails.Add(memberDetails);

                    if (memberManage.TotalRecords == 0)
                        memberManage.TotalRecords = dataReader.GetInt32(dataReader.GetOrdinal("FTOTAL"));
                    memberManage.PageStart = basicFilter.PageStart;
                }
                dataReader.Close();
                return memberManage;
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

        //if account status is pending then based on button press, activates, deactivates or deletes member
        //getting value A-activate, I-Deactivate, D-delete from button click
        public bool UpdateAccountStatus(BasicFilter basicFilter)
        {
            try
            {
                bool accountStatusUpdateOrDelete = false;

                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                var db = factory.Create("ConnectionStringMySQL");

                PublisherManage publisherManage = new PublisherManage();
                if(basicFilter.AccountStatus=="A" || basicFilter.AccountStatus == "I")
                {
                    accountStatusUpdateOrDelete = LibraryDAL.UpdateAccountStatus(db, basicFilter.MemberID, basicFilter.AccountStatus);
                }
                else if(basicFilter.AccountStatus == "D")
                {
                    accountStatusUpdateOrDelete = LibraryDAL.DeleteMember(db, basicFilter.MemberID, basicFilter.AccountStatus);
                }

                return accountStatusUpdateOrDelete;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        #endregion
    }
}
