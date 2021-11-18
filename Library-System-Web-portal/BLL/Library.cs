using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library_System_Web_portal.LibraryService;

namespace Library_System_Web_portal.BLL
{
    public class Library
    {
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

        #region Author Infos
        public static AuthorManage CheckAuthor(string authorID)
        {
            LibraryServiceClient client = new LibraryServiceClient();
            AuthorManage output = client.CheckAuthor(authorID);
            return output;
        }

        public static AuthorDetails[] GetAuthorDetails(BasicFilter basicFilter)
        {
            LibraryServiceClient client = new LibraryServiceClient();
            AuthorDetails[] output = client.GetAuthorDetails(basicFilter);
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
    }
}