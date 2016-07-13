using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_Produccion.Persistencia;

namespace WS_Produccion.Interfaces
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "OrdenTrabajo" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione OrdenTrabajo.svc o OrdenTrabajo.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class OrdenTrabajo : IOrdenTrabajo
    {
        public WS_Produccion.OrdenTrabajo CrearOrdenTrabajo(WS_Produccion.OrdenTrabajo ordenTrabajoaACrear)
        {
            throw new NotImplementedException();
        }

        public void EliminarOrdenTrabajo(int id)
        {
            throw new NotImplementedException();
        }

        public WS_Produccion.OrdenTrabajo ModificarOrdenTrabajo(WS_Produccion.OrdenTrabajo ordenTrabajoAModificar)
        {
            throw new NotImplementedException();
        }

        public WS_Produccion.OrdenTrabajo ObtenerOrdenTrabajo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
