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