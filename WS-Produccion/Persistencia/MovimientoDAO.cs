using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WS_Produccion.Persistencia
{
    public class MovimientoDAO
    {
        public Movimiento Crear(Movimiento MovsCrear)
        {
            Movimiento MovsCreado = null;
            string sql = "insert into movimiento values (@Fecha, @FechaRegistro, @FechaModificacion, @TipoMovimiento, @IdAlmacen, @IdOrdenTrabajo)";

            using (SqlConnection cnx = new SqlConnection(Utilitarios.CadenaConexion))
            {

                cnx.Open();
                    using (SqlCommand cmm = new SqlCommand(sql, cnx))
                    {
                        cmm.Parameters.Add(new SqlParameter("@Fecha", MovsCrear.Fecha));
                        cmm.Parameters.Add(new SqlParameter("@FechaRegistro", MovsCrear.FechaRegistro));
                        cmm.Parameters.Add(new SqlParameter("@FechaModificacion", MovsCrear.FechaModificacion));
                        cmm.Parameters.Add(new SqlParameter("@TipoMovimiento", MovsCrear.TipoMovimiento));
                        cmm.Parameters.Add(new SqlParameter("@IdAlmacen", MovsCrear.IdAlmacen));
                        cmm.Parameters.Add(new SqlParameter("@IdOrdenTrabajo", MovsCrear.IdOrdenTrabajo));
                        cmm.ExecuteNonQuery();
                    }
            }
            MovsCreado = Obtener(MovsCrear.Id);
                return MovsCreado;
            
        }

        public Movimiento Obtener(int id)
        {
            Movimiento movsEncontrado = null;
            string sql = "select * from movimiento where id = @id";
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
                            movsEncontrado = new Movimiento()
                            {
                                Id = (int)resultado["Id"],
                                Fecha = (DateTime)resultado["fecha"],
                                FechaModificacion = (DateTime)resultado["FechaModificacion"],
                                FechaRegistro = (DateTime)resultado["FechaRegistro"],
                                TipoMovimiento = (string)resultado["TipoMovimiento"],
                                IdAlmacen = (int)resultado["IdAlmacen"],
                                IdOrdenTrabajo = (int)resultado["IdOrdenTrabajo"]
                            };
                        }
                    }
                }
            }
            return movsEncontrado;

        }
        public Movimiento Modificar(Movimiento MovsModificar)
        {
            Movimiento movsModificado = null;
//            string sql = "update movimiento set tx_nombre=@nombre, tx_estado= @estado where nu_dni = @dni";
            string sql = @"UPDATE Movimiento   SET Fecha = @Fecha, FechaRegistro=@FechaRegistro, FechaModificacion = @FechaModificacion,
            TipoMovimiento = @TipoMovimiento, IdAlmacen = @IdAlmacen, IdOrdenTrabajo = @IdOrdenTrabajo WHERE id = @id";

            using (SqlConnection cnx = new SqlConnection(Utilitarios.CadenaConexion))
            {
                cnx.Open();
                using (SqlCommand cmm = new SqlCommand(sql, cnx))
                {
                    cmm.Parameters.Add(new SqlParameter("@id", MovsModificar.Id));
                    cmm.Parameters.Add(new SqlParameter("@Fecha", MovsModificar.Fecha));
                    cmm.Parameters.Add(new SqlParameter("@FechaRegistro", MovsModificar.FechaRegistro));
                    cmm.Parameters.Add(new SqlParameter("@FechaModificacion", MovsModificar.FechaModificacion));
                    cmm.Parameters.Add(new SqlParameter("@TipoMovimiento", MovsModificar.TipoMovimiento));
                    cmm.Parameters.Add(new SqlParameter("@IdAlmacen", MovsModificar.IdAlmacen));
                    cmm.Parameters.Add(new SqlParameter("@IdOrdenTrabajo", MovsModificar.IdOrdenTrabajo));
                    cmm.ExecuteNonQuery();
                }
            }
            
            movsModificado = Obtener(MovsModificar.Id);
            return movsModificado;
        }

        public void Eliminar(int id)
        {
            string sql = "delete from movimiento where id = @Id";
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

        public List<Movimiento> Listar()
        {
            List<Movimiento> movsEncontrados = new List<Movimiento>();
            Movimiento movsEncontrado = null;
            string sql = "select * from movimiento";
            using (SqlConnection cnx = new SqlConnection(Utilitarios.CadenaConexion))
            {
                cnx.Open();
                using (SqlCommand cmm = new SqlCommand(sql, cnx))
                {
                    using (SqlDataReader resultado = cmm.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            movsEncontrado = new Movimiento()
                            {
                                Id = (int)resultado["Id"],
                                Fecha = (DateTime)resultado["fecha"],
                                FechaModificacion = (DateTime)resultado["FechaModificacion"],
                                FechaRegistro = (DateTime)resultado["FechaRegistro"],
                                TipoMovimiento = (string)resultado["TipoMovimiento"],
                                IdAlmacen = (int)resultado["IdAlmacen"],
                                IdOrdenTrabajo = (int)resultado["IdOrdenTrabajo"]
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