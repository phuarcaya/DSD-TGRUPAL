using System.ServiceModel;
using WS_Produccion.Excepciones;
using WS_Produccion.Persistencia;
using WS_Produccion.Servicios;

namespace WS_Produccion.Interfaces
{
    public class Articulos : IArticulos
    {
        private ArticuloDao articuloDAO = new ArticuloDao();
        public Articulo Modificar(Articulo ArticuloAModificar)
        {
            return articuloDAO.Modificar(ArticuloAModificar);
        }

        public Articulo Obtener(int id)
        {
            
            if(articuloDAO.Obtener(id)== null)
            {
                throw new FaultException<SinStockExceptions>(
                    new SinStockExceptions()
                    {
                        codigo = "001",
                        descripcion = "El articulo no Existe"

                    }, new FaultReason("Error al intentar ingresar el codigo del Articulo"));
                
            }
            if (articuloDAO.Obtener(id).StockActual <= 0)
            {
                throw new FaultException<SinStockExceptions>(
                    new SinStockExceptions()
                    {
                        codigo = "002",
                        descripcion = "No hay Stock del Articulo :" + articuloDAO.Obtener(id).Id.ToString(),

                    }, new FaultReason("Error el Articulo no tiene Stock"));
            }
            return articuloDAO.Obtener(id);
        }
    }
}
