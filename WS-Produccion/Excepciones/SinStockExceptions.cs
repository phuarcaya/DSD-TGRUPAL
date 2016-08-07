using System.Runtime.Serialization;

namespace WS_Produccion.Excepciones
{
    [DataContract]
    public class SinStockExceptions
    {
       
        [DataMember]
        public string codigo { get; set; }
        [DataMember]
        public string descripcion { get; set; }
    }
}