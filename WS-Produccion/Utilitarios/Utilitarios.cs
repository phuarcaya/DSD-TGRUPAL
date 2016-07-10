using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_Produccion
{
    public class Utilitarios
    {
        public static string CadenaConexion
        {
            get
            {
                return "Data Source=localhost;Initial Catalog=DBProduccion;Integrated Security=True";
            }
        }
    }
}