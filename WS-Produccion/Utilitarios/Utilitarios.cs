﻿using System;
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
                //private string cadenaConexion = "Data Source=(local);Initial Catalog=DBproduccion;Integrated Security=SSPI";
                //return "Data Source=(local);Initial Catalog=DBProduccion;Integrated Security=True";
                //return "Data Source=PHC;Initial Catalog=DBProduccion;Integrated Security=True"; //funciona
                // no borrar la cadena de conexion solo comentarla
                return "Data Source=10.4.40.131\\EDI_DESA;Initial Catalog=EDI_XXX;Persist Security Info=True;User ID=harwer;Password=harwer"; //funciona

            }
        }
    }
}