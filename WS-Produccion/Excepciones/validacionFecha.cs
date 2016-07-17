using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WS_Produccion.Excepciones
{
    [DataContract]
    public class validacionFecha
    {
        [DataMember]
        public string codigo { get; set; }
        [DataMember]
        public string descripcion { get; set; }
    }
}