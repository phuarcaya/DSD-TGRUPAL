using System.ServiceModel;
using WS_Produccion.Excepciones;
using WS_Produccion.Persistencia;
using WS_Produccion.Servicios;

namespace WS_Produccion
{

    public class OrdenesTrabajo : IOrdenTrabajo
    {
        private OrdenesDao ordenesDAO = new OrdenesDao();

        public OrdenTrabajo CrearOrdenTrabajo(OrdenTrabajo OrdenTraabajoACrear)
        {
            if (ordenesDAO.Obtener(OrdenTraabajoACrear.Id) != null) //ya existe
            {
                throw new FaultException<RepetidosExceptions>(
                    new RepetidosExceptions()
                    {
                        codigo = "101",
                        descripcion = "La orden de trabajo ya existe"
                    }, new FaultReason("Error al intentar creacion"));

            }
            return ordenesDAO.Crear(OrdenTraabajoACrear);
        }

    

        public void EliminarOrdenTrabajo(int id)
        {
            ordenesDAO.Eliminar(id);
        }

        public OrdenTrabajo ModificarOrdenTrabajo(OrdenTrabajo ordenTrabajoaAmodificar)
        {
            return ordenesDAO.Modificar(ordenTrabajoaAmodificar);
        }

        public OrdenTrabajo ObtenerOrdenTrabajo(int id)
        {
            return ordenesDAO.Obtener(id);
        }
    }
}
