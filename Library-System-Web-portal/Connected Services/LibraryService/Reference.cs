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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LibraryService.ILibraryService")]
    public interface ILibraryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/InsertUpdateUserDetails", ReplyAction="http://tempuri.org/ILibraryService/InsertUpdateUserDetailsResponse")]
        string InsertUpdateUserDetails(Library_System_Web_portal.LibraryService.SignUpDetails signUp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/InsertUpdateUserDetails", ReplyAction="http://tempuri.org/ILibraryService/InsertUpdateUserDetailsResponse")]
        System.Threading.Tasks.Task<string> InsertUpdateUserDetailsAsync(Library_System_Web_portal.LibraryService.SignUpDetails signUp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/CheckUserExists", ReplyAction="http://tempuri.org/ILibraryService/CheckUserExistsResponse")]
        string CheckUserExists(Library_System_Web_portal.LibraryService.SignUpDetails signUp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/CheckUserExists", ReplyAction="http://tempuri.org/ILibraryService/CheckUserExistsResponse")]
        System.Threading.Tasks.Task<string> CheckUserExistsAsync(Library_System_Web_portal.LibraryService.SignUpDetails signUp);
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
        
        public string CheckUserExists(Library_System_Web_portal.LibraryService.SignUpDetails signUp) {
            return base.Channel.CheckUserExists(signUp);
        }
        
        public System.Threading.Tasks.Task<string> CheckUserExistsAsync(Library_System_Web_portal.LibraryService.SignUpDetails signUp) {
            return base.Channel.CheckUserExistsAsync(signUp);
        }
    }
}
