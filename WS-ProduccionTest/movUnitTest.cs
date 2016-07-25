using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace WS_ProduccionTest
{
    [TestClass]
    public class movUnitTest
    {
        [TestMethod]
        public void MovTestGet()
        {
            HttpWebRequest req2 = (HttpWebRequest)WebRequest.Create("http://localhost:30813/Servicios/movimientoRest.svc/movimientoRest/1");
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader read2 = new StreamReader(res2.GetResponseStream());
            string otJson2 = read2.ReadToEnd();
            JavaScriptSerializer js2 = new JavaScriptSerializer();
            Movimiento movObtenido = js2.Deserialize<Movimiento>(otJson2);
            Assert.AreEqual("1", movObtenido.Id);
            Assert.AreEqual("A", movObtenido.TipoMovimiento);
        }
    }
}
