﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SyncClient.SchemaService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Range", Namespace="http://schemas.datacontract.org/2004/07/Services")]
    [System.SerializableAttribute()]
    public partial struct Range : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MinField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Max {
            get {
                return this.MaxField;
            }
            set {
                if ((this.MaxField.Equals(value) != true)) {
                    this.MaxField = value;
                    this.RaisePropertyChanged("Max");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Min {
            get {
                return this.MinField;
            }
            set {
                if ((this.MinField.Equals(value) != true)) {
                    this.MinField = value;
                    this.RaisePropertyChanged("Min");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SchemaService.SchemaService")]
    public interface SchemaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SchemaService/GetSchemaVersion", ReplyAction="http://tempuri.org/SchemaService/GetSchemaVersionResponse")]
        byte GetSchemaVersion();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SchemaService/GetIdRange", ReplyAction="http://tempuri.org/SchemaService/GetIdRangeResponse")]
        SyncClient.SchemaService.Range GetIdRange(string machine);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SchemaServiceChannel : SyncClient.SchemaService.SchemaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SchemaServiceClient : System.ServiceModel.ClientBase<SyncClient.SchemaService.SchemaService>, SyncClient.SchemaService.SchemaService {
        
        public SchemaServiceClient() {
        }
        
        public SchemaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SchemaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SchemaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SchemaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public byte GetSchemaVersion() {
            return base.Channel.GetSchemaVersion();
        }
        
        public SyncClient.SchemaService.Range GetIdRange(string machine) {
            return base.Channel.GetIdRange(machine);
        }
    }
}
