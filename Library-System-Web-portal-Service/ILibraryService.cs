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

        #region Author details
        [OperationContract]
        [WebInvoke(UriTemplate = "CheckAuthor?authorID={authorID}", Method = "POST", RequestFormat = WebMessageFormat.Xml)]
        AuthorManage CheckAuthor(string authorID);

        [OperationContract]
        [WebInvoke(UriTemplate = "GetAuthorDetails?basicFilter={basicFilter}", Method = "POST", RequestFormat = WebMessageFormat.Xml)]
        AuthorManage GetAuthorDetails(BasicFilter basicFilter);

        [OperationContract]
        [WebInvoke(UriTemplate = "InsertAuthor?authorDetails={authorDetails}", Method = "POST", RequestFormat = WebMessageFormat.Xml)]
        bool InsertAuthor(AuthorDetails authorDetails);

        [OperationContract]
        [WebInvoke(UriTemplate = "UpdateAuthor?authorDetails={authorDetails}", Method = "POST", RequestFormat = WebMessageFormat.Xml)]
        bool UpdateAuthor(AuthorDetails authorDetails);

        [OperationContract]
        [WebInvoke(UriTemplate = "DeleteAuthor?authorID={authorID}", Method = "POST", RequestFormat = WebMessageFormat.Xml)]
        bool DeleteAuthor(string authorID);
        #endregion

        #region member management
        [OperationContract]
        [WebInvoke(UriTemplate = "CheckPublisher?publisherID={publisherID}", Method = "POST", RequestFormat = WebMessageFormat.Xml)]
        PublisherManage CheckPublisher(string publisherID);

        [OperationContract]
        [WebInvoke(UriTemplate = "GetPublisherDetails?basicFilter={basicFilter}", Method = "POST", RequestFormat = WebMessageFormat.Xml)]
        PublisherManage GetPublisherDetails(BasicFilter basicFilter);

        [OperationContract]
        [WebInvoke(UriTemplate = "InsertPublisher?publisherDetail={publisherDetail}", Method = "POST", RequestFormat = WebMessageFormat.Xml)]
        bool InsertPublisher(PublisherDetails publisherDetail);

        [OperationContract]
        [WebInvoke(UriTemplate = "UpdatePublisher?publisherDetail={publisherDetail}", Method = "POST", RequestFormat = WebMessageFormat.Xml)]
        bool UpdatePublisher(PublisherDetails publisherDetail);

        [OperationContract]
        [WebInvoke(UriTemplate = "DeletePublisher?publisherID={publisherID}", Method = "POST", RequestFormat = WebMessageFormat.Xml)]
        bool DeletePublisher(string publisherID);
        #endregion

        #region Member management
        [OperationContract]
        [WebInvoke(UriTemplate = "CheckMemberExists?memberID={memberID}", Method = "POST", RequestFormat = WebMessageFormat.Xml)]
        MemberManage LoadMemberDetails(BasicFilter basicFilter);

        [OperationContract]
        [WebInvoke(UriTemplate = "CheckMemberExists?memberID={memberID}", Method = "POST", RequestFormat = WebMessageFormat.Xml)]
        bool UpdateAccountStatus(BasicFilter basicFilter);
        #endregion
    }

}
