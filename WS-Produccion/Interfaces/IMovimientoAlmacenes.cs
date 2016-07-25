using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WS_Produccion.Servicios
{
    [ServiceContract]
    public interface IMovimientoAlmacenes
    {
        //[FaultContract(typeof(exceptions))]
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Movimiento", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        Movimiento crearMov(Movimiento movCrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Movimiento/{id}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        Movimiento obtenerMov(string id);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Movimiento", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        Movimiento modificarMov(Movimiento MovModificar);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Movimiento/{id}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        void eliminarMov(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Movimiento?pTipoMovimiento={TipoMovimiento}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<Movimiento> listarMov(string TipoMovimiento);
    }
}
