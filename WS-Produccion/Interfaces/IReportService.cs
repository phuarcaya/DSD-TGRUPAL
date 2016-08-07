using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WS_Produccion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IReportService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IReportService
    {
        [OperationContract]
        [WebInvoke(Method ="GET",UriTemplate = "ReportService/{id}",ResponseFormat =WebMessageFormat.Json)]
        OrdenTrabajo obtenerOrden(int id);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ReportService/listar", ResponseFormat = WebMessageFormat.Json)]
        List<OrdenTrabajo> ListarOrden();
    }
}
