﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_Application_Project.ProductInventoryService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/Web_Service_Project")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AbstractField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateAddedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ThumbnailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public string Abstract {
            get {
                return this.AbstractField;
            }
            set {
                if ((object.ReferenceEquals(this.AbstractField, value) != true)) {
                    this.AbstractField = value;
                    this.RaisePropertyChanged("Abstract");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateAdded {
            get {
                return this.DateAddedField;
            }
            set {
                if ((this.DateAddedField.Equals(value) != true)) {
                    this.DateAddedField = value;
                    this.RaisePropertyChanged("DateAdded");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((this.ProductIdField.Equals(value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Thumbnail {
            get {
                return this.ThumbnailField;
            }
            set {
                if ((object.ReferenceEquals(this.ThumbnailField, value) != true)) {
                    this.ThumbnailField = value;
                    this.RaisePropertyChanged("Thumbnail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductInventoryService.IInventoryService")]
    public interface IInventoryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetProduct", ReplyAction="http://tempuri.org/IInventoryService/GetProductResponse")]
        WPF_Application_Project.ProductInventoryService.Product GetProduct(int productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetProduct", ReplyAction="http://tempuri.org/IInventoryService/GetProductResponse")]
        System.Threading.Tasks.Task<WPF_Application_Project.ProductInventoryService.Product> GetProductAsync(int productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetAllProducts", ReplyAction="http://tempuri.org/IInventoryService/GetAllProductsResponse")]
        WPF_Application_Project.ProductInventoryService.Product[] GetAllProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetAllProducts", ReplyAction="http://tempuri.org/IInventoryService/GetAllProductsResponse")]
        System.Threading.Tasks.Task<WPF_Application_Project.ProductInventoryService.Product[]> GetAllProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/AddProduct", ReplyAction="http://tempuri.org/IInventoryService/AddProductResponse")]
        bool AddProduct(WPF_Application_Project.ProductInventoryService.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/AddProduct", ReplyAction="http://tempuri.org/IInventoryService/AddProductResponse")]
        System.Threading.Tasks.Task<bool> AddProductAsync(WPF_Application_Project.ProductInventoryService.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/RemoveProduct", ReplyAction="http://tempuri.org/IInventoryService/RemoveProductResponse")]
        bool RemoveProduct(int productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/RemoveProduct", ReplyAction="http://tempuri.org/IInventoryService/RemoveProductResponse")]
        System.Threading.Tasks.Task<bool> RemoveProductAsync(int productId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInventoryServiceChannel : WPF_Application_Project.ProductInventoryService.IInventoryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InventoryServiceClient : System.ServiceModel.ClientBase<WPF_Application_Project.ProductInventoryService.IInventoryService>, WPF_Application_Project.ProductInventoryService.IInventoryService {
        
        public InventoryServiceClient() {
        }
        
        public InventoryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InventoryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InventoryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InventoryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WPF_Application_Project.ProductInventoryService.Product GetProduct(int productId) {
            return base.Channel.GetProduct(productId);
        }
        
        public System.Threading.Tasks.Task<WPF_Application_Project.ProductInventoryService.Product> GetProductAsync(int productId) {
            return base.Channel.GetProductAsync(productId);
        }
        
        public WPF_Application_Project.ProductInventoryService.Product[] GetAllProducts() {
            return base.Channel.GetAllProducts();
        }
        
        public System.Threading.Tasks.Task<WPF_Application_Project.ProductInventoryService.Product[]> GetAllProductsAsync() {
            return base.Channel.GetAllProductsAsync();
        }
        
        public bool AddProduct(WPF_Application_Project.ProductInventoryService.Product product) {
            return base.Channel.AddProduct(product);
        }
        
        public System.Threading.Tasks.Task<bool> AddProductAsync(WPF_Application_Project.ProductInventoryService.Product product) {
            return base.Channel.AddProductAsync(product);
        }
        
        public bool RemoveProduct(int productId) {
            return base.Channel.RemoveProduct(productId);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveProductAsync(int productId) {
            return base.Channel.RemoveProductAsync(productId);
        }
    }
}