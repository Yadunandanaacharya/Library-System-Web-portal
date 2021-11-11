using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Library_System_Web_portal_Service.Library
{
    [DataContract]
    public class AuthorManage
    {
        [DataMember] public List<AuthorDetails> AuthorDetails { get; set; } = new List<AuthorDetails>();
        [DataMember] public int TotalRecords { get; set; } = 0;
    }

    [DataContract]
    public class AuthorDetails
    {
        #region private fields
        public string _authorID;
        public string _authorName;
        #endregion

        #region public fields
        [DataMember]
        public string AuthorID
        {
            get { return _authorID; }
            set { _authorID = value; }
        }

        [DataMember]
        public string AuthorName
        {
            get { return _authorName; }
            set { _authorName = value; }
        }
        

        #endregion
    }

}