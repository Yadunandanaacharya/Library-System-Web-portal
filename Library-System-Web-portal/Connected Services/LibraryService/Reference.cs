﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_System_Web_portal.LibraryService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SignUpDetails", Namespace="http://schemas.datacontract.org/2004/07/Library_System_Web_portal_Service.Library" +
        "")]
    [System.SerializableAttribute()]
    public partial class SignUpDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DOBField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MemberIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PincodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactNo {
            get {
                return this.ContactNoField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactNoField, value) != true)) {
                    this.ContactNoField = value;
                    this.RaisePropertyChanged("ContactNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DOB {
            get {
                return this.DOBField;
            }
            set {
                if ((object.ReferenceEquals(this.DOBField, value) != true)) {
                    this.DOBField = value;
                    this.RaisePropertyChanged("DOB");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailID {
            get {
                return this.EmailIDField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailIDField, value) != true)) {
                    this.EmailIDField = value;
                    this.RaisePropertyChanged("EmailID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullAddress {
            get {
                return this.FullAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.FullAddressField, value) != true)) {
                    this.FullAddressField = value;
                    this.RaisePropertyChanged("FullAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MemberID {
            get {
                return this.MemberIDField;
            }
            set {
                if ((object.ReferenceEquals(this.MemberIDField, value) != true)) {
                    this.MemberIDField = value;
                    this.RaisePropertyChanged("MemberID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pincode {
            get {
                return this.PincodeField;
            }
            set {
                if ((object.ReferenceEquals(this.PincodeField, value) != true)) {
                    this.PincodeField = value;
                    this.RaisePropertyChanged("Pincode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SignUpDetail", Namespace="http://schemas.datacontract.org/2004/07/Library_System_Web_portal_Service.Library" +
        "")]
    [System.SerializableAttribute()]
    public partial class SignUpDetail : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DOBField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MemberIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PincodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactNo {
            get {
                return this.ContactNoField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactNoField, value) != true)) {
                    this.ContactNoField = value;
                    this.RaisePropertyChanged("ContactNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DOB {
            get {
                return this.DOBField;
            }
            set {
                if ((object.ReferenceEquals(this.DOBField, value) != true)) {
                    this.DOBField = value;
                    this.RaisePropertyChanged("DOB");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailID {
            get {
                return this.EmailIDField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailIDField, value) != true)) {
                    this.EmailIDField = value;
                    this.RaisePropertyChanged("EmailID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullAddress {
            get {
                return this.FullAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.FullAddressField, value) != true)) {
                    this.FullAddressField = value;
                    this.RaisePropertyChanged("FullAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MemberID {
            get {
                return this.MemberIDField;
            }
            set {
                if ((object.ReferenceEquals(this.MemberIDField, value) != true)) {
                    this.MemberIDField = value;
                    this.RaisePropertyChanged("MemberID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pincode {
            get {
                return this.PincodeField;
            }
            set {
                if ((object.ReferenceEquals(this.PincodeField, value) != true)) {
                    this.PincodeField = value;
                    this.RaisePropertyChanged("Pincode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SignUpDetailLists", Namespace="http://schemas.datacontract.org/2004/07/Library_System_Web_portal_Service.Library" +
        "")]
    [System.SerializableAttribute()]
    public partial class SignUpDetailLists : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Library_System_Web_portal.LibraryService.SignUpDetail[] SignUpDetailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalRecordsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Library_System_Web_portal.LibraryService.SignUpDetail[] SignUpDetail {
            get {
                return this.SignUpDetailField;
            }
            set {
                if ((object.ReferenceEquals(this.SignUpDetailField, value) != true)) {
                    this.SignUpDetailField = value;
                    this.RaisePropertyChanged("SignUpDetail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalRecords {
            get {
                return this.TotalRecordsField;
            }
            set {
                if ((this.TotalRecordsField.Equals(value) != true)) {
                    this.TotalRecordsField = value;
                    this.RaisePropertyChanged("TotalRecords");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BasicFilter", Namespace="http://schemas.datacontract.org/2004/07/Library_System_Web_portal_Service.Library" +
        "")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Library_System_Web_portal.LibraryService.AuthorManage))]
    public partial class BasicFilter : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PageStartField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RecordsPerPageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AuthorID {
            get {
                return this.AuthorIDField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorIDField, value) != true)) {
                    this.AuthorIDField = value;
                    this.RaisePropertyChanged("AuthorID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PageStart {
            get {
                return this.PageStartField;
            }
            set {
                if ((this.PageStartField.Equals(value) != true)) {
                    this.PageStartField = value;
                    this.RaisePropertyChanged("PageStart");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RecordsPerPage {
            get {
                return this.RecordsPerPageField;
            }
            set {
                if ((this.RecordsPerPageField.Equals(value) != true)) {
                    this.RecordsPerPageField = value;
                    this.RaisePropertyChanged("RecordsPerPage");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthorManage", Namespace="http://schemas.datacontract.org/2004/07/Library_System_Web_portal_Service.Library" +
        "")]
    [System.SerializableAttribute()]
    public partial class AuthorManage : Library_System_Web_portal.LibraryService.BasicFilter {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Library_System_Web_portal.LibraryService.AuthorDetails[] AuthorDetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalRecordsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Library_System_Web_portal.LibraryService.AuthorDetails[] AuthorDetails {
            get {
                return this.AuthorDetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorDetailsField, value) != true)) {
                    this.AuthorDetailsField = value;
                    this.RaisePropertyChanged("AuthorDetails");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalRecords {
            get {
                return this.TotalRecordsField;
            }
            set {
                if ((this.TotalRecordsField.Equals(value) != true)) {
                    this.TotalRecordsField = value;
                    this.RaisePropertyChanged("TotalRecords");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthorDetails", Namespace="http://schemas.datacontract.org/2004/07/Library_System_Web_portal_Service.Library" +
        "")]
    [System.SerializableAttribute()]
    public partial class AuthorDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AuthorID {
            get {
                return this.AuthorIDField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorIDField, value) != true)) {
                    this.AuthorIDField = value;
                    this.RaisePropertyChanged("AuthorID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AuthorName {
            get {
                return this.AuthorNameField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorNameField, value) != true)) {
                    this.AuthorNameField = value;
                    this.RaisePropertyChanged("AuthorName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LibraryService.ILibraryService")]
    public interface ILibraryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/InsertUpdateUserDetails", ReplyAction="http://tempuri.org/ILibraryService/InsertUpdateUserDetailsResponse")]
        string InsertUpdateUserDetails(Library_System_Web_portal.LibraryService.SignUpDetails signUp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/InsertUpdateUserDetails", ReplyAction="http://tempuri.org/ILibraryService/InsertUpdateUserDetailsResponse")]
        System.Threading.Tasks.Task<string> InsertUpdateUserDetailsAsync(Library_System_Web_portal.LibraryService.SignUpDetails signUp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/CheckUserExists", ReplyAction="http://tempuri.org/ILibraryService/CheckUserExistsResponse")]
        Library_System_Web_portal.LibraryService.SignUpDetailLists CheckUserExists(Library_System_Web_portal.LibraryService.SignUpDetail signUp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/CheckUserExists", ReplyAction="http://tempuri.org/ILibraryService/CheckUserExistsResponse")]
        System.Threading.Tasks.Task<Library_System_Web_portal.LibraryService.SignUpDetailLists> CheckUserExistsAsync(Library_System_Web_portal.LibraryService.SignUpDetail signUp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/CheckAuthor", ReplyAction="http://tempuri.org/ILibraryService/CheckAuthorResponse")]
        Library_System_Web_portal.LibraryService.AuthorManage CheckAuthor(string authorID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/CheckAuthor", ReplyAction="http://tempuri.org/ILibraryService/CheckAuthorResponse")]
        System.Threading.Tasks.Task<Library_System_Web_portal.LibraryService.AuthorManage> CheckAuthorAsync(string authorID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetAuthorDetails", ReplyAction="http://tempuri.org/ILibraryService/GetAuthorDetailsResponse")]
        Library_System_Web_portal.LibraryService.AuthorManage GetAuthorDetails(Library_System_Web_portal.LibraryService.BasicFilter basicFilter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetAuthorDetails", ReplyAction="http://tempuri.org/ILibraryService/GetAuthorDetailsResponse")]
        System.Threading.Tasks.Task<Library_System_Web_portal.LibraryService.AuthorManage> GetAuthorDetailsAsync(Library_System_Web_portal.LibraryService.BasicFilter basicFilter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/InsertAuthor", ReplyAction="http://tempuri.org/ILibraryService/InsertAuthorResponse")]
        bool InsertAuthor(Library_System_Web_portal.LibraryService.AuthorDetails authorDetails);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/InsertAuthor", ReplyAction="http://tempuri.org/ILibraryService/InsertAuthorResponse")]
        System.Threading.Tasks.Task<bool> InsertAuthorAsync(Library_System_Web_portal.LibraryService.AuthorDetails authorDetails);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/UpdateAuthor", ReplyAction="http://tempuri.org/ILibraryService/UpdateAuthorResponse")]
        bool UpdateAuthor(Library_System_Web_portal.LibraryService.AuthorDetails authorDetails);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/UpdateAuthor", ReplyAction="http://tempuri.org/ILibraryService/UpdateAuthorResponse")]
        System.Threading.Tasks.Task<bool> UpdateAuthorAsync(Library_System_Web_portal.LibraryService.AuthorDetails authorDetails);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/DeleteAuthor", ReplyAction="http://tempuri.org/ILibraryService/DeleteAuthorResponse")]
        bool DeleteAuthor(string authorID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/DeleteAuthor", ReplyAction="http://tempuri.org/ILibraryService/DeleteAuthorResponse")]
        System.Threading.Tasks.Task<bool> DeleteAuthorAsync(string authorID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILibraryServiceChannel : Library_System_Web_portal.LibraryService.ILibraryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LibraryServiceClient : System.ServiceModel.ClientBase<Library_System_Web_portal.LibraryService.ILibraryService>, Library_System_Web_portal.LibraryService.ILibraryService {
        
        public LibraryServiceClient() {
        }
        
        public LibraryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LibraryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string InsertUpdateUserDetails(Library_System_Web_portal.LibraryService.SignUpDetails signUp) {
            return base.Channel.InsertUpdateUserDetails(signUp);
        }
        
        public System.Threading.Tasks.Task<string> InsertUpdateUserDetailsAsync(Library_System_Web_portal.LibraryService.SignUpDetails signUp) {
            return base.Channel.InsertUpdateUserDetailsAsync(signUp);
        }
        
        public Library_System_Web_portal.LibraryService.SignUpDetailLists CheckUserExists(Library_System_Web_portal.LibraryService.SignUpDetail signUp) {
            return base.Channel.CheckUserExists(signUp);
        }
        
        public System.Threading.Tasks.Task<Library_System_Web_portal.LibraryService.SignUpDetailLists> CheckUserExistsAsync(Library_System_Web_portal.LibraryService.SignUpDetail signUp) {
            return base.Channel.CheckUserExistsAsync(signUp);
        }
        
        public Library_System_Web_portal.LibraryService.AuthorManage CheckAuthor(string authorID) {
            return base.Channel.CheckAuthor(authorID);
        }
        
        public System.Threading.Tasks.Task<Library_System_Web_portal.LibraryService.AuthorManage> CheckAuthorAsync(string authorID) {
            return base.Channel.CheckAuthorAsync(authorID);
        }
        
        public Library_System_Web_portal.LibraryService.AuthorManage GetAuthorDetails(Library_System_Web_portal.LibraryService.BasicFilter basicFilter) {
            return base.Channel.GetAuthorDetails(basicFilter);
        }
        
        public System.Threading.Tasks.Task<Library_System_Web_portal.LibraryService.AuthorManage> GetAuthorDetailsAsync(Library_System_Web_portal.LibraryService.BasicFilter basicFilter) {
            return base.Channel.GetAuthorDetailsAsync(basicFilter);
        }
        
        public bool InsertAuthor(Library_System_Web_portal.LibraryService.AuthorDetails authorDetails) {
            return base.Channel.InsertAuthor(authorDetails);
        }
        
        public System.Threading.Tasks.Task<bool> InsertAuthorAsync(Library_System_Web_portal.LibraryService.AuthorDetails authorDetails) {
            return base.Channel.InsertAuthorAsync(authorDetails);
        }
        
        public bool UpdateAuthor(Library_System_Web_portal.LibraryService.AuthorDetails authorDetails) {
            return base.Channel.UpdateAuthor(authorDetails);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAuthorAsync(Library_System_Web_portal.LibraryService.AuthorDetails authorDetails) {
            return base.Channel.UpdateAuthorAsync(authorDetails);
        }
        
        public bool DeleteAuthor(string authorID) {
            return base.Channel.DeleteAuthor(authorID);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAuthorAsync(string authorID) {
            return base.Channel.DeleteAuthorAsync(authorID);
        }
    }
}
