using System.Collections.Generic;

namespace WS_Produccion.Interfaces
{
    public class ParametroDetalles : IParametroDetalles
    {
        public List<ParametroDetalle> ListarParametroDetalle(int idPadre)
        {
            return new ParametroDetalleDao().Listar(idPadre);
        }
    }
}
