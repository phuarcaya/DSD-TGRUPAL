using System;
using System.Runtime.Serialization;
using System.Collections;
using System.Collections.Generic;

namespace WS_Produccion
{
    [DataContract]
    public class OrdenTrabajo
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime? Fecha { get; set; }

        [DataMember]
        public DateTime? FechaRegistro { get; set; }

        [DataMember]
        public DateTime? FechaModificacion { get; set; }

        [DataMember]
        public bool Activo { get; set; }

        [DataMember]
        public int? IdEstado { get; set; }

        [DataMember]
        public List<OrdenTrabajoDetalle> ListaDetalleOrdenTrabajo { get; set; }

        #region externas
        [DataMember]
        public string Estado { get; set; }

        [DataMember]
        public DateTime? FechaInicio { get; set; }

        [DataMember]
        public DateTime? FechaFinal { get; set; }

        [DataMember]
        public int NumeroDias { get; set; }

        [DataMember]
        public string Eficiencia { get; set; }

        #endregion
    }
}