using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Library_System_Web_portal_Service.Library
{
    //don't change below class name, it's attached with file name once it's been created
    public class AllOtherInputVariables : BasicFilter
    {
        
    }

    [DataContract]
    public class AuthorPublisher
    {
        [DataMember] public List<AuthorPublisherDetails> AuthorPublisherDetails { get; set; } = new List<AuthorPublisherDetails>();
        [DataMember] public int TotalRecords { get; set; } = 0;
    }

    [DataContract]
    public class AuthorPublisherDetails
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
}