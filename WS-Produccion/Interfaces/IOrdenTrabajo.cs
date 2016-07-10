using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS_Produccion.Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IOrdenTrabajo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IOrdenTrabajo
    {


        [OperationContract]
        OrdenTrabajo CrearOrdenTrabajo(OrdenTrabajo ordenTrabajoaACrear);

        [OperationContract]
        OrdenTrabajo ObtenerOrdenTrabajo(int id);

        [OperationContract]
        OrdenTrabajo ModificarOrdenTrabajo(OrdenTrabajo ordenTrabajoAModificar);

        [OperationContract]
        void EliminarOrdenTrabajo(int id);



    }
}
