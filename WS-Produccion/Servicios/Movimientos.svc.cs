using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_Produccion.Persistencia;

namespace WS_Produccion.Interfaces
{
    public class Movimientos : IMovimientos
    {
        private MovimientoDAO movDAO = new MovimientoDAO();

        public Movimiento crearMov(Movimiento movCrear)
        {
            return movDAO.Crear(movCrear);
        }

        public void eliminarMov(int id)
        {
            movDAO.Eliminar(id);
        }

        public List<Movimiento> listarMov()
        {
            return movDAO.Listar();
        }

        public Movimiento modificarMov(Movimiento MovModificar)
        {
            return movDAO.Modificar(MovModificar);
        }

        public Movimiento obtenerMov(int id)
        {
            return movDAO.Obtener(id);
        }
    }
}
