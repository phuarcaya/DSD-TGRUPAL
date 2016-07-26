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
            ///verificar orden de trabajo aprobada=z crear movimiento
            //OrdenTrabajos ot = new OrdenTrabajos();
            //OrdenTrabajo ordot = new OrdenTrabajo();

            //ordot = ot.obtenerOrd((int)movCrear.IdOrdenTrabajo);


            //if (ordot.IdEstado == 1)
            //{
            //    throw new FaultException<OrdenAprobadaValidacion>(
            //        new OrdenAprobadaValidacion()
            //        {
            //            codigo = "00001",
            //            descripcion = "Orden no Aprobada"
            //        },

            //        new FaultReason("La orden aún no ha sido aprobada"));
            //}

            /////verificar si es jefe de almacen -- exception dos

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
            movDAO.Eliminar(int.Parse(id));
        }

        public List<Movimiento> listarMov(string TipoMovimiento)
        {
            return movDAO.Listar(TipoMovimiento);
        }
    }
}
