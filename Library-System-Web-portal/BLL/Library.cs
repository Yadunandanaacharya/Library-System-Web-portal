using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library_System_Web_portal.LibraryService;

namespace Library_System_Web_portal.BLL
{
    public class Library
    {
        #region User details
        public static string InsertUpdateUserDetails(SignUpDetails signUp)
        {
            LibraryServiceClient client = new LibraryServiceClient();
            string output = client.InsertUpdateUserDetails(signUp);
            return output;

        }

        public static SignUpDetailLists CheckUserExists(SignUpDetail signUp)
        {
            LibraryServiceClient client = new LibraryServiceClient();
            SignUpDetailLists output = client.CheckUserExists(signUp);
            return output;
        }
        #endregion

        #region Author Infos
        public static AuthorManage CheckAuthor(string authorID)
        {
            LibraryServiceClient client = new LibraryServiceClient();
            AuthorManage output = client.CheckAuthor(authorID);
            return output;
        }

        public static AuthorManage GetAuthorDetails(BasicFilter basicFilter)
        {
            LibraryServiceClient client = new LibraryServiceClient();
            AuthorManage output = client.GetAuthorDetails(basicFilter);
            return output;

        }

        public static bool InsertAuthor(AuthorDetails authorDetails)
        {
            LibraryServiceClient client = new LibraryServiceClient();
            bool output = client.InsertAuthor(authorDetails);
            return output;

        }

        public static bool UpdateAuthor(AuthorDetails authorDetails)
        {
            LibraryServiceClient client = new LibraryServiceClient();
            bool output = client.UpdateAuthor(authorDetails);
            return output;

        }

        public static bool DeleteAuthor(string authorID)
        {
            LibraryServiceClient client = new LibraryServiceClient();
            bool output = client.DeleteAuthor(authorID);
            return output;

        }
        #endregion

        #region Member management
        public static PublisherManage CheckPublisher(string publisherID)
        {
            LibraryServiceClient client = new LibraryServiceClient();
            PublisherManage output = client.CheckPublisher(publisherID);
            return output;
        }

        public static PublisherManage GetPublisherDetails(BasicFilter basicFilter)
        {
            LibraryServiceClient client = new LibraryServiceClient();
            PublisherManage output = client.GetPublisherDetails(basicFilter);
            return output;

        }

        public static bool InsertPublisher(PublisherDetails publisherDetail)
        {
            LibraryServiceClient client = new LibraryServiceClient();
            bool output = client.InsertPublisher(publisherDetail);
            return output;

        }

        public static bool UpdatePublisher(PublisherDetails publisherDetail)
        {
            LibraryServiceClient client = new LibraryServiceClient();
            bool output = client.UpdatePublisher(publisherDetail);
            return output;

        }

        public static bool DeletePublisher(string publisherID)
        {
            LibraryServiceClient client = new LibraryServiceClient();
            bool output = client.DeletePublisher(publisherID);
            return output;

        }
        #endregion

        #region member manage
        public static MemberManage LoadMemberDetails(BasicFilter basicFilter)
        {
            LibraryServiceClient client = new LibraryServiceClient();
            MemberManage output = client.LoadMemberDetails(basicFilter);
            return output;
        }

        public static bool UpdateAccountStatus(BasicFilter basicFilter)
        {
            LibraryServiceClient client = new LibraryServiceClient();
            bool output = client.UpdateAccountStatus(basicFilter);
            return output;
        }

        #endregion

    }
}