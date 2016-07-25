using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS_ProduccionTest
{
    class Movimiento
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string TipoMovimiento { get; set; }
        public Nullable<int> IdAlmacen { get; set; }
        public Nullable<int> IdOrdenTrabajo { get; set; }
    }
}
