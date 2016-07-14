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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "OrdenTrabajo" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione OrdenTrabajo.svc o OrdenTrabajo.svc.cs en el Explorador de soluciones e inicie la depuración.
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
