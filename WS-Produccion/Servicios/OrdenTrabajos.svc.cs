using System;
using System.Collections.Generic;
using System.ServiceModel;
using WS_Produccion.Excepciones;
using WS_Produccion.Persistencia;

namespace WS_Produccion.Servicios
{
    public class OrdenTrabajos : IOrdenTrabajos, IOrdenTrabajoDetalle
    {
        private OrdenesDao ordDAO = new OrdenesDao();

        public OrdenTrabajo crearOrd(OrdenTrabajo ordCrear)
        {
            if (ordCrear.Fecha > DateTime.Now || ordCrear.FechaModificacion > DateTime.Now || ordCrear.FechaRegistro > DateTime.Now)
            {
                throw new FaultException<validacionFecha>(new validacionFecha()
                {
                    codigo = "1000",
                    descripcion = "La fecha debe ser menor a la fecha de hoy."
                },
                new FaultReason("Error al intertar crear la orden"));
            }


            if (ordCrear.Fecha == null)
            {
                ordCrear.Fecha = DateTime.Now;
                new Mensajeria().EscribirMensaje(ordCrear);
                throw new FaultException<validacionFecha>(new validacionFecha()
                {
                    codigo = "1000",
                    descripcion = "No ha ingresado la fecha."
                },
                new FaultReason("Error al intertar crear la orden"));
            }

            if (ordCrear.ListaDetalleOrdenTrabajo.Count == 0)
            {
                new Mensajeria().EscribirMensaje(ordCrear);

                throw new FaultException<validacionFecha>(new validacionFecha()
                {
                    codigo = "1000",
                    descripcion = "No ha ingresado producto terminado"
                },
                new FaultReason("Error al intertar crear la orden"));
            }

            return ordDAO.Crear(ordCrear);
        }

        public OrdenTrabajo modificarOrd(OrdenTrabajo ordModificar)
        {
            if (ordModificar.Fecha > DateTime.Now || ordModificar.FechaModificacion > DateTime.Now || ordModificar.FechaRegistro > DateTime.Now)
            {
                throw new FaultException<validacionFecha>(new validacionFecha()
                {
                    codigo = "1000",
                    descripcion = "La fecha debe ser menor a la fecha de hoy."
                },
                new FaultReason("Fecha es mayor a la Fecha de Hoy"));
            }
            return ordDAO.Modificar(ordModificar);
        }

        public OrdenTrabajo obtenerOrd(int id)
        {
            return ordDAO.Obtener(id);
        }

        public void eliminarOrd(int id)
        {
            ordDAO.Eliminar(id);
        }

        public List<OrdenTrabajo> listarOrd(string idsEstado)
        {
            return ordDAO.Listar(idsEstado);
        }

        public List<MovimientoDetalle> ListarLineaProduccion(int idOrdenTrabajo)
        {
            return ordDAO.ListarLineaProduccion(idOrdenTrabajo);
        }

        public List<MovimientoDetalle> ListarMaterialesOrdenTrabajo(int idOrdenTrabajo)
        {
            return ordDAO.ListarMaterialesOrdenTrabajo(idOrdenTrabajo);
        }

        public void ModificarEstado(int idOrdenTrabajo, int idEstado)
        {
            if (idEstado == 0)
            {
                throw new FaultException<validacionFecha>(new validacionFecha()
                {
                    codigo = "101",
                    descripcion = "El estado de la orden de trabajo debe estar pendiente"
                },
               new FaultReason("Error al aprobar orden de trabajo"));
            }

            if (idOrdenTrabajo == 0)
            {
                throw new FaultException<validacionFecha>(new validacionFecha()
                {
                    codigo = "101",
                    descripcion = "No se ha seleccionado orden de trabajo"
                },
               new FaultReason("Error al aprobar orden de trabajo"));
            }


            ordDAO.ModificarEstado(idOrdenTrabajo, idEstado);
        }

        #region Detalle orden de trabajo
        private ordenesDetalleDAO ordDetDAO = new ordenesDetalleDAO();

        public List<OrdenTrabajoDetalle> listarOrdDet(int idOrdenTrabajo)
        {
            return ordDetDAO.Listar(idOrdenTrabajo);
        }

        public void crearOrdDet(OrdenTrabajoDetalle ordDetCrear)
        {
            ordDetDAO.Crear(ordDetCrear);
        }

        public OrdenTrabajoDetalle obtenerOrdDet(int id)
        {
            return ordDetDAO.Obtener(id);
        }

        public void modificarOrdDet(OrdenTrabajoDetalle ordDetModificar)
        {
            ordDetDAO.Modificar(ordDetModificar);
        }

        public void eliminarOrdDet(int id)
        {
            ordDetDAO.Eliminar(id);
        }
        #endregion

        public void RegistrarOrdenTrabajoErronea()
        {
            new Mensajeria().AnularOrdenTrabajo();
        }
    }

}
