﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Web.Script.Serialization;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ServiceModel;
using WS_Produccion.Excepciones;
using System.IO;

namespace WS_ProduccionTest
{
    [TestClass]
    public class MovimientoAlmacenesTest
    {
        private const string GetRutaServicioMovimientoAlmacenes = "http://localhost:30813/Servicios/MovimientoAlmacenes.svc/";

        [TestMethod]
        public void TestMethodCrearIngresoProductoTerminadoOK()
        {
            Movimiento movimientoCreado = null;

            string url = GetRutaServicioMovimientoAlmacenes;
            WebClient client = new WebClient();
            client.Credentials = System.Net.CredentialCache.DefaultCredentials;
            string recurso = "Movimiento";


            Movimiento ordenMovimiento = new Movimiento();
            ordenMovimiento.Fecha = DateTime.Now;
            ordenMovimiento.FechaRegistro = DateTime.Now;
            ordenMovimiento.IdAlmacen = 6;
            ordenMovimiento.IdOrdenTrabajo = 3;
            ordenMovimiento.TipoMovimiento = "I";

            if (ordenMovimiento.ListaMovimientoDetalles == null) ordenMovimiento.ListaMovimientoDetalles = new List<MovimientoDetalle>();

            MovimientoDetalle MovimientoDetalle = new MovimientoDetalle();
            MovimientoDetalle.IdArticulo = 9;
            MovimientoDetalle.Cantidad = 5;
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
                Assert.AreEqual(ordenMovimiento.IdOrdenTrabajo, movimientoCreado.IdOrdenTrabajo);
                Assert.AreEqual(ordenMovimiento.TipoMovimiento, movimientoCreado.TipoMovimiento);
            }
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string message = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                string mensaje = js.Deserialize<string>(error);

                Assert.AreEqual("Orden de trabajo no ha sido Aprobada", mensaje);
            }
        }

        [TestMethod]
        public void TestMethodCrearIngresoOrdenTrabajoError()
        {
            Movimiento movimientoCreado = null;

            string url = GetRutaServicioMovimientoAlmacenes;
            WebClient client = new WebClient();
            client.Credentials = System.Net.CredentialCache.DefaultCredentials;
            string recurso = "Movimiento";


            Movimiento ordenMovimiento = new Movimiento();
            ordenMovimiento.Fecha = DateTime.Now;
            ordenMovimiento.FechaRegistro = DateTime.Now;
            ordenMovimiento.IdAlmacen = 6;
            //ordenMovimiento.IdOrdenTrabajo = 1;
            ordenMovimiento.TipoMovimiento = "I";

            if (ordenMovimiento.ListaMovimientoDetalles == null) ordenMovimiento.ListaMovimientoDetalles = new List<MovimientoDetalle>();

            MovimientoDetalle MovimientoDetalle = new MovimientoDetalle();
            MovimientoDetalle.IdArticulo = 9;
            MovimientoDetalle.Cantidad = 5;
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
                Assert.AreEqual(ordenMovimiento.IdOrdenTrabajo, movimientoCreado.IdOrdenTrabajo);
                Assert.AreEqual(ordenMovimiento.TipoMovimiento, movimientoCreado.TipoMovimiento);
            }
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string message = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                string mensaje = js.Deserialize<string>(error);

                Assert.AreEqual("No existe orden de trabajo", mensaje);
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
            ordenMovimiento.FechaModificacion = DateTime.Now;
            ordenMovimiento.IdAlmacen = 6;
            ordenMovimiento.IdOrdenTrabajo = 3;
            ordenMovimiento.TipoMovimiento = "I";

            if (ordenMovimiento.ListaMovimientoDetalles == null) ordenMovimiento.ListaMovimientoDetalles = new List<MovimientoDetalle>();

            MovimientoDetalle MovimientoDetalle = new MovimientoDetalle();
            MovimientoDetalle.IdArticulo = 9;
            MovimientoDetalle.Cantidad = 5;
            ordenMovimiento.ListaMovimientoDetalles.Add(MovimientoDetalle);

            var json = new JavaScriptSerializer().Serialize(ordenMovimiento);
            var bytes = Encoding.Default.GetBytes(json);
            client.Headers.Add("Content-Type", "application/json");
            var response = client.UploadData(url + recurso, "PUT", bytes);

            JToken token = JObject.Parse(System.Text.Encoding.UTF8.GetString(response));
            movimientoCreado = token.ToObject<Movimiento>();

            Assert.AreEqual(ordenMovimiento.IdAlmacen, movimientoCreado.IdAlmacen);
            Assert.AreEqual(ordenMovimiento.IdOrdenTrabajo, movimientoCreado.IdOrdenTrabajo);
            Assert.AreEqual(ordenMovimiento.TipoMovimiento, movimientoCreado.TipoMovimiento);
        }

        [TestMethod]
        public void TestMethodObtenerIngresoProductoTerminado()
        {
            string url = GetRutaServicioMovimientoAlmacenes;
            WebClient client = new WebClient();
            client.Credentials = System.Net.CredentialCache.DefaultCredentials;

            string recurso = "Movimiento/" + 4;

            byte[] responseData = client.DownloadData(url + recurso);
            JToken token = JObject.Parse(System.Text.Encoding.UTF8.GetString(responseData));
            var result = token.ToObject<Movimiento>();

            Assert.AreEqual(5, result.IdAlmacen.Value);
            Assert.AreEqual(1, result.IdOrdenTrabajo.Value);
            Assert.AreEqual("S", result.TipoMovimiento);
        }

        [TestMethod]
        public void TestMethodEliminarIngresoProductoTerminado()
        {
            string url = GetRutaServicioMovimientoAlmacenes + "Movimiento/" + 4;
            WebClient client = new WebClient();
            client.Credentials = System.Net.CredentialCache.DefaultCredentials;

            string eliminado = client.UploadString(url, "DELETE", "");

            Assert.AreEqual("", eliminado);
        }
    }
}
