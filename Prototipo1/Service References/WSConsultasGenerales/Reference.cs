﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prototipo1.WSConsultasGenerales {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSConsultasGenerales.IParametroDetalles")]
    public interface IParametroDetalles {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IParametroDetalles/ListarParametroDetalle", ReplyAction="http://tempuri.org/IParametroDetalles/ListarParametroDetalleResponse")]
        WS_Produccion.ParametroDetalle[] ListarParametroDetalle(int idPadre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IParametroDetalles/ListarParametroDetalle", ReplyAction="http://tempuri.org/IParametroDetalles/ListarParametroDetalleResponse")]
        System.Threading.Tasks.Task<WS_Produccion.ParametroDetalle[]> ListarParametroDetalleAsync(int idPadre);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IParametroDetallesChannel : Prototipo1.WSConsultasGenerales.IParametroDetalles, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ParametroDetallesClient : System.ServiceModel.ClientBase<Prototipo1.WSConsultasGenerales.IParametroDetalles>, Prototipo1.WSConsultasGenerales.IParametroDetalles {
        
        public ParametroDetallesClient() {
        }
        
        public ParametroDetallesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ParametroDetallesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ParametroDetallesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ParametroDetallesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WS_Produccion.ParametroDetalle[] ListarParametroDetalle(int idPadre) {
            return base.Channel.ListarParametroDetalle(idPadre);
        }
        
        public System.Threading.Tasks.Task<WS_Produccion.ParametroDetalle[]> ListarParametroDetalleAsync(int idPadre) {
            return base.Channel.ListarParametroDetalleAsync(idPadre);
        }
    }
}
