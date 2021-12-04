using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Library_System_Web_portal_Service.Library
{
    //don't change below class name, it's attached with file name once it's been created
    //i'm leaving below class since this file meant to mainatain different all inputs
    public class AllOtherInputVariables
    {
        
    }

    #region publish management
    [DataContract]
    public class PublisherManage : BasicFilter
    {
        [DataMember] public List<PublisherDetails> PublisherDetails { get; set; } = new List<PublisherDetails>();
        [DataMember] public int TotalRecords { get; set; } = 0;
    }

    [DataContract]
    public class PublisherDetails
    {
        #region private fields
        public string _publisherID;
        public string _publisherName;
        #endregion

        #region public fields
        [DataMember]
        public string PublisherID
        {
            get { return _publisherID; }
            set { _publisherID = value; }
        }

        [DataMember]
        public string PublisherName
        {
            get { return _publisherName; }
            set { _publisherName = value; }
        }

        #endregion
    }
    #endregion

    #region member management
    [DataContract]
    public class MemberManage
    {
        [DataMember] public List<MemberDetails> MemberDetails { get; set; } = new List<MemberDetails>();
        [DataMember] public int TotalRecords { get; set; } = 0;
        [DataMember] public int PageStart { get; set; } = 0;
    }

    public class MemberDetails
    {
        #region private fields
        public string _fullName;
        public string _dob;
        public string _contactNo;
        public string _emailID;
        public string _state;
        public string _city;
        public string _pincode;
        public string _fullAddress;
        public string _memberID;
        public string _password;
        public string _accountStatus;
        #endregion

        #region public fields
        [DataMember]
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
        [DataMember]
        public string AccountStatus
        {
            get { return _accountStatus; }
            set { _accountStatus = value; }
        }

        [DataMember]
        public string DOB
        {
            get { return _dob; }
            set { _dob = value; }
        }
        [DataMember]
        public string ContactNo
        {
            get { return _contactNo; }
            set { _contactNo = value; }
        }
        [DataMember]
        public string EmailID
        {
            get { return _emailID; }
            set { _emailID = value; }
        }
        [DataMember]
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        [DataMember]
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        [DataMember]
        public string Pincode
        {
            get { return _pincode; }
            set { _pincode = value; }
        }
        [DataMember]
        public string FullAddress
        {
            get { return _fullAddress; }
            set { _fullAddress = value; }
        }
        [DataMember]
        public string MemberID
        {
            get { return _memberID; }
            set { _memberID = value; }
        }
        [DataMember]
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        #endregion
    }

    #endregion
}