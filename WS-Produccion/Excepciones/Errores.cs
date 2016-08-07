using System.Runtime.Serialization;

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