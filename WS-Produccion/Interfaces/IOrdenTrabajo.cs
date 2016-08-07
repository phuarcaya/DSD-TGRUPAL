using System.ServiceModel;

namespace WS_Produccion.Servicios
{
    [ServiceContract]
    public interface IOrdenTrabajo
    {
        

        [OperationContract]
        OrdenTrabajo CrearOrdenTrabajo(OrdenTrabajo OrdenTraabajoACrear);

        [OperationContract]
        OrdenTrabajo ObtenerOrdenTrabajo(int id);

        [OperationContract]
        OrdenTrabajo ModificarOrdenTrabajo(OrdenTrabajo analistaAModificar);

        [OperationContract]
        void EliminarOrdenTrabajo(int id);
    }
}
