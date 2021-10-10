using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using Library_System_Web_portal_Service.Library;
using Library_System_Web_portal_Service_DAL;

namespace Library_System_Web_portal_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LibraryService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LibraryService.svc or LibraryService.svc.cs at the Solution Explorer and start debugging.
    public class LibraryService : ILibraryService
    {
        public void InsertUpdateUserDetails(SignUp signUp)
        {
            IDataReader dataReader = null;
            try
            {
                Database db = DatabaseFactory.CreateDatabase("ConnectionStringSqlServer");
                //SignUp signUp = null;

                if(signUp.MemberID == "")
                {
                    LibraryDAL.InsertUserSignUpDetails(db, signUp.MemberID, signUp.Password, );
                }
            }
        } 

        
    }
}
