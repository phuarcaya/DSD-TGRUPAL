using System.Collections.Generic;
using System.ServiceModel;

namespace WS_Produccion
{
    [ServiceContract]
    public interface IOrdenTrabajos
    {
        //[FaultContract(typeof(exceptions))]
        [OperationContract]
        OrdenTrabajo crearOrd(OrdenTrabajo ordCrear);

        [OperationContract]
        OrdenTrabajo obtenerOrd(int id);

        [OperationContract]
        OrdenTrabajo modificarOrd(OrdenTrabajo ordModificar);

        [OperationContract]
        void eliminarOrd(int id);

        [OperationContract]
        List<OrdenTrabajo> listarOrd(string idsEstado);

        [OperationContract]
        List<MovimientoDetalle> ListarLineaProduccion(int idOrdenTrabajo);

        [OperationContract]
        List<MovimientoDetalle> ListarMaterialesOrdenTrabajo(int idOrdenTrabajo);

        [OperationContract]
        void ModificarEstado(int idOrdenTrabajo, int idEstado);

        [OperationContract]
        void RegistrarOrdenTrabajoErronea();
    }

    [ServiceContract]
    public interface IOrdenTrabajoDetalle
    {
        [OperationContract]
        void crearOrdDet(OrdenTrabajoDetalle ordDetCrear);

        [OperationContract]
        OrdenTrabajoDetalle obtenerOrdDet(int id);

        [OperationContract]
        void modificarOrdDet(OrdenTrabajoDetalle ordDetModificar);

        [OperationContract]
        void eliminarOrdDet(int id);

        [OperationContract]
        List<OrdenTrabajoDetalle> listarOrdDet(int idOrdenTrabajo);
    }
}
