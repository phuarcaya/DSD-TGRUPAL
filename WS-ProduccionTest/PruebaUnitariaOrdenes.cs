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
            OrdWS.OrdenTrabajosClient proxy = new OrdWS.OrdenTrabajosClient();
            OrdWS.OrdenTrabajo ordCreado = proxy.crearOrd(new OrdWS.OrdenTrabajo()
            {
                FechaRegistro = DateTime.Now,
                FechaModificacion= DateTime.Now,
                Fecha=DateTime.Now,
                Activo=true,
                IdEstado=1
            });

            Assert.AreEqual(DateTime.Now, ordCreado.FechaRegistro);
            Assert.AreEqual(DateTime.Now, ordCreado.FechaModificacion);
            Assert.AreEqual(DateTime.Now, ordCreado.Fecha);
            Assert.AreEqual(true, ordCreado.Activo);
            Assert.AreEqual(1, ordCreado.IdEstado);
        }
    }
}
