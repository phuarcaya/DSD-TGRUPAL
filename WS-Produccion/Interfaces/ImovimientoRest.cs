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
    public interface ImovimientoRest
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "movimientoRest", ResponseFormat = WebMessageFormat.Json)]
        Movimiento CrearMov(Movimiento movCrear);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "movimientoRest/{id}", ResponseFormat = WebMessageFormat.Json)]
        Movimiento obtenerMov(string id);
        [OperationContract]
        [WebInvoke]
        Movimiento grabarMov(Movimiento movGrabar);
        [OperationContract]
        [WebInvoke]
        Movimiento borrarMov(int id);
        [OperationContract]
        [WebInvoke]
        List<Movimiento> listarMov();
    }
}
