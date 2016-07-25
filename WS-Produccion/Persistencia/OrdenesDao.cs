using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WS_Produccion.Persistencia
{
    public class OrdenesDao
    {
        public OrdenTrabajo Crear(OrdenTrabajo ordenTrabajoaAcrear)
        {
            OrdenTrabajo ordenTrabajoCreado = null;
            string sql = @"INSERT INTO OrdenTrabajo (Fecha, FechaRegistro, FechaModificacion, Activo, IdEstado)
                            VALUES (@fecha, @fecharegistro, @fechamodificacion, @activo, @idestado)";
            //            string query2 = "select @id from ordentrabajo where id = SCOPE_IDENTITY();";
            string qry2 = "select @@Identity;";
            decimal id;

            using (SqlConnection conexion = new SqlConnection(Utilitarios.CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
                    cmd.Parameters.Add(new SqlParameter("@fecha", (object)ordenTrabajoaAcrear.Fecha ?? DBNull.Value));
                    cmd.Parameters.Add(new SqlParameter("@fecharegistro", (object)ordenTrabajoaAcrear.FechaRegistro ?? DBNull.Value));
                    cmd.Parameters.Add(new SqlParameter("@fechamodificacion", (object)ordenTrabajoaAcrear.FechaModificacion ?? DBNull.Value));
                    cmd.Parameters.Add(new SqlParameter("@Activo", ordenTrabajoaAcrear.Activo));
                    cmd.Parameters.Add(new SqlParameter("@idestado", ordenTrabajoaAcrear.IdEstado));
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = qry2;
                    id = (decimal)cmd.ExecuteScalar();

                    //Guardar Detalle
                    ordenTrabajoaAcrear.ListaDetalleOrdenTrabajo.ForEach(x =>
                    {
                        x.IdOrdenTrabajo = (int)id;
                        new ordenesDetalleDAO().Crear(x);
                    });
                }
            }

            ordenTrabajoCreado = Obtener((int)id);
            return ordenTrabajoCreado;
        }

        public OrdenTrabajo Obtener(int id)
        {
            OrdenTrabajo OrdenTrabajoEncontrado = null;
            string sql = @"SELECT * FROM dbo.OrdenTrabajo WHERE Id = @id";
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
                            OrdenTrabajoEncontrado = new OrdenTrabajo()
                            {
                                Id = (int)resultado["Id"],
                                Fecha = resultado.IsDBNull(resultado.GetOrdinal("Fecha")) ? (DateTime?)null : resultado.GetDateTime(resultado.GetOrdinal("Fecha")),
                                FechaModificacion = resultado.IsDBNull(resultado.GetOrdinal("FechaModificacion")) ? (DateTime?)null : resultado.GetDateTime(resultado.GetOrdinal("FechaModificacion")),
                                FechaRegistro = resultado.IsDBNull(resultado.GetOrdinal("FechaRegistro")) ? (DateTime?)null : resultado.GetDateTime(resultado.GetOrdinal("FechaRegistro")),
                                Activo = (Boolean)resultado["Activo"],
                                IdEstado = (int)resultado["IdEstado"],
                            };
                        }
                    }
                }
            }

            OrdenTrabajoEncontrado.ListaDetalleOrdenTrabajo = new ordenesDetalleDAO().Listar(id);
            return OrdenTrabajoEncontrado;
        }

        public OrdenTrabajo Modificar(OrdenTrabajo ordenTrabajoaAmodificar)
        {

            OrdenTrabajo ordenTrabajoModificado = null;
            string sql = "UPDATE OrdenTrabajo SET fecha=@fecha, fechamodificacion=@fechamodificacion, Activo=@Activo, idestado=@idestado WHERE id=@id";
            using (SqlConnection conexion = new SqlConnection(Utilitarios.CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", ordenTrabajoaAmodificar.Id));
                    comando.Parameters.Add(new SqlParameter("@fecha", ordenTrabajoaAmodificar.Fecha));
                    comando.Parameters.Add(new SqlParameter("@fechamodificacion", ordenTrabajoaAmodificar.FechaModificacion));
                    comando.Parameters.Add(new SqlParameter("@Activo", ordenTrabajoaAmodificar.Activo));
                    comando.Parameters.Add(new SqlParameter("@idestado", ordenTrabajoaAmodificar.IdEstado));
                    comando.ExecuteNonQuery();

                    //Guardar Detalle
                    new ordenesDetalleDAO().EliminarIdOrdenTrabajo(ordenTrabajoaAmodificar.Id);
                    ordenTrabajoaAmodificar.ListaDetalleOrdenTrabajo.ForEach(x =>
                    {
                        x.IdOrdenTrabajo = ordenTrabajoaAmodificar.Id;
                        new ordenesDetalleDAO().Crear(x);
                    });
                }
            }
            ordenTrabajoModificado = Obtener(ordenTrabajoaAmodificar.Id);
            return ordenTrabajoModificado;
        }

        public void Eliminar(int id)
        {
            string sql = "DELETE FROM OrdenTrabajo WHERE anl_id=@id";
            using (SqlConnection conexion = new SqlConnection(Utilitarios.CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", id));
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<OrdenTrabajo> Listar()
        {
            List<OrdenTrabajo> ordEncontrados = new List<OrdenTrabajo>();
            OrdenTrabajo ordEncontrado = null;
            string sql = @"SELECT ot.Id, ot.Fecha, ot.FechaRegistro, ot.FechaModificacion, ot.Activo, ot.IdEstado, est.Descripcion AS Estado
                            FROM dbo.OrdenTrabajo ot
                            INNER JOIN ParametroDetalle est
	                            ON est.Id = ot.IdEstado";
            using (SqlConnection cnx = new SqlConnection(Utilitarios.CadenaConexion))
            {
                cnx.Open();
                using (SqlCommand cmm = new SqlCommand(sql, cnx))
                {
                    using (SqlDataReader resultado = cmm.ExecuteReader())
                    {
                        if (resultado.HasRows)
                        {
                            while (resultado.Read())
                            {
                                ordEncontrado = new OrdenTrabajo()
                                {
                                    Id = (int)resultado["Id"],
                                    Fecha = resultado.IsDBNull(resultado.GetOrdinal("Fecha")) ? (DateTime?)null : resultado.GetDateTime(resultado.GetOrdinal("Fecha")),
                                    FechaModificacion = resultado.IsDBNull(resultado.GetOrdinal("FechaModificacion")) ? (DateTime?)null : resultado.GetDateTime(resultado.GetOrdinal("FechaModificacion")),
                                    FechaRegistro = resultado.IsDBNull(resultado.GetOrdinal("FechaRegistro")) ? (DateTime?)null : resultado.GetDateTime(resultado.GetOrdinal("FechaRegistro")),
                                    Activo = (Boolean)resultado["Activo"],
                                    IdEstado = (int)resultado["IdEstado"],
                                    Estado = (string)resultado["Estado"]
                                };
                                ordEncontrados.Add(ordEncontrado);
                            }
                        }
                    }
                }
            }
            return ordEncontrados;
        }

    }
}