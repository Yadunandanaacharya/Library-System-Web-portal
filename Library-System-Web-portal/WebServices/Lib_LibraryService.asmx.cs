using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Library_System_Web_portal.WebServices
{
    /// <summary>
    /// Summary description for Lib_LibraryService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Lib_LibraryService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        //[System.Web.Services.WebMethod(EnableSession = true)]
        //[System.Web.Script.Services.ScriptMethod(ResponseFormat = System.Web.Script.Services.ResponseFormat.Json)]
        //public string InsertOrUpdateStorageSectionInfo(BasicParam basicParam, WarehouseBasicInfo storageInfo)
        //{
        //    CommonBLL.AccessType accessType = CommonBLL.ValidateUserPrivilege(basicParam.SiteID, basicParam.UserID, basicParam.AccessLevelID, Convert.ToInt32(PageID_Resources.PageID_Resources.ManageWarehouseConfiguration), false);
        //    if (accessType == CommonBLL.AccessType.FULL_ACCESS || (storageInfo.WarehouseInfoID > 0 && accessType == CommonBLL.AccessType.EDIT_ONLY))
        //        return BLL.Plant.InsertOrUpdateStorageSectionInfo(basicParam, storageInfo);
        //    else
        //        throw new Exception("Invalid user request");
        //}

        //[System.Web.Services.WebMethod(EnableSession =true)]
        //[System.Web.Script.Services.ScriptMethod(ResponseFormat =System.Web.Script.Services.ResponseFormat.Json)]
        //public void InsertUpdateUserDetails(SignUp signUp)

    }
}
