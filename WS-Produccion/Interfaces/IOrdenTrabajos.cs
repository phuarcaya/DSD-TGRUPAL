using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

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
        List<OrdenTrabajo> listarOrd();
    }

    [ServiceContract]
    public interface IOrdenTrabajoDetalle
    {
        [OperationContract]
        OrdenTrabajoDetalle crearOrdDet(OrdenTrabajoDetalle ordDetCrear);

        [OperationContract]
        OrdenTrabajoDetalle obtenerOrdDet(int id);

        [OperationContract]
        OrdenTrabajoDetalle modificarOrdDet(OrdenTrabajoDetalle ordDetModificar);

        [OperationContract]
        void eliminarOrdDet(int id);

        [OperationContract]
        List<OrdenTrabajoDetalle> listarOrd();
    }
}
