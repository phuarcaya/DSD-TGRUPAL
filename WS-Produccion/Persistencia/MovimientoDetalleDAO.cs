using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WS_Produccion.Persistencia
{
    public class MovimientoDetalleDAO
    {
        public MovimientoDetalle Crear(MovimientoDetalle MovsDCrear)
        {
            MovimientoDetalle MovsDCreado = null;
            string sql = "insert into MovimientoDetalle values (@IdArticulo, @IdMovimiento, @Cantidad)";

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
            MovsDCreado = Obtener(MovsDCrear.Id);
            return MovsDCreado;
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
        public MovimientoDetalle Modificar(MovimientoDetalle MovsDModificar)
        {
            MovimientoDetalle movsModificado = null;
            //            string sql = "update MovimientoDetalle set tx_nombre=@nombre, tx_estado= @estado where nu_dni = @dni";
            string sql = @"UPDATE MovimientoDetalle SET IdArticulo = @IdArticulo, IdMovimiento=@IdMovimiento, Cantidad = @Cantidad WHERE id = @id";

            using (SqlConnection cnx = new SqlConnection(Utilitarios.CadenaConexion))
            {
                cnx.Open();
                using (SqlCommand cmm = new SqlCommand(sql, cnx))
                {
                    cmm.Parameters.Add(new SqlParameter("@id", MovsDModificar.Id));
                    cmm.Parameters.Add(new SqlParameter("@IdArticulo", MovsDModificar.IdArticulo));
                    cmm.Parameters.Add(new SqlParameter("@IdMovimiento", MovsDModificar.IdMovimiento));
                    cmm.Parameters.Add(new SqlParameter("@Cantidad", MovsDModificar.Cantidad));
                    cmm.ExecuteNonQuery();
                }
            }

            movsModificado = Obtener(MovsDModificar.Id);
            return movsModificado;
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

        public List<MovimientoDetalle> Listar()
        {
            List<MovimientoDetalle> movsEncontrados = new List<MovimientoDetalle>();
            MovimientoDetalle movsEncontrado = null;
            string sql = "select * from MovimientoDetalle";
            using (SqlConnection cnx = new SqlConnection(Utilitarios.CadenaConexion))
            {
                cnx.Open();
                using (SqlCommand cmm = new SqlCommand(sql, cnx))
                {
                    using (SqlDataReader resultado = cmm.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            movsEncontrado = new MovimientoDetalle()
                            {
                                Id = (int)resultado["Id"],
                                IdArticulo = (int)resultado["IdArticulo"],
                                IdMovimiento = (int)resultado["IdMovimiento"],
                                Cantidad = (Decimal)resultado["Cantidad"]
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