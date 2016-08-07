﻿using System;
using System.Runtime.Serialization;

namespace WS_Produccion
{
    [DataContract]
    public class ArticuloFormulaProduccion
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public Nullable<decimal> Cantidad { get; set; }

        [DataMember]
        public Nullable<int> IdArticulo { get; set; }

        [DataMember]
        public Nullable<int> IdFormulaProduccion { get; set; }
    }
}