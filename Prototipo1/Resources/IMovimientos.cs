using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SISCO.Presentacion.IU
{
   public  interface IMovimientos
    {
        void SISCO_Mantenimiento_Grabar();
        void SISCO_Mantenimiento_Modificar();
        void SISCO_Mantenimiento_Cancelar();
        void SISCO_Mantenimiento_Eliminar();
        void SISCO_Mantenimiento_Imprimir();
    }
}
