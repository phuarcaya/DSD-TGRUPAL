using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_Produccion.Excepciones;
using WS_Produccion.Persistencia;
using WS_Produccion.Servicios;

namespace WS_Produccion
{
    public class Movimientos : IMovimientos
    {
        private MovimientoDAO movDAO = new MovimientoDAO();

        public Movimiento crearMov(Movimiento movCrear)
        {
            ///verificar orden de trabajo aprobada=z crear movimiento
            OrdenTrabajos ot = new OrdenTrabajos();
            OrdenTrabajo ordot = new OrdenTrabajo();

            ordot = ot.obtenerOrd((int)movCrear.IdOrdenTrabajo);
            if (ordot.IdEstado == 1)
            {
                throw new FaultException<OrdenAprobadaValidacion>(
                    new OrdenAprobadaValidacion()
                    {
                        codigo = "00001",
                        descripcion = "Orden no Aprobada"
                    },

                    new FaultReason("La orden aún no ha sido aprobada"));
            }

            ///verificar si es jefe de almacen
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
