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
    }
}