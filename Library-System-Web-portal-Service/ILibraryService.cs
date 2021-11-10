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
    }


    //[OperationContract]
    //[WebInvoke(UriTemplate = "InsertDepartment?departmentinfo={info}&basicParam={basicParam}", Method = "POST", RequestFormat = WebMessageFormat.Xml)]
    //int InsertDepartment(Company.DepartmentInfo departmentinfo, BasicParam basicParam);


    //#region User sign up details
    //[DataContract]
    //public class SignUp
    //{
    //    #region private fields
    //    public string _fullName;
    //    public string _dob;
    //    public string _contactNo;
    //    public string _emailID;
    //    public string _state;
    //    public string _city;
    //    public string _pincode;
    //    public string _fullAddress;
    //    public int _memberID;
    //    public string _password;
    //    #endregion

    //    #region public fields
    //    [DataMember]
    //    public string FullName
    //    {
    //        get { return _fullName; }
    //        set { _fullName = value; }
    //    }
    //    [DataMember]
    //    public string DOB
    //    {
    //        get { return _dob; }
    //        set { _dob = value; }
    //    }
    //    [DataMember]
    //    public string ContactNo
    //    {
    //        get { return _contactNo; }
    //        set { _contactNo = value; }
    //    }
    //    [DataMember]
    //    public string EmailID
    //    {
    //        get { return _emailID; }
    //        set { _emailID = value; }
    //    }
    //    [DataMember]
    //    public string State
    //    {
    //        get { return _state; }
    //        set { _state = value; }
    //    }
    //    [DataMember]
    //    public string City
    //    {
    //        get { return _city; }
    //        set { _city = value; }
    //    }
    //    [DataMember]
    //    public string Pincode
    //    {
    //        get { return _pincode; }
    //        set { _pincode = value; }
    //    }
    //    [DataMember]
    //    public string FullAddress
    //    {
    //        get { return _fullAddress; }
    //        set { _fullAddress = value; }
    //    }
    //    [DataMember]
    //    public int MemberID
    //    {
    //        get { return _memberID; }
    //        set { _memberID = value; }
    //    }
    //    [DataMember]
    //    public string Password
    //    {
    //        get { return _password; }
    //        set { _password = value; }
    //    }
    //    #endregion
    //}

    //#endregion

}
