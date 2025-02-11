﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumindoServico.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/WCF_cadastro_de_usuarios")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CpfField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
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
        public string Cpf {
            get {
                return this.CpfField;
            }
            set {
                if ((object.ReferenceEquals(this.CpfField, value) != true)) {
                    this.CpfField = value;
                    this.RaisePropertyChanged("Cpf");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IClienteService")]
    public interface IClienteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Add", ReplyAction="http://tempuri.org/IClienteService/AddResponse")]
        void Add(ConsumindoServico.ServiceReference1.Cliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Add", ReplyAction="http://tempuri.org/IClienteService/AddResponse")]
        System.Threading.Tasks.Task AddAsync(ConsumindoServico.ServiceReference1.Cliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Buscar", ReplyAction="http://tempuri.org/IClienteService/BuscarResponse")]
        ConsumindoServico.ServiceReference1.Cliente Buscar(string nome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Buscar", ReplyAction="http://tempuri.org/IClienteService/BuscarResponse")]
        System.Threading.Tasks.Task<ConsumindoServico.ServiceReference1.Cliente> BuscarAsync(string nome);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClienteServiceChannel : ConsumindoServico.ServiceReference1.IClienteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClienteServiceClient : System.ServiceModel.ClientBase<ConsumindoServico.ServiceReference1.IClienteService>, ConsumindoServico.ServiceReference1.IClienteService {
        
        public ClienteServiceClient() {
        }
        
        public ClienteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Add(ConsumindoServico.ServiceReference1.Cliente c) {
            base.Channel.Add(c);
        }
        
        public System.Threading.Tasks.Task AddAsync(ConsumindoServico.ServiceReference1.Cliente c) {
            return base.Channel.AddAsync(c);
        }
        
        public ConsumindoServico.ServiceReference1.Cliente Buscar(string nome) {
            return base.Channel.Buscar(nome);
        }
        
        public System.Threading.Tasks.Task<ConsumindoServico.ServiceReference1.Cliente> BuscarAsync(string nome) {
            return base.Channel.BuscarAsync(nome);
        }
    }
}
