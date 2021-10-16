using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Library_System_Web_portal.LibraryService;

namespace Library_System_Web_portal.WebServices
{
    /// <summary>
    /// Summary description for LibraryWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LibraryWebService : System.Web.Services.WebService
    {
        LibraryService.LibraryServiceClient client = new LibraryService.LibraryServiceClient();
        //SignUp signUp = new SignUp();

        //[System.Web.Services.WebMethod(EnableSession = true)]
        //[System.Web.Script.Services.ScriptMethod(ResponseFormat = System.Web.Script.Services.ResponseFormat.Xml)]
        //public string InsertUpdateUserDetails(LibraryService.LibraryServiceClient.SignUp signUp)
        //{
        //    return BLL.Library.InsertUpdateUserDetails(signUp);
        //}
    }
}
