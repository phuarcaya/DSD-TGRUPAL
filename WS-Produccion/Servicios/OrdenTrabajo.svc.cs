using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_Produccion.Excepciones;
using WS_Produccion.Persistencia;

namespace WS_Produccion.Servicios
{

    public class OrdenTrabajo : IOrdenTrabajo
    {
        //comentario
        private OrdenesDao ordenesDAO = new OrdenesDao();

        public OrdenTrabajo CrearOrdenTrabajo(OrdenTrabajo OrdenTraabajoACrear)
        {
            if (ordenesDAO.Obtener(OrdenTraabajoACrear.id) != null) //ya existe
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
