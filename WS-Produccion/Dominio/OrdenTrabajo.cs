using System;
using System.Runtime.Serialization;

namespace WS_Produccion
{
    [DataContract]
    public class OrdenTrabajo
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime Fecha { get; set; }

        [DataMember]
        public DateTime FechaRegistro { get; set; }

        [DataMember]
        public DateTime FechaModificacion { get; set; }

        [DataMember]
        public bool Activo { get; set; }

        [DataMember]
        public int IdEstado { get; set; }
    }
}