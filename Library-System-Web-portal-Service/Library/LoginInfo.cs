using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;


namespace Library_System_Web_portal_Service.Library
{
    [Serializable]
    public class LoginInfo : IDeserializationCallback
    {
        #region private fields
        public string _fullName;
        public string _memberID;
        public string _password;
        public string _accountStatus;
        public int _count;
        #endregion

        #region public fields
        [DataMember]
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
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
        [DataMember]
        public string AccountStatus
        {
            get { return _accountStatus; }
            set { _accountStatus = value; }
        }
        [DataMember]
        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        #endregion

         void IDeserializationCallback.OnDeserialization(object sender)
        {
        }

    }

    

}