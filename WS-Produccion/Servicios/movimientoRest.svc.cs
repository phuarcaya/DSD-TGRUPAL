using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_Produccion.Persistencia;

namespace WS_Produccion.Servicios
{
    public class movimientoRest : ImovimientoRest
    {
        private MovimientoDAO dao = new MovimientoDAO();

        public Movimiento borrarMov(int id)
        {
            throw new NotImplementedException();
        }

        public Movimiento CrearMov(Movimiento movCrear)
        {
            return dao.Crear(movCrear);
        }

        public Movimiento grabarMov(Movimiento movGrabar)
        {
            throw new NotImplementedException();
        }

        public List<Movimiento> listarMov()
        {
            throw new NotImplementedException();
        }

        public Movimiento obtenerMov(string id)
        {
            return dao.Obtener(int.Parse(id));
        }
    }
}
