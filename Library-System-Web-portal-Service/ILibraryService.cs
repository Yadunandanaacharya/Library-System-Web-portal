using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Library_System_Web_portal_Service.Library;



namespace Library_System_Web_portal_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILibraryService" in both code and config file together.
    [ServiceContract]
    public interface ILibraryService
    {

        #region library user sign up details
        [OperationContract]
        [WebInvoke(UriTemplate = "InsertUpdateUserDetails?signUp={signUp}", Method = "PUT", RequestFormat = WebMessageFormat.Xml)]
        void InsertUpdateUserDetails(SignUp signUp);

        #endregion
    }


}
