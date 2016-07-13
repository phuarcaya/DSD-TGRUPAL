using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

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
