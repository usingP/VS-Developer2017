﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chinook.UI.WebFrom.MantenimientoServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/Chinook.Service.WCF")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Artist", Namespace="http://schemas.datacontract.org/2004/07/Chinook.DataAccess.Repository")]
    [System.SerializableAttribute()]
    public partial class Artist : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ArtistIdField;
        
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
        public int ArtistId {
            get {
                return this.ArtistIdField;
            }
            set {
                if ((this.ArtistIdField.Equals(value) != true)) {
                    this.ArtistIdField = value;
                    this.RaisePropertyChanged("ArtistId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MantenimientoServices.IMaintenanceServices")]
    public interface IMaintenanceServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaintenanceServices/GetData", ReplyAction="http://tempuri.org/IMaintenanceServices/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaintenanceServices/GetData", ReplyAction="http://tempuri.org/IMaintenanceServices/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaintenanceServices/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IMaintenanceServices/GetDataUsingDataContractResponse")]
        Chinook.UI.WebFrom.MantenimientoServices.CompositeType GetDataUsingDataContract(Chinook.UI.WebFrom.MantenimientoServices.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaintenanceServices/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IMaintenanceServices/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Chinook.UI.WebFrom.MantenimientoServices.CompositeType> GetDataUsingDataContractAsync(Chinook.UI.WebFrom.MantenimientoServices.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaintenanceServices/GetArtistByName", ReplyAction="http://tempuri.org/IMaintenanceServices/GetArtistByNameResponse")]
        Chinook.UI.WebFrom.MantenimientoServices.Artist[] GetArtistByName(string artistName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaintenanceServices/GetArtistByName", ReplyAction="http://tempuri.org/IMaintenanceServices/GetArtistByNameResponse")]
        System.Threading.Tasks.Task<Chinook.UI.WebFrom.MantenimientoServices.Artist[]> GetArtistByNameAsync(string artistName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMaintenanceServicesChannel : Chinook.UI.WebFrom.MantenimientoServices.IMaintenanceServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MaintenanceServicesClient : System.ServiceModel.ClientBase<Chinook.UI.WebFrom.MantenimientoServices.IMaintenanceServices>, Chinook.UI.WebFrom.MantenimientoServices.IMaintenanceServices {
        
        public MaintenanceServicesClient() {
        }
        
        public MaintenanceServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MaintenanceServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MaintenanceServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MaintenanceServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public Chinook.UI.WebFrom.MantenimientoServices.CompositeType GetDataUsingDataContract(Chinook.UI.WebFrom.MantenimientoServices.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Chinook.UI.WebFrom.MantenimientoServices.CompositeType> GetDataUsingDataContractAsync(Chinook.UI.WebFrom.MantenimientoServices.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public Chinook.UI.WebFrom.MantenimientoServices.Artist[] GetArtistByName(string artistName) {
            return base.Channel.GetArtistByName(artistName);
        }
        
        public System.Threading.Tasks.Task<Chinook.UI.WebFrom.MantenimientoServices.Artist[]> GetArtistByNameAsync(string artistName) {
            return base.Channel.GetArtistByNameAsync(artistName);
        }
    }
}
