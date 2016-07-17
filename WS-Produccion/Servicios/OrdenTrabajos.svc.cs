using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_Produccion.Persistencia;

namespace WS_Produccion.Servicios
{
    public class OrdenTrabajos : IOrdenTrabajos
    {
        private OrdenesDao ordDAO = new OrdenesDao();

        public OrdenTrabajo crearOrd(OrdenTrabajo ordCrear)
        {
            return ordDAO.Crear(ordCrear);
        }

        public void eliminarOrd(int id)
        {
            ordDAO.Eliminar(id);
        }

        public List<OrdenTrabajo> listarOrd()
        {
            throw new NotImplementedException();
        }

        public OrdenTrabajo modificarOrd(OrdenTrabajo ordModificar)
        {
            return ordDAO.Modificar(ordModificar);
        }

        public OrdenTrabajo obtenerOrd(int id)
        {
            return ordDAO.Obtener(id);
        }

        public static implicit operator OrdenTrabajos(OrdenTrabajo v)
        {
            throw new NotImplementedException();
        }
    }

}
