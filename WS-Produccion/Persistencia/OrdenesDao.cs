using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WS_Produccion.Persistencia
{
    public class OrdenesDao
    {

        private string cadenaConexion = "Data Source=(local);Initial Catalog=DBproduccion;Integrated Security=SSPI";
        public OrdenTrabajo Crear(OrdenTrabajo ordenTrabajoaAcrear)
        {
            OrdenTrabajo ordenTrabajoCreado = null;
            string sql = "INSERT INTO OrdenTrabajo VALUES (@id, @fecha, @fecharegistro, @fechamodificacion, @Activo, @idestado)";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", ordenTrabajoaAcrear.Id));
                    comando.Parameters.Add(new SqlParameter("@fecha", ordenTrabajoaAcrear.Fecha));
                    comando.Parameters.Add(new SqlParameter("@fecharegistro", ordenTrabajoaAcrear.FechaRegistro));
                    comando.Parameters.Add(new SqlParameter("@fechamodificacion", ordenTrabajoaAcrear.FechaModificacion));
                    comando.Parameters.Add(new SqlParameter("@Activo", ordenTrabajoaAcrear.Activo));
                    comando.Parameters.Add(new SqlParameter("@idestado", ordenTrabajoaAcrear.IdEstado));
                    comando.ExecuteNonQuery();
                }
            }
            ordenTrabajoCreado = Obtener(ordenTrabajoaAcrear.Id);
            return ordenTrabajoCreado;
        }

        public OrdenTrabajo Obtener(int id)
        {
            OrdenTrabajo OrdenTrabajoEncontrado = null;
            string sql = "SELECT * FROM OrdenTrabajo WHERE id=@id";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
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
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
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
            string sql = "DELETE FROM  OrdenTrabajo WHERE anl_id=@id";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", id));
                    comando.ExecuteNonQuery();


                }
            }
        }

    }
}