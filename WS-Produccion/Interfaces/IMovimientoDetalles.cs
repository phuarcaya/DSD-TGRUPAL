using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS_Produccion.Interfaces
{

    [ServiceContract]
    public interface IMovimientoDetalles
    {
        [OperationContract]
        MovimientoDetalle crearDMov(MovimientoDetalle movDCrear);

        [OperationContract]
        MovimientoDetalle obtenerDMov(int id);

        [OperationContract]
        MovimientoDetalle modificarDMov(MovimientoDetalle MovDModificar);

        [OperationContract]
        void eliminarDMov(int id);

        [OperationContract]
        List<MovimientoDetalle> listarDMov();
    }
}
