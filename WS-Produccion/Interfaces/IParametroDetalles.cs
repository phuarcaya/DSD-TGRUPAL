using System.Collections.Generic;
using System.ServiceModel;

namespace WS_Produccion.Interfaces
{
    [ServiceContract]
    public interface IParametroDetalles
    {
        [OperationContract]
        List<ParametroDetalle> ListarParametroDetalle(int idPadre);
    }
}
