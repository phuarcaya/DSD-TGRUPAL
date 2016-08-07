using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WS_Produccion.Excepciones;

namespace WS_Produccion.Persistencia
{
    public class MovimientoDAO
    {
        public Movimiento Crear(Movimiento MovsCrear)
        {
            Movimiento MovsCreado = null;
            string sql = @"INSERT INTO dbo.Movimiento (Fecha, FechaRegistro, TipoMovimiento, IdAlmacen, IdOrdenTrabajo)
                        VALUES (@fecha, @fecharegistro, @tipomovimiento, @idalmacen, @idordentrabajo)";
            string qry2 = "select @@Identity;";
            decimal id;

            using (SqlConnection cnx = new SqlConnection(Utilitarios.CadenaConexion))
            {
                cnx.Open();
                using (SqlCommand cmm = new SqlCommand(sql, cnx))
                {
                    cmm.Parameters.Add(new SqlParameter("@fecha", MovsCrear.Fecha));
                    cmm.Parameters.Add(new SqlParameter("@fecharegistro", MovsCrear.FechaRegistro));
                    cmm.Parameters.Add(new SqlParameter("@tipomovimiento", MovsCrear.TipoMovimiento));
                    cmm.Parameters.Add(new SqlParameter("@idalmacen", MovsCrear.IdAlmacen));
                    cmm.Parameters.Add(new SqlParameter("@idordentrabajo", MovsCrear.IdOrdenTrabajo));
                    cmm.ExecuteNonQuery();
                    cmm.CommandText = qry2;
                    id = (decimal)cmm.ExecuteScalar();

                    //Guardar Detalle
                    MovsCrear.ListaMovimientoDetalles.ForEach(x =>
                    {
                        x.IdMovimiento = (int)id;
                        new MovimientoDetalleDAO().Crear(x);
                    });
                }
            }

            MovsCreado = Obtener((int)id);
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
                                Fecha = resultado.IsDBNull(resultado.GetOrdinal("Fecha")) ? (DateTime?)null : resultado.GetDateTime(resultado.GetOrdinal("Fecha")),
                                FechaModificacion = resultado.IsDBNull(resultado.GetOrdinal("FechaModificacion")) ? (DateTime?)null : resultado.GetDateTime(resultado.GetOrdinal("FechaModificacion")),
                                FechaRegistro = resultado.IsDBNull(resultado.GetOrdinal("FechaRegistro")) ? (DateTime?)null : resultado.GetDateTime(resultado.GetOrdinal("FechaRegistro")),
                                TipoMovimiento = (string)resultado["TipoMovimiento"],
                                //IdAlmacen = (int)resultado["IdAlmacen"],
                                IdAlmacen = resultado.IsDBNull(resultado.GetOrdinal("IdAlmacen"))?(int?)null:resultado.GetInt32(resultado.GetOrdinal("IdAlmacen")),
                                //IdOrdenTrabajo = (int)resultado["IdOrdenTrabajo"]
                                IdOrdenTrabajo = resultado.IsDBNull(resultado.GetOrdinal("IdOrdenTrabajo")) ? (int?)null : resultado.GetInt32(resultado.GetOrdinal("IdOrdenTrabajo")),
                            };
                        }
                    }
                }
            }
            Errores err = new Errores();

            try
            {
                movsEncontrado.ListaMovimientoDetalles = new MovimientoDetalleDAO().Listar(id);
            }
            catch(Exception e)
            {
                err.cod = "ObtMov-0001";
                err.des = e.Message;
            }
            
            return movsEncontrado;
        }

        public Movimiento Modificar(Movimiento MovsModificar)
        {
            Movimiento movsModificado = null;
            //            string sql = "update movimiento set tx_nombre=@nombre, tx_estado= @estado where nu_dni = @dni";
            string sql = @"UPDATE Movimiento SET Fecha = @Fecha, FechaModificacion = @FechaModificacion, IdAlmacen = @IdAlmacen, IdOrdenTrabajo = @IdOrdenTrabajo WHERE id = @id";

            using (SqlConnection cnx = new SqlConnection(Utilitarios.CadenaConexion))
            {
                cnx.Open();
                using (SqlCommand cmm = new SqlCommand(sql, cnx))
                {
                    cmm.Parameters.Add(new SqlParameter("@id", MovsModificar.Id));
                    cmm.Parameters.Add(new SqlParameter("@Fecha", MovsModificar.Fecha));
                    cmm.Parameters.Add(new SqlParameter("@FechaModificacion", MovsModificar.FechaModificacion));
                    cmm.Parameters.Add(new SqlParameter("@IdAlmacen", MovsModificar.IdAlmacen));
                    cmm.Parameters.Add(new SqlParameter("@IdOrdenTrabajo", MovsModificar.IdOrdenTrabajo));
                    cmm.ExecuteNonQuery();

                    //Guardar Detalle
                    new MovimientoDetalleDAO().EliminarMovimiento(MovsModificar.Id);
                    MovsModificar.ListaMovimientoDetalles.ForEach(x =>
                    {
                        x.IdMovimiento = MovsModificar.Id;
                        new MovimientoDetalleDAO().Crear(x);
                    });
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

        public List<Movimiento> Listar(string TipoMovimiento)
        {
            List<Movimiento> movsEncontrados = new List<Movimiento>();
            Movimiento movsEncontrado = null;
            string sql = @"SELECT 
	                        mov.Id, mov.Fecha, mov.FechaRegistro, mov.FechaModificacion, mov.TipoMovimiento, mov.IdAlmacen, mov.IdOrdenTrabajo, alm.Descripcion AS Almacen
                        FROM Movimiento mov
                        INNER JOIN ParametroDetalle alm
	                        ON alm.Id = mov.IdAlmacen
                        WHERE mov.TipoMovimiento = @TipoMovimiento";
            using (SqlConnection cnx = new SqlConnection(Utilitarios.CadenaConexion))
            {
                cnx.Open();
                using (SqlCommand cmm = new SqlCommand(sql, cnx))
                {
                    cmm.Parameters.Add(new SqlParameter("@TipoMovimiento", TipoMovimiento));
                    using (SqlDataReader resultado = cmm.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            movsEncontrado = new Movimiento()
                            {
                                Id = (int)resultado["Id"],
                                Fecha = resultado.IsDBNull(resultado.GetOrdinal("Fecha")) ? (DateTime?)null : resultado.GetDateTime(resultado.GetOrdinal("Fecha")),
                                FechaModificacion = resultado.IsDBNull(resultado.GetOrdinal("FechaModificacion")) ? (DateTime?)null : resultado.GetDateTime(resultado.GetOrdinal("FechaModificacion")),
                                FechaRegistro = resultado.IsDBNull(resultado.GetOrdinal("FechaRegistro")) ? (DateTime?)null : resultado.GetDateTime(resultado.GetOrdinal("FechaRegistro")),
                                TipoMovimiento = (string)resultado["TipoMovimiento"],
                                IdAlmacen = (int)resultado["IdAlmacen"],
                                IdOrdenTrabajo = (int)resultado["IdOrdenTrabajo"],
                                Almacen = (string)resultado["Almacen"],
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