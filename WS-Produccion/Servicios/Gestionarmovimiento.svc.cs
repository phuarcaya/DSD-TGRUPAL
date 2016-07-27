using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_Produccion.Persistencia;

namespace WS_Produccion.Servicios
{
    public class GestionarMovimiento: IGestionarMovimiento
    {
        private MovimientoDAO dao = new MovimientoDAO();

        public void borrarMov(string id)
        {
            dao.Eliminar(int.Parse(id));
        }

        public Movimiento CrearMov(Movimiento movCrear)
        {
            return dao.Crear(movCrear);
        }

        public Movimiento grabarMov(Movimiento movGrabar)
        {
            return dao.Modificar(movGrabar);
        }

        public List<Movimiento> listarMov(string tipo)
        {
            return dao.Listar(tipo);
        }

        public Movimiento obtenerMov(string id)
        {
            return dao.Obtener(int.Parse(id));
        }
    }
}
