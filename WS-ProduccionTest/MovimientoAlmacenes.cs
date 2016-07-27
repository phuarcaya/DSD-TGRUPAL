using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Web.Script.Serialization;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ServiceModel;
using WS_Produccion.Excepciones;

namespace WS_ProduccionTest
{
    [TestClass]
    public class MovimientoAlmacenes
    {
        private const string GetRutaServicioMovimientoAlmacenes = "http://localhost:30813/Servicios/MovimientoAlmacenes.svc/";

        [TestMethod]
        public void TestMethodCrearIngresoProductoTerminado()
        {
            Movimiento movimientoCreado = null;

            string url = GetRutaServicioMovimientoAlmacenes;
            WebClient client = new WebClient();
            client.Credentials = System.Net.CredentialCache.DefaultCredentials;
            string recurso = "Movimiento";


            Movimiento ordenMovimiento = new Movimiento();
            ordenMovimiento.Fecha = DateTime.Now;
            ordenMovimiento.IdAlmacen = 6;
            ordenMovimiento.IdOrdenTrabajo = 1;
            ordenMovimiento.TipoMovimiento = "I";

            if (ordenMovimiento.ListaMovimientoDetalles == null) ordenMovimiento.ListaMovimientoDetalles = new List<MovimientoDetalle>();

            MovimientoDetalle MovimientoDetalle = new MovimientoDetalle();
            MovimientoDetalle.IdArticulo = 1;
            MovimientoDetalle.Cantidad = 2;
            ordenMovimiento.ListaMovimientoDetalles.Add(MovimientoDetalle);

            var json = new JavaScriptSerializer().Serialize(ordenMovimiento);
            var bytes = Encoding.Default.GetBytes(json);
            client.Headers.Add("Content-Type", "application/json");

            try
            {
                var response = client.UploadData(url + recurso, "POST", bytes);
                JToken token = JObject.Parse(System.Text.Encoding.UTF8.GetString(response));
                movimientoCreado = token.ToObject<Movimiento>();

                Assert.AreEqual(ordenMovimiento.IdAlmacen, movimientoCreado.IdAlmacen);
                Assert.AreEqual(ordenMovimiento.IdOrdenTrabajo, movimientoCreado.IdAlmacen);
                Assert.AreEqual(ordenMovimiento.TipoMovimiento, movimientoCreado.TipoMovimiento);
            }
            catch (FaultException<OrdenAprobadaValidacion> error)
            {
                Assert.AreEqual("00001", error.Detail.codigo);
                Assert.AreEqual("Orden de trabajo no ha sido Aprobada", error.Detail.descripcion);
            }
        }

        [TestMethod]
        public void TestMethodModificarIngresoProductoTerminado()
        {
            Movimiento movimientoCreado = null;

            string url = GetRutaServicioMovimientoAlmacenes;
            WebClient client = new WebClient();
            client.Credentials = System.Net.CredentialCache.DefaultCredentials;
            string recurso = "Movimiento";


            Movimiento ordenMovimiento = new Movimiento();
            ordenMovimiento.Fecha = DateTime.Now;
            ordenMovimiento.Id = 1;
            ordenMovimiento.IdAlmacen = 6;
            ordenMovimiento.IdOrdenTrabajo = 1;
            ordenMovimiento.TipoMovimiento = "I";

            if (ordenMovimiento.ListaMovimientoDetalles == null) ordenMovimiento.ListaMovimientoDetalles = new List<MovimientoDetalle>();

            MovimientoDetalle MovimientoDetalle = new MovimientoDetalle();
            MovimientoDetalle.IdArticulo = 1;
            MovimientoDetalle.Cantidad = 2;
            ordenMovimiento.ListaMovimientoDetalles.Add(MovimientoDetalle);

            var json = new JavaScriptSerializer().Serialize(ordenMovimiento);
            var bytes = Encoding.Default.GetBytes(json);
            client.Headers.Add("Content-Type", "application/json");
            var response = client.UploadData(url + recurso, "PUT", bytes);

            JToken token = JObject.Parse(System.Text.Encoding.UTF8.GetString(response));
            movimientoCreado = token.ToObject<Movimiento>();

            Assert.AreEqual(ordenMovimiento.IdAlmacen, movimientoCreado.IdAlmacen);
            Assert.AreEqual(ordenMovimiento.IdOrdenTrabajo, movimientoCreado.IdAlmacen);
            Assert.AreEqual(ordenMovimiento.TipoMovimiento, movimientoCreado.TipoMovimiento);
        }

        [TestMethod]
        public void TestMethodObtenerIngresoProductoTerminado()
        {
            string url = GetRutaServicioMovimientoAlmacenes;
            WebClient client = new WebClient();
            client.Credentials = System.Net.CredentialCache.DefaultCredentials;

            string recurso = "Movimiento/" + 1;

            byte[] responseData = client.DownloadData(url + recurso);
            JToken token = JObject.Parse(System.Text.Encoding.UTF8.GetString(responseData));
            var result = token.ToObject<Movimiento>();

            Assert.AreEqual(6, result.IdAlmacen);
            Assert.AreEqual(1, result.IdOrdenTrabajo);
            Assert.AreEqual("I", result.TipoMovimiento);
        }

        [TestMethod]
        public void TestMethodEliminarIngresoProductoTerminado()
        {
            string url = GetRutaServicioMovimientoAlmacenes + "Movimiento/" + 1;
            WebClient client = new WebClient();
            client.Credentials = System.Net.CredentialCache.DefaultCredentials;

            string eliminado = client.UploadString(url, "DELETE", "");

            Assert.AreEqual("", eliminado);
        }
    }
}
