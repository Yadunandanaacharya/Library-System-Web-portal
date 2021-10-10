using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Library_System_Web_portal_Service.Library
{
    #region User sign up details
    [DataContract]
    public class SignUp
    {
        #region private fields
        [DataMember] private string _fullName;
        [DataMember] private string _dob;
        [DataMember] private string _contactNo;
        [DataMember] private string _emailID;
        [DataMember] private string _state;
        [DataMember] private string _city;
        [DataMember] private string _pincode;
        [DataMember] private string _fullAddress;
        [DataMember] private int _memberID;
        [DataMember] private string _password;
        #endregion

        #region public fields
        [DataMember] public string FullName;
        [DataMember] public string DOB;
        [DataMember] public string ContactNo;
        [DataMember] public string EmailID;
        [DataMember] public string State;
        [DataMember] public string City;
        [DataMember] public string Pincode;
        [DataMember] public string FullAddress;
        [DataMember] public int MemberID;
        [DataMember] public string Password;
        #endregion
    }


    #endregion
}