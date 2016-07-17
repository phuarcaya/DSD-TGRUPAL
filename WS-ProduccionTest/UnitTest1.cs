using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WS_ProduccionTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMovimientos()
        {
            MovWS.MovimientosClient proxy = new MovWS.MovimientosClient();
            MovWS.Movimiento movCreado =  proxy.crearMov(new MovWS.Movimiento()
            {
                Fecha = DateTime.Today,
                FechaModificacion = DateTime.Today,
                FechaRegistro = DateTime.Today,
                Id = 1,
                IdAlmacen=5,
                IdOrdenTrabajo=2,
                TipoMovimiento="I"

            });

            Assert.AreEqual(DateTime.Today, movCreado.Fecha);
            Assert.AreEqual(DateTime.Today, movCreado.FechaModificacion);
            Assert.AreEqual(DateTime.Today, movCreado.FechaRegistro);
            Assert.AreEqual(1, movCreado.Id);
            Assert.AreEqual(5, movCreado.IdAlmacen);
            Assert.AreEqual(2, movCreado.IdOrdenTrabajo);
            Assert.AreEqual("I", movCreado.TipoMovimiento);
        }
    }
}
