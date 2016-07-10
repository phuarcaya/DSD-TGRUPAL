using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WS_Produccion
{
    [DataContract]
    public class MovimientoDetalle
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public Nullable<decimal> Cantidad { get; set; }

        [DataMember]
        public Nullable<int> IdMovimiento { get; set; }

        [DataMember]
        public Nullable<int> IdArticulo { get; set; }
    }
}