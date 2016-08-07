using System.Collections.Generic;
using System.ServiceModel;

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
