using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_Produccion.Persistencia;

namespace WS_Produccion.Interfaces
{
    public class MovimientoDetalles : IMovimientoDetalles
    {
        private MovimientoDetalleDAO movDDAO = new MovimientoDetalleDAO();

        public MovimientoDetalle crearDMov(MovimientoDetalle movDCrear)
        {
            return movDDAO.Crear(movDCrear);
        }

        public void eliminarDMov(int id)
        {
            movDDAO.Eliminar(id);
        }

        public List<MovimientoDetalle> listarDMov()
        {
            return movDDAO.Listar();
        }

        public MovimientoDetalle modificarDMov(MovimientoDetalle MovDModificar)
        {
            return movDDAO.Modificar(MovDModificar);
        }

        public MovimientoDetalle obtenerDMov(int id)
        {
            return movDDAO.Obtener(id);
        }
    }
}
