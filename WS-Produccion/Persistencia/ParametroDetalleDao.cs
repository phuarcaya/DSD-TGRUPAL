using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WS_ProduccionUtilitario;

namespace WS_Produccion
{
    public class ParametroDetalleDao
    {
        public List<ParametroDetalle> Listar(int idPadre)
        {
            List<ParametroDetalle> parametroDetalleEncontrado = new List<ParametroDetalle>();
            string sql = "SELECT Id, Descripcion, IdPadre FROM ParametroDetalle WHERE IdPadre = @IdPadre";
            using (SqlConnection conexion = new SqlConnection(Utilitarios.CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@IdPadre", idPadre);
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            parametroDetalleEncontrado.Add(new ParametroDetalle()
                            {
                                Id = (int)resultado["Id"],
                                Descripcion = (string)resultado["Descripcion"],
                                IdPadre = (int)resultado["IdPadre"]
                            });
                        };
                    }
                }
            }

            return parametroDetalleEncontrado;
        }
    }
}