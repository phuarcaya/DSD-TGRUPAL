using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_Produccion.Excepciones;

namespace WS_Produccion.Servicios
{

        [ServiceContract]
    public interface IArticulos
    {
        [FaultContract(typeof(SinStockExceptions))]

        [OperationContract]
        Articulo Modificar(Articulo ArticuloAModificar);

        [OperationContract]
        Articulo Obtener(int id);
    }
}
