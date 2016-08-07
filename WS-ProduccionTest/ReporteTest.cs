using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WS_ProduccionTest.WSReportes;
using WS_Produccion.Excepciones;
using System.ServiceModel;

namespace WS_ProduccionTest
{
    [TestClass]
    public class ReporteTest
    {
        [TestMethod]
        public void ConsultarEficienciaOK()
        {
            string fechaInicio = DateTime.Now.Year.ToString().PadLeft(4, '0') + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0');
            string fechaFinal = DateTime.Now.Year.ToString().PadLeft(4, '0') + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0');

            var eficienciaList = new ReportServiceClient().ListarEficiencia(fechaInicio, fechaFinal);

            Assert.AreEqual(fechaInicio, fechaInicio);
        }

        [TestMethod]
        public void ConsultarEficienciaFechaInicioError()
        {
            try
            {
                string fechaInicio = string.Empty;
                string fechaFinal = DateTime.Now.Year.ToString().PadLeft(4, '0') + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0');

                var eficienciaList = new ReportServiceClient().ListarEficiencia(fechaInicio, fechaFinal);
            }
            catch (FaultException<validacionFecha> error)
            {
                Assert.AreEqual("Error de consulta de eficiencia", error.Reason.ToString());
                Assert.AreEqual(error.Detail.codigo, "101");
                Assert.AreEqual(error.Detail.descripcion, "No ha ingresado la fecha inicio");
            }
        }

        [TestMethod]
        public void ConsultarEficienciaFechaFinalError()
        {
            try
            {
                string fechaInicio = DateTime.Now.Year.ToString().PadLeft(4, '0') + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0');
                string fechaFinal = string.Empty;

                var eficienciaList = new ReportServiceClient().ListarEficiencia(fechaInicio, fechaFinal);
            }
            catch (FaultException<validacionFecha> error)
            {
                Assert.AreEqual("Error de consulta de eficiencia", error.Reason.ToString());
                Assert.AreEqual(error.Detail.codigo, "101");
                Assert.AreEqual(error.Detail.descripcion, "No ha ingresado la fecha final");
            }
        }
    }
}
