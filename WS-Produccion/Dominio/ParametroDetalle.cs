using System;
using System.Runtime.Serialization;

namespace WS_Produccion
{
    [DataContract]
    public class ParametroDetalle
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        [DataMember]
        public Nullable<int> IdPadre { get; set; }
    }
}