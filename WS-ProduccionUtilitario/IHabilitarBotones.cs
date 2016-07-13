using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WS_ProduccionUtilitario
{
   public interface IHabilitarBotones
    {
        void SISCO_Mantenimiento_Nuevo();
        void SISCO_Mantenimiento_Grabar();
        void SISCO_Mantenimiento_Modificar();
        void SISCO_Mantenimiento_Cancelar();
        void SISCO_Mantenimiento_EstadoBarra(bool blnEstado);
    }
}
