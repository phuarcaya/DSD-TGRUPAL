using System;
using System.Collections.Generic;

namespace WS_ProduccionTest
{
    public class Movimiento
    {
        
        public int Id { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string TipoMovimiento { get; set; }
        public Nullable<int> IdAlmacen { get; set; }
        public Nullable<int> IdOrdenTrabajo { get; set; }
        public List<MovimientoDetalle> ListaMovimientoDetalles { get; set; }
    }

    public class MovimientoDetalle
    {
        public int Id { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<int> IdMovimiento { get; set; }
        public Nullable<int> IdArticulo { get; set; }
        public Nullable<decimal> StockActual { get; set; }
    }
}
