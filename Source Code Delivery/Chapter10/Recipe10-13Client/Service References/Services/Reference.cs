﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.21006.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apress.VisualCSharpRecipes.Chapter10.Services {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/Apress.VisualCSharpRecipes.Chapter10")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="Apress.VisualCSharpRecipes.Chapter10", ConfigurationName="Services.IEmployeeService")]
    public interface IEmployeeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="Apress.VisualCSharpRecipes.Chapter10/IEmployeeService/CreateEmployee", ReplyAction="Apress.VisualCSharpRecipes.Chapter10/IEmployeeService/CreateEmployeeResponse")]
        Apress.VisualCSharpRecipes.Chapter10.Services.Employee CreateEmployee(Apress.VisualCSharpRecipes.Chapter10.Services.Employee newEmployee);
        
        [System.ServiceModel.OperationContractAttribute(Action="Apress.VisualCSharpRecipes.Chapter10/IEmployeeService/DeleteEmployee", ReplyAction="Apress.VisualCSharpRecipes.Chapter10/IEmployeeService/DeleteEmployeeResponse")]
        bool DeleteEmployee(int employeeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="Apress.VisualCSharpRecipes.Chapter10/IEmployeeService/GetEmployeeById", ReplyAction="Apress.VisualCSharpRecipes.Chapter10/IEmployeeService/GetEmployeeByIdResponse")]
        Apress.VisualCSharpRecipes.Chapter10.Services.Employee GetEmployeeById(int employeeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="Apress.VisualCSharpRecipes.Chapter10/IEmployeeService/GetEmployeeByName", ReplyAction="Apress.VisualCSharpRecipes.Chapter10/IEmployeeService/GetEmployeeByNameResponse")]
        Apress.VisualCSharpRecipes.Chapter10.Services.Employee GetEmployeeByName(string employeeName);
        
        [System.ServiceModel.OperationContractAttribute(Action="Apress.VisualCSharpRecipes.Chapter10/IEmployeeService/UpdateEmployee", ReplyAction="Apress.VisualCSharpRecipes.Chapter10/IEmployeeService/UpdateEmployeeResponse")]
        Apress.VisualCSharpRecipes.Chapter10.Services.Employee UpdateEmployee(Apress.VisualCSharpRecipes.Chapter10.Services.Employee updatedEmployee);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeServiceChannel : Apress.VisualCSharpRecipes.Chapter10.Services.IEmployeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<Apress.VisualCSharpRecipes.Chapter10.Services.IEmployeeService>, Apress.VisualCSharpRecipes.Chapter10.Services.IEmployeeService {
        
        public EmployeeServiceClient() {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Apress.VisualCSharpRecipes.Chapter10.Services.Employee CreateEmployee(Apress.VisualCSharpRecipes.Chapter10.Services.Employee newEmployee) {
            return base.Channel.CreateEmployee(newEmployee);
        }
        
        public bool DeleteEmployee(int employeeId) {
            return base.Channel.DeleteEmployee(employeeId);
        }
        
        public Apress.VisualCSharpRecipes.Chapter10.Services.Employee GetEmployeeById(int employeeId) {
            return base.Channel.GetEmployeeById(employeeId);
        }
        
        public Apress.VisualCSharpRecipes.Chapter10.Services.Employee GetEmployeeByName(string employeeName) {
            return base.Channel.GetEmployeeByName(employeeName);
        }
        
        public Apress.VisualCSharpRecipes.Chapter10.Services.Employee UpdateEmployee(Apress.VisualCSharpRecipes.Chapter10.Services.Employee updatedEmployee) {
            return base.Channel.UpdateEmployee(updatedEmployee);
        }
    }
}
