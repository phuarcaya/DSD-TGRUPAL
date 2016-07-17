using System;
using System.Collections.Generic;
using WS_Produccion.Persistencia;

namespace WS_Produccion.Servicios
{
    public class OrdenTrabajos : IOrdenTrabajos, IOrdenTrabajoDetalle
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
            return ordDAO.Listar();
        }

        public OrdenTrabajo modificarOrd(OrdenTrabajo ordModificar)
        {
            return ordDAO.Modificar(ordModificar);
        }

        public OrdenTrabajo obtenerOrd(int id)
        {
            return ordDAO.Obtener(id);
        }

        //-----------------------------------Detalle------------------
        private ordenesDetalleDAO ordDetDAO = new ordenesDetalleDAO();
        
        List<OrdenTrabajoDetalle> IOrdenTrabajoDetalle.listarOrdDet()
        {
            return ordDetDAO.Listar();
        }

        OrdenTrabajoDetalle IOrdenTrabajoDetalle.crearOrdDet(OrdenTrabajoDetalle ordDetCrear)
        {
            return ordDetDAO.Crear(ordDetCrear);
        }

        OrdenTrabajoDetalle IOrdenTrabajoDetalle.obtenerOrdDet(int id)
        {
            return ordDetDAO.Obtener(id);
        }

        OrdenTrabajoDetalle IOrdenTrabajoDetalle.modificarOrdDet(OrdenTrabajoDetalle ordDetModificar)
        {
            return ordDetDAO.Modificar(ordDetModificar);
        }

        void IOrdenTrabajoDetalle.eliminarOrdDet(int id)
        {
            ordDetDAO.Eliminar(id);
        }
    }

}
