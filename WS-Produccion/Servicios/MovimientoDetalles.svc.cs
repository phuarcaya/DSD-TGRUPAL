using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_Produccion.Persistencia;

namespace WS_Produccion.Interfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MovimientoDetalles" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MovimientoDetalles.svc or MovimientoDetalles.svc.cs at the Solution Explorer and start debugging.
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
