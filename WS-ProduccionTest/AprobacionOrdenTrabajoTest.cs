using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WS_ProduccionTest.WSOrdenTrabajos;
using WS_Produccion;
using WS_ProduccionUtilitario;
using System.ServiceModel;
using WS_Produccion.Excepciones;

namespace WS_ProduccionTest
{
    [TestClass]
    public class AprobacionOrdenTrabajoTest
    {
        [TestMethod]
        public void AprobarOrdenTrabajoOK()
        {
            OrdenTrabajo ordenTrabajo = new OrdenTrabajo();
            ordenTrabajo.Id = 4;
            ordenTrabajo.IdEstado = EEstadoOrdenTrabajo.Aprobado.GetHashCode();

            new OrdenTrabajosClient().ModificarEstado(ordenTrabajo.Id, ordenTrabajo.IdEstado.Value);

            Assert.AreEqual(ordenTrabajo.IdEstado, ordenTrabajo.IdEstado);
        }

        [TestMethod]
        public void AprobarOrdenTrabajoEstadoError()
        {
            try
            {
                OrdenTrabajo ordenTrabajo = new OrdenTrabajo();
                ordenTrabajo.Id = 4;
                ordenTrabajo.IdEstado = 0;

                new OrdenTrabajosClient().ModificarEstado(ordenTrabajo.Id, ordenTrabajo.IdEstado.Value);
            }
            catch (FaultException<validacionFecha> error)
            {
                Assert.AreEqual("Error al aprobar orden de trabajo", error.Reason.ToString());
                Assert.AreEqual(error.Detail.codigo, "101");
                Assert.AreEqual(error.Detail.descripcion, "El estado de la orden de trabajo debe estar pendiente");
            }
        }

        [TestMethod]
        public void AprobarOrdenTrabajoSeleccionadoError()
        {
            try
            {
                OrdenTrabajo ordenTrabajo = new OrdenTrabajo();
                ordenTrabajo.Id = 0;
                ordenTrabajo.IdEstado = EEstadoOrdenTrabajo.Aprobado.GetHashCode();

                new OrdenTrabajosClient().ModificarEstado(ordenTrabajo.Id, ordenTrabajo.IdEstado.Value);
            }
            catch (FaultException<validacionFecha> error)
            {
                Assert.AreEqual("Error al aprobar orden de trabajo", error.Reason.ToString());
                Assert.AreEqual(error.Detail.codigo, "101");
                Assert.AreEqual(error.Detail.descripcion, "No se ha seleccionado orden de trabajo");
            }
        }
    }
}
