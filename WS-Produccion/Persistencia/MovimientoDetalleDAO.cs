using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WS_Produccion.Persistencia
{
    public class MovimientoDetalleDAO
    {
        public void Crear(MovimientoDetalle MovsDCrear)
        {
            string sql = @"INSERT INTO dbo.MovimientoDetalle (Cantidad, IdMovimiento, IdArticulo)
                            VALUES (@cantidad, @idmovimiento, @idarticulo)";

            using (SqlConnection cnx = new SqlConnection(Utilitarios.CadenaConexion))
            {
                cnx.Open();
                using (SqlCommand cmm = new SqlCommand(sql, cnx))
                {
                    cmm.Parameters.Add(new SqlParameter("@IdArticulo", MovsDCrear.IdArticulo));
                    cmm.Parameters.Add(new SqlParameter("@IdMovimiento", MovsDCrear.IdMovimiento));
                    cmm.Parameters.Add(new SqlParameter("@Cantidad", MovsDCrear.Cantidad));
                    cmm.ExecuteNonQuery();
                }
            }
        }

        public MovimientoDetalle Obtener(int id)
        {
            MovimientoDetalle movsEncontrado = null;
            string sql = "select * from MovimientoDetalle where id = @id";
            using (SqlConnection cnx = new SqlConnection(Utilitarios.CadenaConexion))
            {
                cnx.Open();
                using (SqlCommand cmm = new SqlCommand(sql, cnx))
                {
                    cmm.Parameters.Add(new SqlParameter("@id", id));
                    using (SqlDataReader resultado = cmm.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            movsEncontrado = new MovimientoDetalle()
                            {
                                Id = (int)resultado["Id"],
                                IdArticulo = (int)resultado["IdArticulo"],
                                IdMovimiento = (int)resultado["IdMovimiento"],
                                Cantidad = (Decimal)resultado["Cantidad"]
                            };
                        }
                    }
                }
            }
            return movsEncontrado;

        }
        public void Modificar(MovimientoDetalle MovsDModificar)
        {
            string sql = @"UPDATE MovimientoDetalle SET IdArticulo = @IdArticulo, Cantidad = @Cantidad WHERE id = @id";

            using (SqlConnection cnx = new SqlConnection(Utilitarios.CadenaConexion))
            {
                cnx.Open();
                using (SqlCommand cmm = new SqlCommand(sql, cnx))
                {
                    cmm.Parameters.Add(new SqlParameter("@id", MovsDModificar.Id));
                    cmm.Parameters.Add(new SqlParameter("@IdArticulo", MovsDModificar.IdArticulo));
                    cmm.Parameters.Add(new SqlParameter("@Cantidad", MovsDModificar.Cantidad));
                    cmm.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id)
        {
            string sql = "delete from MovimientoDetalle where id = @Id";
            using (SqlConnection cnx = new SqlConnection(Utilitarios.CadenaConexion))
            {
                cnx.Open();
                using (SqlCommand cmm = new SqlCommand(sql, cnx))
                {
                    cmm.Parameters.Add(new SqlParameter("@Id", id));
                    cmm.ExecuteNonQuery();
                }
            }
        }

        public void EliminarMovimiento(int idMovimiento)
        {
            string sql = "delete from MovimientoDetalle where IdMovimiento = @IdMovimiento";
            using (SqlConnection cnx = new SqlConnection(Utilitarios.CadenaConexion))
            {
                cnx.Open();
                using (SqlCommand cmm = new SqlCommand(sql, cnx))
                {
                    cmm.Parameters.Add(new SqlParameter("@IdMovimiento", idMovimiento));
                    cmm.ExecuteNonQuery();
                }
            }
        }

        public List<MovimientoDetalle> Listar(int idMovimiento)
        {
            List<MovimientoDetalle> movsEncontrados = new List<MovimientoDetalle>();
            MovimientoDetalle movsEncontrado = null;
            string sql = @"SELECT movd.Id, movd.Cantidad, movd.IdMovimiento, movd.IdArticulo, art.Descripcion AS Articulo, art.StockActual
                            FROM MovimientoDetalle movd
                            INNER JOIN Articulo art
	                            ON art.Id = movd.IdArticulo
                            WHERE movd.IdMovimiento = @IdMovimiento";
            using (SqlConnection cnx = new SqlConnection(Utilitarios.CadenaConexion))
            {
                cnx.Open();
                using (SqlCommand cmm = new SqlCommand(sql, cnx))
                {
                    cmm.Parameters.Add(new SqlParameter("@IdMovimiento", idMovimiento));
                    using (SqlDataReader resultado = cmm.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            movsEncontrado = new MovimientoDetalle()
                            {
                                Id = (int)resultado["Id"],
                                IdArticulo = (int)resultado["IdArticulo"],
                                IdMovimiento = (int)resultado["IdMovimiento"],
                                Cantidad = (Decimal)resultado["Cantidad"],
                                Articulo = (string)resultado["Articulo"],
                                StockActual = resultado.IsDBNull(resultado.GetOrdinal("StockActual")) ? (decimal?)null : resultado.GetDecimal(resultado.GetOrdinal("StockActual"))
                            };
                            movsEncontrados.Add(movsEncontrado);
                        }
                    }
                }
            }

            return movsEncontrados;
        }
    }
}