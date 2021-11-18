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
        [OperationContract]
        [WebInvoke(UriTemplate = "InsertUpdateUserDetails?signUp={signUp}", Method = "POST", RequestFormat = WebMessageFormat.Xml)]
        string InsertUpdateUserDetails(SignUpDetails signUp);

        [OperationContract]
        [WebInvoke(UriTemplate = "CheckUserExists?signUp={signUp}", Method = "POST", RequestFormat = WebMessageFormat.Xml)]
        SignUpDetailLists CheckUserExists(SignUpDetail signUp);

        [OperationContract]
        [WebInvoke(UriTemplate = "CheckAuthor?authorID={authorID}", Method = "POST", RequestFormat = WebMessageFormat.Xml)]
        AuthorManage CheckAuthor(string authorID);

         [OperationContract]
        [WebInvoke(UriTemplate = "GetAuthorDetails?basicFilter={basicFilter}", Method = "POST", RequestFormat = WebMessageFormat.Xml)]
        List<AuthorDetails> GetAuthorDetails(BasicFilter basicFilter);

        [OperationContract]
        [WebInvoke(UriTemplate = "InsertAuthor?authorDetails={authorDetails}", Method = "POST", RequestFormat = WebMessageFormat.Xml)]
        bool InsertAuthor(AuthorDetails authorDetails);

        [OperationContract]
        [WebInvoke(UriTemplate = "UpdateAuthor?authorDetails={authorDetails}", Method = "POST", RequestFormat = WebMessageFormat.Xml)]
        bool UpdateAuthor(AuthorDetails authorDetails);

        [OperationContract]
        [WebInvoke(UriTemplate = "DeleteAuthor?authorID={authorID}", Method = "POST", RequestFormat = WebMessageFormat.Xml)]
        bool DeleteAuthor(string authorID);

    }

}
