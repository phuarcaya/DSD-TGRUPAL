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
        public Nullable<System.DateTime> Fecha { get; set; }

        [DataMember]
        public Nullable<System.DateTime> FechaRegistro { get; set; }

        [DataMember]
        public Nullable<System.DateTime> FechaModificacion { get; set; }

        [DataMember]
        public Nullable<bool> Activo { get; set; }

        [DataMember]
        public Nullable<int> IdEstado { get; set; }
    }
}