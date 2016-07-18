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
            //            string sql = "INSERT INTO OrdenTrabajo VALUES (@fecha, @fecharegistro, @fechamodificacion, @Activo, @idestado)";
            string sql = "INSERT INTO OrdenTrabajo VALUES (@fecha, @fecharegistro, @fechamodificacion, @Activo, @idestado);";// +
//            string query2 = "select @id from ordentrabajo where id = SCOPE_IDENTITY();";
            string qry2 = "select @@Identity;";
            decimal id;

            using (SqlConnection conexion = new SqlConnection(Utilitarios.CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conexion))
                {
//                    cmd.Parameters.Add(new SqlParameter("@id", ordenTrabajoaAcrear.Id));
                    cmd.Parameters.Add(new SqlParameter("@fecha", ordenTrabajoaAcrear.Fecha));
                    cmd.Parameters.Add(new SqlParameter("@fecharegistro", ordenTrabajoaAcrear.FechaRegistro));
                    cmd.Parameters.Add(new SqlParameter("@fechamodificacion", ordenTrabajoaAcrear.FechaModificacion));
                    cmd.Parameters.Add(new SqlParameter("@Activo", ordenTrabajoaAcrear.Activo));
                    cmd.Parameters.Add(new SqlParameter("@idestado", ordenTrabajoaAcrear.IdEstado));
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = qry2;
                    id = (decimal)cmd.ExecuteScalar();
                }
            }
//            ordenTrabajoCreado = Obtener(ordenTrabajoaAcrear.Id);
            ordenTrabajoCreado = Obtener((int)id);
            return ordenTrabajoCreado;
        }

        public OrdenTrabajo Obtener(int id)
        {
            OrdenTrabajo OrdenTrabajoEncontrado = null;
            string sql = "SELECT * FROM OrdenTrabajo WHERE id=@id";
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
                                Fecha = (DateTime)resultado["Fecha"],
                                FechaRegistro = (DateTime)resultado["FechaRegistro"],
                                FechaModificacion = (DateTime)resultado["FechaModificacion"],
                                Activo = (bool)resultado["Activo"],
                                IdEstado = (int)resultado["IdEstado"],
                            };
                        }
                    }
                }
            }

            return OrdenTrabajoEncontrado;
        }
        public OrdenTrabajo Modificar(OrdenTrabajo ordenTrabajoaAmodificar)
        {

            OrdenTrabajo ordenTrabajoModificado = null;
            string sql = "UPDATE OrdenTrabajo SET anl_nombre=@nombre, anl_seniority=@seniority WHERE anl_id=@id";
            using (SqlConnection conexion = new SqlConnection(Utilitarios.CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", ordenTrabajoaAmodificar.Id));
                    comando.Parameters.Add(new SqlParameter("@fecha", ordenTrabajoaAmodificar.Fecha));
                    comando.Parameters.Add(new SqlParameter("@fecharegistro", ordenTrabajoaAmodificar.FechaRegistro));
                    comando.Parameters.Add(new SqlParameter("@fechamodificacion", ordenTrabajoaAmodificar.FechaModificacion));
                    comando.Parameters.Add(new SqlParameter("@Activo", ordenTrabajoaAmodificar.Activo));
                    comando.Parameters.Add(new SqlParameter("@idestado", ordenTrabajoaAmodificar.IdEstado));
                    comando.ExecuteNonQuery();
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
            string sql = "select * from OrdenTrabajo";
            using (SqlConnection cnx = new SqlConnection(Utilitarios.CadenaConexion))
            {
                cnx.Open();
                using (SqlCommand cmm = new SqlCommand(sql, cnx))
                {
                    using (SqlDataReader resultado = cmm.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            ordEncontrado = new OrdenTrabajo()
                            {
                                Id = (int)resultado["Id"],
                                Fecha = (DateTime)resultado["Fecha"],
                                FechaModificacion = (DateTime)resultado["FechaModificacion"],
                                Activo = (Boolean)resultado["Activo"],
                                IdEstado = (int)resultado["IdEstado"]
                            };
                            ordEncontrados.Add(ordEncontrado);
                        }
                    }
                }
            }
            return ordEncontrados;
        }

    }
}