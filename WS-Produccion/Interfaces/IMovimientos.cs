using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS_Produccion
{
    [ServiceContract]
    public interface IMovimientos
    {
        //[FaultContract(typeof(exceptions))]
        [OperationContract]
        Movimiento crearMov(Movimiento movCrear);

        [OperationContract]
        Movimiento obtenerMov(int id);

        [OperationContract]
        Movimiento modificarMov(Movimiento MovModificar);

        [OperationContract]
        void eliminarMov(int id);

        [OperationContract]
        List<Movimiento> listarMov();
    }
}
