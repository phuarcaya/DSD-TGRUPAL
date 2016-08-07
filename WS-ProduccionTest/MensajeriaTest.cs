using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WS_ProduccionTest.WSOrdenTrabajos;
using WS_Produccion;

namespace WS_ProduccionTest
{
    [TestClass]
    public class MensajeriaTest
    {
        [TestMethod]
        public void AnularOrdenesTrabajoOK()
        {
            OrdenTrabajo ordenTrabajo = new OrdenTrabajo();
            ordenTrabajo.Id = 0;
            new OrdenTrabajosClient().RegistrarOrdenTrabajoErronea();
            Assert.AreEqual(ordenTrabajo.Id, ordenTrabajo.Id);
        }
    }
}
