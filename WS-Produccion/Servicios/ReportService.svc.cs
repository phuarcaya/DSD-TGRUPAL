using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_Produccion.Excepciones;
using WS_Produccion.Persistencia;

namespace WS_Produccion
{

    public class ReportService : IReportService
    {
        private OrdenesDao dao = new OrdenesDao();

        public OrdenTrabajo obtenerOrden(int id)
        {

            return dao.Obtener(id);
        }

        public List<OrdenTrabajo> ListarEficiencia(string fechaInicial, string fechFinal)
        {
            if (string.IsNullOrEmpty(fechaInicial))
            {
                throw new FaultException<validacionFecha>(new validacionFecha()
                {
                    codigo = "101",
                    descripcion = "No ha ingresado la fecha inicio"
                },
               new FaultReason("Error de consulta de eficiencia"));
            }

            if (string.IsNullOrEmpty(fechFinal))
            {
                throw new FaultException<validacionFecha>(new validacionFecha()
                {
                    codigo = "101",
                    descripcion = "No ha ingresado la fecha final"
                },
               new FaultReason("Error de consulta de eficiencia"));
            }

            return dao.ListarEficiencia(fechaInicial, fechFinal);
        }
    }
}
