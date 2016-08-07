﻿using System;
using System.Runtime.Serialization;

namespace WS_Produccion
{

    //Prueba
    [DataContract]
    public class Articulo
    {
        [DataMember]
        public Int32 Id { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        [DataMember]
        public string TipoExistencia { get; set; }

        [DataMember]
        public Nullable<bool> Activo { get; set; }

        [DataMember]
        public Nullable<decimal> StockActual { get; set; }

        [DataMember]
        public Nullable<int> IdFormulaProduccion { get; set; }
    }
}