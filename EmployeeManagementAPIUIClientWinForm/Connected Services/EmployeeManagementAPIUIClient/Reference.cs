﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClientInfo", Namespace="http://schemas.datacontract.org/2004/07/ASM.EmployeeManagement.WebAPIUI.Model.Com" +
        "mon")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.ResultBase))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.ResGetUserInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.ResGetUserInfoList))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.AuthenticationInfo))]
    public partial class ClientInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ResultBase", Namespace="http://schemas.datacontract.org/2004/07/ASM.EmployeeManagement.WebAPIUI.Model.Com" +
        "mon.Response")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.ResGetUserInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.ResGetUserInfoList))]
    public partial class ResultBase : ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.ClientInfo {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.Result ResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.Result Result {
            get {
                return this.ResultField;
            }
            set {
                if ((object.ReferenceEquals(this.ResultField, value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResGetUserInfo", Namespace="http://schemas.datacontract.org/2004/07/ASM.EmployeeManagement.WebAPIUI.Model.Get" +
        "UserInfo.Response")]
    [System.SerializableAttribute()]
    public partial class ResGetUserInfo : ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.ResultBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.UserDetailInfo UserDetailInfoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.UserDetailInfo UserDetailInfo {
            get {
                return this.UserDetailInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.UserDetailInfoField, value) != true)) {
                    this.UserDetailInfoField = value;
                    this.RaisePropertyChanged("UserDetailInfo");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResGetUserInfoList", Namespace="http://schemas.datacontract.org/2004/07/ASM.EmployeeManagement.WebAPIUI.Model.Get" +
        "UserInfoList.Response")]
    [System.SerializableAttribute()]
    public partial class ResGetUserInfoList : ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.ResultBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.UserInfoList[] UserDetailInfoListField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.UserInfoList[] UserDetailInfoList {
            get {
                return this.UserDetailInfoListField;
            }
            set {
                if ((object.ReferenceEquals(this.UserDetailInfoListField, value) != true)) {
                    this.UserDetailInfoListField = value;
                    this.RaisePropertyChanged("UserDetailInfoList");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthenticationInfo", Namespace="http://schemas.datacontract.org/2004/07/ASM.EmployeeManagement.WebAPIUI.Model.Com" +
        "mon.Request")]
    [System.SerializableAttribute()]
    public partial class AuthenticationInfo : ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.ClientInfo {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LoginID {
            get {
                return this.LoginIDField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginIDField, value) != true)) {
                    this.LoginIDField = value;
                    this.RaisePropertyChanged("LoginID");
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Result", Namespace="http://schemas.datacontract.org/2004/07/ASM.EmployeeManagement.WebAPIUI.Model.Com" +
        "mon.Response")]
    [System.SerializableAttribute()]
    public partial class Result : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResultCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorDetailField;
        
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
        public string ResultCode {
            get {
                return this.ResultCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ResultCodeField, value) != true)) {
                    this.ResultCodeField = value;
                    this.RaisePropertyChanged("ResultCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public string ErrorDetail {
            get {
                return this.ErrorDetailField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorDetailField, value) != true)) {
                    this.ErrorDetailField = value;
                    this.RaisePropertyChanged("ErrorDetail");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UserDetailInfo", Namespace="http://schemas.datacontract.org/2004/07/ASM.EmployeeManagement.WebAPIUI.Model.Get" +
        "UserInfo.Response")]
    [System.SerializableAttribute()]
    public partial class UserDetailInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JobStartDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool MaritalStatusField;
        
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
        public string UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIDField, value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string DepartmentName {
            get {
                return this.DepartmentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentNameField, value) != true)) {
                    this.DepartmentNameField = value;
                    this.RaisePropertyChanged("DepartmentName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public short Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((this.GenderField.Equals(value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string DateOfBirth {
            get {
                return this.DateOfBirthField;
            }
            set {
                if ((object.ReferenceEquals(this.DateOfBirthField, value) != true)) {
                    this.DateOfBirthField = value;
                    this.RaisePropertyChanged("DateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public string PhoneNo {
            get {
                return this.PhoneNoField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNoField, value) != true)) {
                    this.PhoneNoField = value;
                    this.RaisePropertyChanged("PhoneNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=8)]
        public string JobStartDate {
            get {
                return this.JobStartDateField;
            }
            set {
                if ((object.ReferenceEquals(this.JobStartDateField, value) != true)) {
                    this.JobStartDateField = value;
                    this.RaisePropertyChanged("JobStartDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=9)]
        public bool MaritalStatus {
            get {
                return this.MaritalStatusField;
            }
            set {
                if ((this.MaritalStatusField.Equals(value) != true)) {
                    this.MaritalStatusField = value;
                    this.RaisePropertyChanged("MaritalStatus");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UserInfoList", Namespace="http://schemas.datacontract.org/2004/07/ASM.EmployeeManagement.DataAccess.Model.W" +
        "ebAPI.GetUserInfoList")]
    [System.SerializableAttribute()]
    public partial class UserInfoList : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> JobStartDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte MaritalStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateOfBirth {
            get {
                return this.DateOfBirthField;
            }
            set {
                if ((this.DateOfBirthField.Equals(value) != true)) {
                    this.DateOfBirthField = value;
                    this.RaisePropertyChanged("DateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DepartmentName {
            get {
                return this.DepartmentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentNameField, value) != true)) {
                    this.DepartmentNameField = value;
                    this.RaisePropertyChanged("DepartmentName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((this.GenderField.Equals(value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> JobStartDate {
            get {
                return this.JobStartDateField;
            }
            set {
                if ((this.JobStartDateField.Equals(value) != true)) {
                    this.JobStartDateField = value;
                    this.RaisePropertyChanged("JobStartDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte MaritalStatus {
            get {
                return this.MaritalStatusField;
            }
            set {
                if ((this.MaritalStatusField.Equals(value) != true)) {
                    this.MaritalStatusField = value;
                    this.RaisePropertyChanged("MaritalStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNo {
            get {
                return this.PhoneNoField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNoField, value) != true)) {
                    this.PhoneNoField = value;
                    this.RaisePropertyChanged("PhoneNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIDField, value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Paging", Namespace="http://schemas.datacontract.org/2004/07/ASM.EmployeeManagement.DataAccess.Common." +
        "Paging")]
    [System.SerializableAttribute()]
    public partial class Paging : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> SortKeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> SortOrderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StartIndexField;
        
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
        public int Num {
            get {
                return this.NumField;
            }
            set {
                if ((this.NumField.Equals(value) != true)) {
                    this.NumField = value;
                    this.RaisePropertyChanged("Num");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> SortKey {
            get {
                return this.SortKeyField;
            }
            set {
                if ((this.SortKeyField.Equals(value) != true)) {
                    this.SortKeyField = value;
                    this.RaisePropertyChanged("SortKey");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> SortOrder {
            get {
                return this.SortOrderField;
            }
            set {
                if ((this.SortOrderField.Equals(value) != true)) {
                    this.SortOrderField = value;
                    this.RaisePropertyChanged("SortOrder");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StartIndex {
            get {
                return this.StartIndexField;
            }
            set {
                if ((this.StartIndexField.Equals(value) != true)) {
                    this.StartIndexField = value;
                    this.RaisePropertyChanged("StartIndex");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UserFilterInfo", Namespace="http://schemas.datacontract.org/2004/07/ASM.EmployeeManagement.DataAccess.Common." +
        "FilterInfo")]
    [System.SerializableAttribute()]
    public partial class UserFilterInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsExactMatchSearchField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserIDField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsExactMatchSearch {
            get {
                return this.IsExactMatchSearchField;
            }
            set {
                if ((this.IsExactMatchSearchField.Equals(value) != true)) {
                    this.IsExactMatchSearchField = value;
                    this.RaisePropertyChanged("IsExactMatchSearch");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIDField, value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org/V1.0.0", ConfigurationName="EmployeeManagementAPIUIClient.IEmployeeManagementWebAPIUIService")]
    public interface IEmployeeManagementWebAPIUIService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/V1.0.0/IEmployeeManagementWebAPIUIService/GetUserInfo", ReplyAction="http://tempuri.org/V1.0.0/IEmployeeManagementWebAPIUIService/GetUserInfoResponse")]
        ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.ResGetUserInfo GetUserInfo(ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.AuthenticationInfo authInfo, string userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/V1.0.0/IEmployeeManagementWebAPIUIService/GetUserInfo", ReplyAction="http://tempuri.org/V1.0.0/IEmployeeManagementWebAPIUIService/GetUserInfoResponse")]
        System.Threading.Tasks.Task<ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.ResGetUserInfo> GetUserInfoAsync(ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.AuthenticationInfo authInfo, string userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/V1.0.0/IEmployeeManagementWebAPIUIService/GetUserInfoList", ReplyAction="http://tempuri.org/V1.0.0/IEmployeeManagementWebAPIUIService/GetUserInfoListRespo" +
            "nse")]
        ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.ResGetUserInfoList GetUserInfoList(ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.AuthenticationInfo authInfo, ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.Paging iPagingPara, ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.UserFilterInfo objFilterInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/V1.0.0/IEmployeeManagementWebAPIUIService/GetUserInfoList", ReplyAction="http://tempuri.org/V1.0.0/IEmployeeManagementWebAPIUIService/GetUserInfoListRespo" +
            "nse")]
        System.Threading.Tasks.Task<ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.ResGetUserInfoList> GetUserInfoListAsync(ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.AuthenticationInfo authInfo, ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.Paging iPagingPara, ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.UserFilterInfo objFilterInfo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeManagementWebAPIUIServiceChannel : ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.IEmployeeManagementWebAPIUIService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeManagementWebAPIUIServiceClient : System.ServiceModel.ClientBase<ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.IEmployeeManagementWebAPIUIService>, ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.IEmployeeManagementWebAPIUIService {
        
        public EmployeeManagementWebAPIUIServiceClient() {
        }
        
        public EmployeeManagementWebAPIUIServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeManagementWebAPIUIServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeManagementWebAPIUIServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeManagementWebAPIUIServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.ResGetUserInfo GetUserInfo(ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.AuthenticationInfo authInfo, string userID) {
            return base.Channel.GetUserInfo(authInfo, userID);
        }
        
        public System.Threading.Tasks.Task<ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.ResGetUserInfo> GetUserInfoAsync(ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.AuthenticationInfo authInfo, string userID) {
            return base.Channel.GetUserInfoAsync(authInfo, userID);
        }
        
        public ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.ResGetUserInfoList GetUserInfoList(ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.AuthenticationInfo authInfo, ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.Paging iPagingPara, ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.UserFilterInfo objFilterInfo) {
            return base.Channel.GetUserInfoList(authInfo, iPagingPara, objFilterInfo);
        }
        
        public System.Threading.Tasks.Task<ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.ResGetUserInfoList> GetUserInfoListAsync(ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.AuthenticationInfo authInfo, ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.Paging iPagingPara, ASM.EmployeeManagementAPIUIClientWinForm.EmployeeManagementAPIUIClient.UserFilterInfo objFilterInfo) {
            return base.Channel.GetUserInfoListAsync(authInfo, iPagingPara, objFilterInfo);
        }
    }
}
