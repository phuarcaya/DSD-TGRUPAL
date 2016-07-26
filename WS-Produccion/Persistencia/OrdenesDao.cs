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

        public List<OrdenTrabajo> Listar(string idsEstado)
        {
            List<OrdenTrabajo> ordEncontrados = new List<OrdenTrabajo>();
            OrdenTrabajo ordEncontrado = null;
            string sql = @"SELECT ot.Id, ot.Fecha, ot.FechaRegistro, ot.FechaModificacion, ot.Activo, ot.IdEstado, est.Descripcion AS Estado
                            FROM dbo.OrdenTrabajo ot
                            INNER JOIN ParametroDetalle est
	                            ON est.Id = ot.IdEstado
                        WHERE ((@IdEstado = '') OR (ot.IdEstado IN(@IdEstado)))";
            using (SqlConnection cnx = new SqlConnection(Utilitarios.CadenaConexion))
            {
                cnx.Open();
                using (SqlCommand cmm = new SqlCommand(sql, cnx))
                {
                    cmm.Parameters.Add(new SqlParameter("@IdEstado", idsEstado));
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

        public List<MovimientoDetalle> ListarLineaProduccion(int idOrdenTrabajo)
        {
            List<MovimientoDetalle> ordEncontrados = new List<MovimientoDetalle>();
            MovimientoDetalle ordEncontrado = null;
            string sql = @"SELECT 
	                        otd.IdArticulo, otd.Cantidad, art.Descripcion AS Articulo, art.StockActual
                        FROM OrdenTrabajoDetalle otd
                        INNER JOIN Articulo art
	                        ON art.Id = otd.IdArticulo
                        WHERE otd.IdOrdenTrabajo = @IdOrdenTrabajo";
            using (SqlConnection cnx = new SqlConnection(Utilitarios.CadenaConexion))
            {
                cnx.Open();
                using (SqlCommand cmm = new SqlCommand(sql, cnx))
                {
                    cmm.Parameters.Add(new SqlParameter("@IdOrdenTrabajo", idOrdenTrabajo));
                    using (SqlDataReader resultado = cmm.ExecuteReader())
                    {
                        if (resultado.HasRows)
                        {
                            while (resultado.Read())
                            {
                                ordEncontrado = new MovimientoDetalle()
                                {
                                    IdArticulo = (int?)resultado["IdArticulo"],
                                    Cantidad = (decimal?)resultado["Cantidad"],
                                    Articulo = (string)resultado["Articulo"],
                                    StockActual = (decimal?)resultado["StockActual"],
                                };
                                ordEncontrados.Add(ordEncontrado);
                            }
                        }
                    }
                }
            }
            return ordEncontrados;
        }

        public List<MovimientoDetalle> ListarMaterialesOrdenTrabajo(int idOrdenTrabajo)
        {
            List<MovimientoDetalle> ordEncontrados = new List<MovimientoDetalle>();
            MovimientoDetalle ordEncontrado = null;
            string sql = @"SELECT 
	                            mat.IdArticulo, mat.Cantidad, art.Descripcion AS Articulo, art.StockActual
                            FROM OrdenTrabajoDetalle otd
                            INNER JOIN Articulo lprod
	                            ON lprod.Id = otd.IdArticulo
                            INNER JOIN ArticuloFormulaProduccion mat
	                            ON mat.IdFormulaProduccion = lprod.IdFormulaProduccion
                            INNER JOIN Articulo art
	                            ON art.Id = mat.IdArticulo
                            WHERE otd.IdOrdenTrabajo = @IdOrdenTrabajo";
            using (SqlConnection cnx = new SqlConnection(Utilitarios.CadenaConexion))
            {
                cnx.Open();
                using (SqlCommand cmm = new SqlCommand(sql, cnx))
                {
                    cmm.Parameters.Add(new SqlParameter("@IdOrdenTrabajo", idOrdenTrabajo));
                    using (SqlDataReader resultado = cmm.ExecuteReader())
                    {
                        if (resultado.HasRows)
                        {
                            while (resultado.Read())
                            {
                                ordEncontrado = new MovimientoDetalle()
                                {
                                    IdArticulo = (int?)resultado["IdArticulo"],
                                    Cantidad = (decimal?)resultado["Cantidad"],
                                    Articulo = (string)resultado["Articulo"],
                                    StockActual = (decimal?)resultado["StockActual"],
                                };
                                ordEncontrados.Add(ordEncontrado);
                            }
                        }
                    }
                }
            }
            return ordEncontrados;
        }

        public void ModificarEstado(int idOrdenTrabajo, int idEstado)
        {
            OrdenTrabajo ordenTrabajoModificado = null;
            string sql = "UPDATE OrdenTrabajo SET IdEstado=@idestado WHERE id=@id";
            using (SqlConnection conexion = new SqlConnection(Utilitarios.CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", idOrdenTrabajo));
                    comando.Parameters.Add(new SqlParameter("@idestado", idEstado));
                    comando.ExecuteNonQuery();
                }
            }
        }

    }
}