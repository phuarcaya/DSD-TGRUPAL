using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WS_ProduccionTest
{
    /// <summary>
    /// Descripción resumida de WCFServiceTest
    /// </summary>
    [TestClass]
    public class WCFServiceTest
    {
        public WCFServiceTest()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestModificarArticulo()
        {

            ServiceArticulo.ArticulosClient proxy = new ServiceArticulo.ArticulosClient();
            ServiceArticulo.Articulo articuloModificado = proxy.Modificar(new ServiceArticulo.Articulo()
            {
                Id = 1111,
                Descripcion = "tuerca",
                TipoExistencia = "e",
                Activo = true,
                StockActual = (decimal)12.0,
                IdFormulaProduccion = 12
            
            }
                );
            Assert.AreEqual(1111, articuloModificado.Id);
            Assert.AreEqual("tuerca", articuloModificado.Descripcion);
            Assert.AreEqual("e", articuloModificado.TipoExistencia);
            Assert.AreEqual(true, articuloModificado.Activo);
            Assert.AreEqual((decimal)12.0, articuloModificado.StockActual);
            Assert.AreEqual(12, articuloModificado.IdFormulaProduccion);

        }
    }
}
