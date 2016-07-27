using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_Produccion.Persistencia;

namespace WS_Produccion
{

    public class ReportService : IReportService
    {
        private OrdenesDao dao = new OrdenesDao();
        public List<OrdenTrabajo> ListarOrden()
        {
            throw new NotImplementedException();
        }

        public OrdenTrabajo obtenerOrden(int id)
        {

            return dao.Obtener(id);
        }

            
    }
}
