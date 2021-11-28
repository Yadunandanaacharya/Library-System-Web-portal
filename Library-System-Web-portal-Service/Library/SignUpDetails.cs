using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Library_System_Web_portal_Service.Library
{
    
    [DataContract]
    public class SignUpDetails
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
        #endregion

        #region public fields
        [DataMember]
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
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

    [DataContract]
    public class SignUpDetailLists
    {
        [DataMember] public List<SignUpDetail> SignUpDetail { get; set; } = new List<SignUpDetail>();
        [DataMember] public int TotalRecords { get; set; } = 0;
    }

    [DataContract]
    public class SignUpDetail
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
        #endregion

        #region public fields
        [DataMember]
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
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

    [DataContract]
    public class BasicFilter
    {
        #region private fields
        private string _authorID;
        
        #endregion

        #region public fields
        [DataMember]
        public string AuthorID
        {
            get { return _authorID; }
            set { _authorID = value; }
        }

        [DataMember] public int PageStart { get; set; } = 0;
        [DataMember] public int RecordsPerPage { get; set; } = 0;
        #endregion

    }
}