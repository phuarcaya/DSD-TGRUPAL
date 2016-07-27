using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WS_Produccion.Excepciones
{
    [DataContract]
    public class Errores
    {
        [DataMember]
        public string cod { get; set; }
        [DataMember]
        public string des { get; set; }
    }
}