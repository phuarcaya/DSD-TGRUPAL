﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WS_Produccion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IReportService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IReportService
    {
        [OperationContract]
        OrdenTrabajo obtenerOrden(int id);

        [OperationContract]
        List<OrdenTrabajo> ListarEficiencia(string fechaInicial, string fechFinal);
    }
}
