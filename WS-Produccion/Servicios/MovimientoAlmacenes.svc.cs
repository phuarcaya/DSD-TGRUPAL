using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_Produccion.Excepciones;
using WS_Produccion.Persistencia;
using WS_ProduccionUtilitario;

namespace WS_Produccion.Servicios
{
    public class MovimientoAlmacenes : IMovimientoAlmacenes
    {
        private MovimientoDAO movDAO = new MovimientoDAO();

        public Movimiento crearMov(Movimiento movCrear)
        {
            if (movCrear.TipoMovimiento.Equals("I"))
            {
                var ordot = new OrdenTrabajos().obtenerOrd((int)movCrear.IdOrdenTrabajo);

                if (ordot.IdEstado == 1)
                {
                    throw new FaultException<OrdenAprobadaValidacion>(
                        new OrdenAprobadaValidacion()
                        {
                            codigo = "00001",
                            descripcion = "Orden de trabajo no ha sido Aprobada"
                        },

                        new FaultReason("La orden aún no ha sido aprobada"));
                }
            }

            var movCreado = movDAO.Crear(movCrear);
            if (movCreado != null)
            {
                //Cerra orden de trabajo
                if (movCreado.TipoMovimiento.Equals("I"))
                {
                    new OrdenesDao().ModificarEstado(movCreado.IdOrdenTrabajo.Value, EEstadoOrdenTrabajo.Cerrado.GetHashCode());
                }
                else
                {
                    new OrdenesDao().ModificarEstado(movCreado.IdOrdenTrabajo.Value, EEstadoOrdenTrabajo.EnProcesoProduccion.GetHashCode());
                }
            }

            return movCreado;
        }

        public Movimiento obtenerMov(string id)
        {
            return movDAO.Obtener(int.Parse(id));
        }

        public Movimiento modificarMov(Movimiento MovModificar)
        {
            return movDAO.Modificar(MovModificar);
        }

        public void eliminarMov(string id)
        {
            new MovimientoDetalleDAO().EliminarMovimiento(int.Parse(id));
            movDAO.Eliminar(int.Parse(id));
        }

        public List<Movimiento> listarMov(string TipoMovimiento)
        {
            return movDAO.Listar(TipoMovimiento);
        }
    }
}
