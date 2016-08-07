using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.ServiceModel;

namespace WS_ProduccionTest
{
    [TestClass]
    public class movUnitTest
    {
        [TestMethod]
        public void MovTestGet()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:30813/Servicios/GestionarMovimiento.svc/GestionarMovimiento/1");
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader read = new StreamReader(res.GetResponseStream());
            string otJson = read.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Movimiento movObtenido = js.Deserialize<Movimiento>(otJson);
            Assert.AreEqual(1, movObtenido.Id);
            Assert.AreEqual("A", movObtenido.TipoMovimiento);
        }
        //[TestMethod]
        //public void MovTestCrear()
        //{
        //    string postdata = "{\"TipoMovimiento\":\"B\",\"Fecha\":\"27/07/2016\"}";
        //    byte[] data = Encoding.UTF8.GetBytes(postdata);
        //    HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:30813/Servicios/GestionarMovimiento.svc/GestionarMovimiento");
        //    req.Method = "POST";
        //    req.ContentLength = data.Length;
        //    req.ContentType = "application/json";
        //    var reqStream = req.GetRequestStream();
        //    reqStream.Write(data, 0, data.Length);
        //    //var res = (HttpWebResponse)req.GetResponse();
        //    HttpWebResponse res;
        //    try { res = (HttpWebResponse)req.GetResponse();

        //    StreamReader reader = new StreamReader(res.GetResponseStream());
        //    string movJson = reader.ReadToEnd();
        //    JavaScriptSerializer js = new JavaScriptSerializer();
        //    Movimiento movCreado = js.Deserialize<Movimiento>(movJson);
        //    Assert.AreEqual("B", movCreado.TipoMovimiento);
        //    Assert.AreEqual("27/07/2016", movCreado.Fecha);
        //    }
        //    catch (FaultException<GesMovWS.Errores> error)
        //    {
        //        error.Detail.cod = "GesMov-0002";
        //        error.Detail.cod = "Error al momento de Crear Movimiento";
        //    }
        //}

        [TestMethod]
        public void MovATestGet()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:30813/Servicios/MovimientoAlmacenes.svc/Movimiento/1");
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader read = new StreamReader(res.GetResponseStream());
            string otJson = read.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Movimiento movObtenido = js.Deserialize<Movimiento>(otJson);
            Assert.AreEqual(1, movObtenido.Id);
            Assert.AreEqual("A", movObtenido.TipoMovimiento);
        }
        [TestMethod]
        public void MovATestCrear()
        {
            string postdata = "{\"TipoMovimiento\":\"B\",\"Fecha\":\"27/07/2016\"}";
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:30813/Servicios/GestionarMovimiento.svc/GestionarMovimiento");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            //var res = (HttpWebResponse)req.GetResponse();
            HttpWebResponse res;
            try
            {
                res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string movJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Movimiento movCreado = js.Deserialize<Movimiento>(movJson);
                Assert.AreEqual("B", movCreado.TipoMovimiento);
                Assert.AreEqual("27/07/2016", movCreado.Fecha);
            }
            catch (FaultException<MovAlmWS.Errores> error)
            {
                error.Detail.cod = "GesMov-0002";
                error.Detail.cod = "Error al momento de Crear Movimiento";
            }

        }
    }
}