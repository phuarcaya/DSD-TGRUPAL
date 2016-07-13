﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WS_ProduccionTest.MovWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Movimiento", Namespace="http://schemas.datacontract.org/2004/07/WS_Produccion")]
    [System.SerializableAttribute()]
    public partial class Movimiento : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> FechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> FechaModificacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> FechaRegistroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> IdAlmacenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> IdOrdenTrabajoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoMovimientoField;
        
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
        public System.Nullable<System.DateTime> Fecha {
            get {
                return this.FechaField;
            }
            set {
                if ((this.FechaField.Equals(value) != true)) {
                    this.FechaField = value;
                    this.RaisePropertyChanged("Fecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> FechaModificacion {
            get {
                return this.FechaModificacionField;
            }
            set {
                if ((this.FechaModificacionField.Equals(value) != true)) {
                    this.FechaModificacionField = value;
                    this.RaisePropertyChanged("FechaModificacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> FechaRegistro {
            get {
                return this.FechaRegistroField;
            }
            set {
                if ((this.FechaRegistroField.Equals(value) != true)) {
                    this.FechaRegistroField = value;
                    this.RaisePropertyChanged("FechaRegistro");
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
        public System.Nullable<int> IdAlmacen {
            get {
                return this.IdAlmacenField;
            }
            set {
                if ((this.IdAlmacenField.Equals(value) != true)) {
                    this.IdAlmacenField = value;
                    this.RaisePropertyChanged("IdAlmacen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> IdOrdenTrabajo {
            get {
                return this.IdOrdenTrabajoField;
            }
            set {
                if ((this.IdOrdenTrabajoField.Equals(value) != true)) {
                    this.IdOrdenTrabajoField = value;
                    this.RaisePropertyChanged("IdOrdenTrabajo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoMovimiento {
            get {
                return this.TipoMovimientoField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoMovimientoField, value) != true)) {
                    this.TipoMovimientoField = value;
                    this.RaisePropertyChanged("TipoMovimiento");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MovWS.IMovimientos")]
    public interface IMovimientos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovimientos/crearMov", ReplyAction="http://tempuri.org/IMovimientos/crearMovResponse")]
        WS_ProduccionTest.MovWS.Movimiento crearMov(WS_ProduccionTest.MovWS.Movimiento movCrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovimientos/crearMov", ReplyAction="http://tempuri.org/IMovimientos/crearMovResponse")]
        System.Threading.Tasks.Task<WS_ProduccionTest.MovWS.Movimiento> crearMovAsync(WS_ProduccionTest.MovWS.Movimiento movCrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovimientos/obtenerMov", ReplyAction="http://tempuri.org/IMovimientos/obtenerMovResponse")]
        WS_ProduccionTest.MovWS.Movimiento obtenerMov(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovimientos/obtenerMov", ReplyAction="http://tempuri.org/IMovimientos/obtenerMovResponse")]
        System.Threading.Tasks.Task<WS_ProduccionTest.MovWS.Movimiento> obtenerMovAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovimientos/modificarMov", ReplyAction="http://tempuri.org/IMovimientos/modificarMovResponse")]
        WS_ProduccionTest.MovWS.Movimiento modificarMov(WS_ProduccionTest.MovWS.Movimiento MovModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovimientos/modificarMov", ReplyAction="http://tempuri.org/IMovimientos/modificarMovResponse")]
        System.Threading.Tasks.Task<WS_ProduccionTest.MovWS.Movimiento> modificarMovAsync(WS_ProduccionTest.MovWS.Movimiento MovModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovimientos/eliminarMov", ReplyAction="http://tempuri.org/IMovimientos/eliminarMovResponse")]
        void eliminarMov(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovimientos/eliminarMov", ReplyAction="http://tempuri.org/IMovimientos/eliminarMovResponse")]
        System.Threading.Tasks.Task eliminarMovAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovimientos/listarMov", ReplyAction="http://tempuri.org/IMovimientos/listarMovResponse")]
        WS_ProduccionTest.MovWS.Movimiento[] listarMov();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovimientos/listarMov", ReplyAction="http://tempuri.org/IMovimientos/listarMovResponse")]
        System.Threading.Tasks.Task<WS_ProduccionTest.MovWS.Movimiento[]> listarMovAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMovimientosChannel : WS_ProduccionTest.MovWS.IMovimientos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MovimientosClient : System.ServiceModel.ClientBase<WS_ProduccionTest.MovWS.IMovimientos>, WS_ProduccionTest.MovWS.IMovimientos {
        
        public MovimientosClient() {
        }
        
        public MovimientosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MovimientosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MovimientosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MovimientosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WS_ProduccionTest.MovWS.Movimiento crearMov(WS_ProduccionTest.MovWS.Movimiento movCrear) {
            return base.Channel.crearMov(movCrear);
        }
        
        public System.Threading.Tasks.Task<WS_ProduccionTest.MovWS.Movimiento> crearMovAsync(WS_ProduccionTest.MovWS.Movimiento movCrear) {
            return base.Channel.crearMovAsync(movCrear);
        }
        
        public WS_ProduccionTest.MovWS.Movimiento obtenerMov(int id) {
            return base.Channel.obtenerMov(id);
        }
        
        public System.Threading.Tasks.Task<WS_ProduccionTest.MovWS.Movimiento> obtenerMovAsync(int id) {
            return base.Channel.obtenerMovAsync(id);
        }
        
        public WS_ProduccionTest.MovWS.Movimiento modificarMov(WS_ProduccionTest.MovWS.Movimiento MovModificar) {
            return base.Channel.modificarMov(MovModificar);
        }
        
        public System.Threading.Tasks.Task<WS_ProduccionTest.MovWS.Movimiento> modificarMovAsync(WS_ProduccionTest.MovWS.Movimiento MovModificar) {
            return base.Channel.modificarMovAsync(MovModificar);
        }
        
        public void eliminarMov(int id) {
            base.Channel.eliminarMov(id);
        }
        
        public System.Threading.Tasks.Task eliminarMovAsync(int id) {
            return base.Channel.eliminarMovAsync(id);
        }
        
        public WS_ProduccionTest.MovWS.Movimiento[] listarMov() {
            return base.Channel.listarMov();
        }
        
        public System.Threading.Tasks.Task<WS_ProduccionTest.MovWS.Movimiento[]> listarMovAsync() {
            return base.Channel.listarMovAsync();
        }
    }
}
