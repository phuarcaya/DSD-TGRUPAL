using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WS_ProduccionUtilitario;
using System.Collections.Generic;
using WS_Produccion;
using WS_ProduccionTest.WSOrdenTrabajos;
using System.ServiceModel;
using WS_Produccion.Excepciones;

namespace WS_ProduccionTest
{
    [TestClass]
    public class OrdenesTrabajoTest
    {
        [TestMethod]
        public void CrearOrdenTrabajoOK()
        {
            OrdenTrabajo ordenTrabajo = new OrdenTrabajo();
            ordenTrabajo.Fecha = DateTime.Now;
            ordenTrabajo.IdEstado = EEstadoOrdenTrabajo.Pendiente.GetHashCode();
            ordenTrabajo.Activo = true;
            ordenTrabajo.FechaRegistro = DateTime.Now;

            if (ordenTrabajo.ListaDetalleOrdenTrabajo == null)
            {
                ordenTrabajo.ListaDetalleOrdenTrabajo = new List<OrdenTrabajoDetalle>();
            }

            OrdenTrabajoDetalle ordenTrabajoDetalle = new OrdenTrabajoDetalle();
            ordenTrabajoDetalle.IdArticulo = 1;
            ordenTrabajoDetalle.Cantidad = 3;
            ordenTrabajo.ListaDetalleOrdenTrabajo.Add(ordenTrabajoDetalle);

            var ordenCreado = new OrdenTrabajosClient().crearOrd(ordenTrabajo);

            Assert.AreEqual(ordenTrabajo.IdEstado, ordenCreado.IdEstado);
            Assert.AreEqual(ordenTrabajo.Fecha, ordenCreado.Fecha);
        }

        [TestMethod]
        public void CrearOrdenTrabajoFechaError()
        {
            OrdenTrabajo ordenTrabajo = new OrdenTrabajo();
            //ordenTrabajo.Fecha = DateTime.Now;
            ordenTrabajo.IdEstado = EEstadoOrdenTrabajo.Pendiente.GetHashCode();
            ordenTrabajo.Activo = true;
            ordenTrabajo.FechaRegistro = DateTime.Now;

            if (ordenTrabajo.ListaDetalleOrdenTrabajo == null)
            {
                ordenTrabajo.ListaDetalleOrdenTrabajo = new List<OrdenTrabajoDetalle>();
            }

            try
            {
                OrdenTrabajoDetalle ordenTrabajoDetalle = new OrdenTrabajoDetalle();
                ordenTrabajoDetalle.IdArticulo = 1;
                ordenTrabajoDetalle.Cantidad = 3;
                ordenTrabajo.ListaDetalleOrdenTrabajo.Add(ordenTrabajoDetalle);

                var ordenCreado = new OrdenTrabajosClient().crearOrd(ordenTrabajo);
            }
            catch (FaultException<validacionFecha> error)
            {
                Assert.AreEqual("Error al intertar crear la orden", error.Reason.ToString());
                Assert.AreEqual(error.Detail.codigo, "1000");
                Assert.AreEqual(error.Detail.descripcion, "No ha ingresado la fecha.");
            }

        }

        [TestMethod]
        public void CrearOrdenTrabajoProductoTerminadoError()
        {
            OrdenTrabajo ordenTrabajo = new OrdenTrabajo();
            ordenTrabajo.Fecha = DateTime.Now;
            ordenTrabajo.IdEstado = EEstadoOrdenTrabajo.Pendiente.GetHashCode();
            ordenTrabajo.Activo = true;
            ordenTrabajo.FechaRegistro = DateTime.Now;

            if (ordenTrabajo.ListaDetalleOrdenTrabajo == null)
            {
                ordenTrabajo.ListaDetalleOrdenTrabajo = new List<OrdenTrabajoDetalle>();
            }

            try
            {
                var ordenCreado = new OrdenTrabajosClient().crearOrd(ordenTrabajo);
            }
            catch (FaultException<validacionFecha> error)
            {
                Assert.AreEqual("Error al intertar crear la orden", error.Reason.ToString());
                Assert.AreEqual(error.Detail.codigo, "1000");
                Assert.AreEqual(error.Detail.descripcion, "No ha ingresado producto terminado");
            }
        }

    }
}
