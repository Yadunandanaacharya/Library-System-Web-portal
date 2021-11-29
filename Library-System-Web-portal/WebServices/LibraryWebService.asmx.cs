using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
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
    [System.Web.Script.Services.ScriptService]
    public class LibraryWebService : System.Web.Services.WebService
    {
        #region User details
        [System.Web.Services.WebMethod(EnableSession = true)]
        [System.Web.Script.Services.ScriptMethod(ResponseFormat = System.Web.Script.Services.ResponseFormat.Xml)]
        public string InsertUpdateUserDetails(SignUpDetails signUp)
        {
            return BLL.Library.InsertUpdateUserDetails(signUp);
        }

        //[System.Web.Services.WebMethod(EnableSession =true)]
        //[System.Web.Script.Services.ScriptMethod(ResponseFormat =System.Web.Script.Services.ResponseFormat.Xml)]
        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public SignUpDetailListsInfo CheckUserExists(SignUpDetail signUp)
        {
            SignUpDetailListsInfo signUpDetailListsInfo = new SignUpDetailListsInfo();
            SignUpDetailLists signUpDetailLists =  BLL.Library.CheckUserExists(signUp);

            signUpDetailListsInfo.SignUpDetail = signUpDetailLists.SignUpDetail;

            return signUpDetailListsInfo; 
        }

        public class SignUpDetailListsInfo
        {
            public SignUpDetail[] SignUpDetail { get; set; }
            public int TotalRecord { get; set; } = 0;
        }
        #endregion

        #region author infos
        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public AuthorManageListInfo CheckAuthor(string authorID)
        {
            AuthorManageListInfo authorManageListInfo = new AuthorManageListInfo();
            AuthorManage authorDetails = BLL.Library.CheckAuthor(authorID);

            authorManageListInfo.AuthorDetails = authorDetails.AuthorDetails;
            authorManageListInfo.TotalRecord = authorDetails.TotalRecords;
            return authorManageListInfo;
        }

        public class AuthorManageListInfo
        {
            public AuthorDetails[] AuthorDetails { get; set; }
            public int TotalRecord { get; set; } = 0;
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public GetAuthorDetailsListInfo GetAuthorDetails(BasicFilter basicFilter)
        {
            GetAuthorDetailsListInfo getAuthorDetailsListInfo = new GetAuthorDetailsListInfo();
            AuthorManage authorManage = BLL.Library.GetAuthorDetails(basicFilter);
            getAuthorDetailsListInfo.AuthorManage = authorManage;
            getAuthorDetailsListInfo.TotalRecord = authorManage.TotalRecords;
            getAuthorDetailsListInfo.PageStart = authorManage.PageStart;
            return getAuthorDetailsListInfo;
        }

        public class GetAuthorDetailsListInfo
        {
            public AuthorManage AuthorManage { get; set; }
            public int TotalRecord { get; set; } = 0;
            public int PageStart { get; set; } = 0;
        }


        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public bool InsertAuthor(AuthorDetails authorDetails)
        {
            return BLL.Library.InsertAuthor(authorDetails);
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public bool UpdateAuthor(AuthorDetails authorDetails)
        {
            return BLL.Library.UpdateAuthor(authorDetails);
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public bool DeleteAuthor(string authorID)
        {
            return BLL.Library.DeleteAuthor(authorID);
        }

        #endregion

        #region Member management
        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public PublisherManageListInfo CheckPublisher(string publisherID)
        {
            PublisherManageListInfo publisherManageListInfo = new PublisherManageListInfo();
            PublisherManage publisherDetails = BLL.Library.CheckPublisher(publisherID);

            publisherManageListInfo.PublisherDetails = publisherDetails.PublisherDetails;
            publisherManageListInfo.TotalRecord = publisherDetails.TotalRecords;
            return publisherManageListInfo;
        }

        public class PublisherManageListInfo
        {
            public PublisherDetails[] PublisherDetails { get; set; }
            public int TotalRecord { get; set; } = 0;
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public GetPublisherDetailsListInfo GetPublisherDetails(BasicFilter basicFilter)
        {
            GetPublisherDetailsListInfo getPublisherDetailsListInfo = new GetPublisherDetailsListInfo();
            PublisherManage publishManage = BLL.Library.GetPublisherDetails(basicFilter);
            getPublisherDetailsListInfo.PublisherManage = publishManage;
            getPublisherDetailsListInfo.TotalRecord = publishManage.TotalRecords;
            getPublisherDetailsListInfo.PageStart = publishManage.PageStart;
            return getPublisherDetailsListInfo;
        }

        public class GetPublisherDetailsListInfo
        {
            public PublisherManage PublisherManage { get; set; }
            public int TotalRecord { get; set; } = 0;
            public int PageStart { get; set; } = 0;
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public bool InsertPublisher(PublisherDetails publisherDetail)
        {
            return BLL.Library.InsertPublisher(publisherDetail);
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public bool UpdatePublisher(PublisherDetails publisherDetail)
        {
            return BLL.Library.UpdatePublisher(publisherDetail);
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public bool DeletePublisher(string publisherID)
        {
            return BLL.Library.DeletePublisher(publisherID);
        }

        #endregion
    }
}
