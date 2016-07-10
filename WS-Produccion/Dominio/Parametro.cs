using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WS_Produccion
{
    [DataContract]
    public class Parametro
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Descripcion { get; set; }
    }
}