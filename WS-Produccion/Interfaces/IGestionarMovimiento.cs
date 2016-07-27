using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WS_Produccion.Excepciones;

namespace WS_Produccion.Servicios
{
    [ServiceContract]
    public interface IGestionarMovimiento
    {
        [FaultContract(typeof(Errores))]
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Gestionarmovimiento", ResponseFormat = WebMessageFormat.Json)]
        Movimiento CrearMov(Movimiento movCrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Gestionarmovimiento/{id}", ResponseFormat = WebMessageFormat.Json)]
        Movimiento obtenerMov(string id);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Gestionarmovimiento", ResponseFormat = WebMessageFormat.Json)]
        Movimiento grabarMov(Movimiento movGrabar);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Gestionarmovimiento/{id}", ResponseFormat = WebMessageFormat.Json)]
        void borrarMov(string id);

        [OperationContract]
        [WebInvoke]
//        [WebInvoke(Method = "GET", UriTemplate = "Gestionarmovimiento/{tipo}", ResponseFormat = WebMessageFormat.Json)]
        List<Movimiento> listarMov(string tipo);
    }
}
