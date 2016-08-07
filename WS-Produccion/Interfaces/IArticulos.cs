using System.ServiceModel;
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
