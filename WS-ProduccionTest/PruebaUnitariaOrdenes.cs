using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WS_ProduccionTest
{
    [TestClass]
    public class PruebaUnitariaOrdenes
    {
        [TestMethod]
        public void CreacionCorrecta()
        {
            DateTime fecha = DateTime.Now;
            OrdWS.OrdenTrabajosClient proxy = new OrdWS.OrdenTrabajosClient();
            OrdWS.OrdenTrabajo ordCreada = proxy.crearOrd(new OrdWS.OrdenTrabajo()
            {
                FechaRegistro = fecha,
                FechaModificacion= fecha,
                Fecha= fecha,
                Activo=true,
                IdEstado=1
            });

            Assert.AreEqual(fecha, ordCreada.FechaRegistro);
            Assert.AreEqual(fecha, ordCreada.FechaModificacion);
            Assert.AreEqual(fecha, ordCreada.Fecha);
            Assert.AreEqual(true, ordCreada.Activo);
            Assert.AreEqual(1, ordCreada.IdEstado);
        }
    }
}
