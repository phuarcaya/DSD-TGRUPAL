﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prototipo1.WSOrdenesTrabajos {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSOrdenesTrabajos.IOrdenTrabajos")]
    public interface IOrdenTrabajos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenTrabajos/crearOrd", ReplyAction="http://tempuri.org/IOrdenTrabajos/crearOrdResponse")]
        WS_Produccion.OrdenTrabajo crearOrd(WS_Produccion.OrdenTrabajo ordCrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenTrabajos/crearOrd", ReplyAction="http://tempuri.org/IOrdenTrabajos/crearOrdResponse")]
        System.Threading.Tasks.Task<WS_Produccion.OrdenTrabajo> crearOrdAsync(WS_Produccion.OrdenTrabajo ordCrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenTrabajos/obtenerOrd", ReplyAction="http://tempuri.org/IOrdenTrabajos/obtenerOrdResponse")]
        WS_Produccion.OrdenTrabajo obtenerOrd(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenTrabajos/obtenerOrd", ReplyAction="http://tempuri.org/IOrdenTrabajos/obtenerOrdResponse")]
        System.Threading.Tasks.Task<WS_Produccion.OrdenTrabajo> obtenerOrdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenTrabajos/modificarOrd", ReplyAction="http://tempuri.org/IOrdenTrabajos/modificarOrdResponse")]
        WS_Produccion.OrdenTrabajo modificarOrd(WS_Produccion.OrdenTrabajo ordModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenTrabajos/modificarOrd", ReplyAction="http://tempuri.org/IOrdenTrabajos/modificarOrdResponse")]
        System.Threading.Tasks.Task<WS_Produccion.OrdenTrabajo> modificarOrdAsync(WS_Produccion.OrdenTrabajo ordModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenTrabajos/eliminarOrd", ReplyAction="http://tempuri.org/IOrdenTrabajos/eliminarOrdResponse")]
        void eliminarOrd(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenTrabajos/eliminarOrd", ReplyAction="http://tempuri.org/IOrdenTrabajos/eliminarOrdResponse")]
        System.Threading.Tasks.Task eliminarOrdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenTrabajos/listarOrd", ReplyAction="http://tempuri.org/IOrdenTrabajos/listarOrdResponse")]
        WS_Produccion.OrdenTrabajo[] listarOrd();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenTrabajos/listarOrd", ReplyAction="http://tempuri.org/IOrdenTrabajos/listarOrdResponse")]
        System.Threading.Tasks.Task<WS_Produccion.OrdenTrabajo[]> listarOrdAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrdenTrabajosChannel : Prototipo1.WSOrdenesTrabajos.IOrdenTrabajos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrdenTrabajosClient : System.ServiceModel.ClientBase<Prototipo1.WSOrdenesTrabajos.IOrdenTrabajos>, Prototipo1.WSOrdenesTrabajos.IOrdenTrabajos {
        
        public OrdenTrabajosClient() {
        }
        
        public OrdenTrabajosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrdenTrabajosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrdenTrabajosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrdenTrabajosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WS_Produccion.OrdenTrabajo crearOrd(WS_Produccion.OrdenTrabajo ordCrear) {
            return base.Channel.crearOrd(ordCrear);
        }
        
        public System.Threading.Tasks.Task<WS_Produccion.OrdenTrabajo> crearOrdAsync(WS_Produccion.OrdenTrabajo ordCrear) {
            return base.Channel.crearOrdAsync(ordCrear);
        }
        
        public WS_Produccion.OrdenTrabajo obtenerOrd(int id) {
            return base.Channel.obtenerOrd(id);
        }
        
        public System.Threading.Tasks.Task<WS_Produccion.OrdenTrabajo> obtenerOrdAsync(int id) {
            return base.Channel.obtenerOrdAsync(id);
        }
        
        public WS_Produccion.OrdenTrabajo modificarOrd(WS_Produccion.OrdenTrabajo ordModificar) {
            return base.Channel.modificarOrd(ordModificar);
        }
        
        public System.Threading.Tasks.Task<WS_Produccion.OrdenTrabajo> modificarOrdAsync(WS_Produccion.OrdenTrabajo ordModificar) {
            return base.Channel.modificarOrdAsync(ordModificar);
        }
        
        public void eliminarOrd(int id) {
            base.Channel.eliminarOrd(id);
        }
        
        public System.Threading.Tasks.Task eliminarOrdAsync(int id) {
            return base.Channel.eliminarOrdAsync(id);
        }
        
        public WS_Produccion.OrdenTrabajo[] listarOrd() {
            return base.Channel.listarOrd();
        }
        
        public System.Threading.Tasks.Task<WS_Produccion.OrdenTrabajo[]> listarOrdAsync() {
            return base.Channel.listarOrdAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSOrdenesTrabajos.IOrdenTrabajoDetalle")]
    public interface IOrdenTrabajoDetalle {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenTrabajoDetalle/crearOrdDet", ReplyAction="http://tempuri.org/IOrdenTrabajoDetalle/crearOrdDetResponse")]
        WS_Produccion.OrdenTrabajoDetalle crearOrdDet(WS_Produccion.OrdenTrabajoDetalle ordDetCrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenTrabajoDetalle/crearOrdDet", ReplyAction="http://tempuri.org/IOrdenTrabajoDetalle/crearOrdDetResponse")]
        System.Threading.Tasks.Task<WS_Produccion.OrdenTrabajoDetalle> crearOrdDetAsync(WS_Produccion.OrdenTrabajoDetalle ordDetCrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenTrabajoDetalle/obtenerOrdDet", ReplyAction="http://tempuri.org/IOrdenTrabajoDetalle/obtenerOrdDetResponse")]
        WS_Produccion.OrdenTrabajoDetalle obtenerOrdDet(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenTrabajoDetalle/obtenerOrdDet", ReplyAction="http://tempuri.org/IOrdenTrabajoDetalle/obtenerOrdDetResponse")]
        System.Threading.Tasks.Task<WS_Produccion.OrdenTrabajoDetalle> obtenerOrdDetAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenTrabajoDetalle/modificarOrdDet", ReplyAction="http://tempuri.org/IOrdenTrabajoDetalle/modificarOrdDetResponse")]
        WS_Produccion.OrdenTrabajoDetalle modificarOrdDet(WS_Produccion.OrdenTrabajoDetalle ordDetModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenTrabajoDetalle/modificarOrdDet", ReplyAction="http://tempuri.org/IOrdenTrabajoDetalle/modificarOrdDetResponse")]
        System.Threading.Tasks.Task<WS_Produccion.OrdenTrabajoDetalle> modificarOrdDetAsync(WS_Produccion.OrdenTrabajoDetalle ordDetModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenTrabajoDetalle/eliminarOrdDet", ReplyAction="http://tempuri.org/IOrdenTrabajoDetalle/eliminarOrdDetResponse")]
        void eliminarOrdDet(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenTrabajoDetalle/eliminarOrdDet", ReplyAction="http://tempuri.org/IOrdenTrabajoDetalle/eliminarOrdDetResponse")]
        System.Threading.Tasks.Task eliminarOrdDetAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenTrabajoDetalle/listarOrdDet", ReplyAction="http://tempuri.org/IOrdenTrabajoDetalle/listarOrdDetResponse")]
        WS_Produccion.OrdenTrabajoDetalle[] listarOrdDet(int idOrdenTrabajo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenTrabajoDetalle/listarOrdDet", ReplyAction="http://tempuri.org/IOrdenTrabajoDetalle/listarOrdDetResponse")]
        System.Threading.Tasks.Task<WS_Produccion.OrdenTrabajoDetalle[]> listarOrdDetAsync(int idOrdenTrabajo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrdenTrabajoDetalleChannel : Prototipo1.WSOrdenesTrabajos.IOrdenTrabajoDetalle, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrdenTrabajoDetalleClient : System.ServiceModel.ClientBase<Prototipo1.WSOrdenesTrabajos.IOrdenTrabajoDetalle>, Prototipo1.WSOrdenesTrabajos.IOrdenTrabajoDetalle {
        
        public OrdenTrabajoDetalleClient() {
        }
        
        public OrdenTrabajoDetalleClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrdenTrabajoDetalleClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrdenTrabajoDetalleClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrdenTrabajoDetalleClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WS_Produccion.OrdenTrabajoDetalle crearOrdDet(WS_Produccion.OrdenTrabajoDetalle ordDetCrear) {
            return base.Channel.crearOrdDet(ordDetCrear);
        }
        
        public System.Threading.Tasks.Task<WS_Produccion.OrdenTrabajoDetalle> crearOrdDetAsync(WS_Produccion.OrdenTrabajoDetalle ordDetCrear) {
            return base.Channel.crearOrdDetAsync(ordDetCrear);
        }
        
        public WS_Produccion.OrdenTrabajoDetalle obtenerOrdDet(int id) {
            return base.Channel.obtenerOrdDet(id);
        }
        
        public System.Threading.Tasks.Task<WS_Produccion.OrdenTrabajoDetalle> obtenerOrdDetAsync(int id) {
            return base.Channel.obtenerOrdDetAsync(id);
        }
        
        public WS_Produccion.OrdenTrabajoDetalle modificarOrdDet(WS_Produccion.OrdenTrabajoDetalle ordDetModificar) {
            return base.Channel.modificarOrdDet(ordDetModificar);
        }
        
        public System.Threading.Tasks.Task<WS_Produccion.OrdenTrabajoDetalle> modificarOrdDetAsync(WS_Produccion.OrdenTrabajoDetalle ordDetModificar) {
            return base.Channel.modificarOrdDetAsync(ordDetModificar);
        }
        
        public void eliminarOrdDet(int id) {
            base.Channel.eliminarOrdDet(id);
        }
        
        public System.Threading.Tasks.Task eliminarOrdDetAsync(int id) {
            return base.Channel.eliminarOrdDetAsync(id);
        }
        
        public WS_Produccion.OrdenTrabajoDetalle[] listarOrdDet(int idOrdenTrabajo) {
            return base.Channel.listarOrdDet(idOrdenTrabajo);
        }
        
        public System.Threading.Tasks.Task<WS_Produccion.OrdenTrabajoDetalle[]> listarOrdDetAsync(int idOrdenTrabajo) {
            return base.Channel.listarOrdDetAsync(idOrdenTrabajo);
        }
    }
}
