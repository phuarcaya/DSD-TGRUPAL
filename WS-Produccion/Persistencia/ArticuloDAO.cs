using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WS_Produccion.Persistencia
{
    public class ArticuloDao
    {
        public Articulo Crear(Articulo articuloACrear)
        {
            Articulo articuloCreado = null;
            string sql = "INSERT INTO Articulo (id, Descripcion, TipoExistencia, StockActual, IdFormulaProduccion) VALUES (@id, @Descripcion, @TipoExistencia, @StockActual, @IdFormulaProduccion)";
            using (SqlConnection conexion = new SqlConnection(Utilitarios.CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", articuloACrear.Id));
                    comando.Parameters.Add(new SqlParameter("@Descripcion", articuloACrear.Descripcion));
                    comando.Parameters.Add(new SqlParameter("@TipoExistencia", articuloACrear.TipoExistencia));
                    comando.Parameters.Add(new SqlParameter("@StockActual", articuloACrear.StockActual));
                    comando.Parameters.Add(new SqlParameter("@Activo", articuloACrear.Activo));
                    comando.Parameters.Add(new SqlParameter("@IdFormulaProduccion", articuloACrear.IdFormulaProduccion));

                    comando.ExecuteNonQuery();

                }

            }
            articuloCreado = Obtener(articuloACrear.Id);
            return articuloCreado;
        }

        public Articulo Modificar(Articulo articuloAmodificar)
        {
            Articulo articuloModificado = null;
            string sql = "UPDATE Articulo SET Descripcion=@Descripcion, TipoExistencia=@TipoExistencia, StockActual=@StockActual,Activo=@Activo,IdFormulaProduccion=@IdFormulaProduccion  WHERE id =@Id";
            using (SqlConnection conexion = new SqlConnection(Utilitarios.CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", articuloAmodificar.Id));
                    comando.Parameters.Add(new SqlParameter("@Descripcion", articuloAmodificar.Descripcion));
                    comando.Parameters.Add(new SqlParameter("@TipoExistencia", articuloAmodificar.TipoExistencia));
                    comando.Parameters.Add(new SqlParameter("@StockActual", articuloAmodificar.StockActual));
                    comando.Parameters.Add(new SqlParameter("@Activo", articuloAmodificar.Activo));
                    comando.Parameters.Add(new SqlParameter("@IdFormulaProduccion", articuloAmodificar.IdFormulaProduccion));

                    comando.ExecuteNonQuery();

                }

            }
            articuloModificado = Obtener(articuloAmodificar.Id);
            return articuloModificado;
        }

        public Articulo Obtener(Int32 id)
        {
            Articulo articuloEncontrado = null;
            string sql = "SELECT * FROM Articulo WHERE id=@id";
            using (SqlConnection conexion = new SqlConnection(Utilitarios.CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", id));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            articuloEncontrado = new Articulo()
                            {
                                Id = (Int32)resultado["Id"],
                                Descripcion = (string)resultado["Descripcion"],
                                TipoExistencia = (string)resultado["TipoExistencia"],
                                StockActual = (decimal)resultado["StockActual"],
                                Activo = (bool)resultado["Activo"],
                                IdFormulaProduccion = (Int32)resultado["IdFormulaProduccion"],

                            };
                        }
                    }
                }

            }

            return articuloEncontrado;
        }

        public List<Articulo> Listar(string tipoExistencia)
        {
            List<Articulo> articuloEncontrado = new List<Articulo>();
            string sql = "SELECT * FROM Articulo WHERE TipoExistencia = @tipoExistencia";
            using (SqlConnection conexion = new SqlConnection(Utilitarios.CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@tipoExistencia", tipoExistencia));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            var articulo = new Articulo()
                            {
                                Id = (Int32)resultado["Id"],
                                Descripcion = (string)resultado["Descripcion"],
                                TipoExistencia = (string)resultado["TipoExistencia"],
                                StockActual = (decimal)resultado["StockActual"],
                                Activo = (bool)resultado["Activo"],
                                IdFormulaProduccion = (Int32)resultado["IdFormulaProduccion"],
                            };

                            articuloEncontrado.Add(articulo);
                        }
                    }
                }
            }

            return articuloEncontrado;
        }

    }
}