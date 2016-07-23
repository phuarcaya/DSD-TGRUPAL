﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WS_Produccion.Persistencia
{
    public class ordenesDetalleDAO
    {
        public OrdenTrabajoDetalle Crear(OrdenTrabajoDetalle ordenTraDetAcrear)
        {
            OrdenTrabajoDetalle ordenTraDetCreado = null;
            string sql = "INSERT INTO OrdenTrabajoDetalle VALUES (@IdOrdenTrabajo, @IdArticulo, @Cantidad)";
            using (SqlConnection conexion = new SqlConnection(Utilitarios.CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    //comando.Parameters.Add(new SqlParameter("@id", ordenTraDetAcrear.Id));
                    comando.Parameters.Add(new SqlParameter("@IdOrdenTrabajo", ordenTraDetAcrear.IdOrdenTrabajo));
                    comando.Parameters.Add(new SqlParameter("@IdArticulo", ordenTraDetAcrear.IdArticulo));
                    comando.Parameters.Add(new SqlParameter("@Cantidad", ordenTraDetAcrear.Cantidad));
                    comando.ExecuteNonQuery();
                }
            }
            ordenTraDetCreado = Obtener(ordenTraDetAcrear.Id);
            return ordenTraDetCreado;
        }

        public OrdenTrabajoDetalle Obtener(int id)
        {
            OrdenTrabajoDetalle OrdenTrabajoEncontrado = null;
            string sql = "SELECT * FROM OrdenTrabajoDetalle WHERE id=@id";
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
                            OrdenTrabajoEncontrado = new OrdenTrabajoDetalle()
                            {
                                Id = (int)resultado["Id"],
                                IdOrdenTrabajo = (int)resultado["IdOrdenTrabajo"],
                                IdArticulo = (int)resultado["IdArticulo"],
                                Cantidad = (decimal)resultado["Cantidad"]
                            };
                        }
                    }
                }
            }

            return OrdenTrabajoEncontrado;
        }
        public OrdenTrabajoDetalle Modificar(OrdenTrabajoDetalle ordenTraDetmodificar)
        {

            OrdenTrabajoDetalle ordenTrabajoModificado = null;
            string sql = "UPDATE OrdenTrabajoDetalle SET IdOrdenTrabajo=@IdOrdenTrabajo, Cantidad=@Cantidad, IdArticulo=@IdArticulo WHERE id=@id";
            using (SqlConnection conexion = new SqlConnection(Utilitarios.CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", ordenTraDetmodificar.Id));
                    comando.Parameters.Add(new SqlParameter("@IdOrdenTrabajo", ordenTraDetmodificar.IdOrdenTrabajo));
                    comando.Parameters.Add(new SqlParameter("@IdArticulo", ordenTraDetmodificar.IdArticulo));
                    comando.Parameters.Add(new SqlParameter("@Cantidad", ordenTraDetmodificar.Cantidad));
                    comando.ExecuteNonQuery();
                }
            }
            ordenTrabajoModificado = Obtener(ordenTraDetmodificar.Id);
            return ordenTrabajoModificado;
        }

        public void Eliminar(int id)
        {
            string sql = "DELETE FROM OrdenTrabajoDetalle WHERE id=@id";
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

        public List<OrdenTrabajoDetalle> Listar(int idOrdenTrabajo)
        {
            List<OrdenTrabajoDetalle> ordDetEncontrados = new List<OrdenTrabajoDetalle>();
            OrdenTrabajoDetalle ordDetEncontrado = null;
            string sql = @"SELECT 
	                            otd.Id,otd.IdOrdenTrabajo,otd.Cantidad,otd.IdArticulo, art.Descripcion AS Articulo
                            FROM OrdenTrabajoDetalle otd
                            INNER JOIN Articulo art
	                            ON art.Id = otd.IdArticulo
                            WHERE otd.IdOrdenTrabajo = @idOrdenTrabajo";
            using (SqlConnection cnx = new SqlConnection(Utilitarios.CadenaConexion))
            {
                cnx.Open();
                using (SqlCommand cmm = new SqlCommand(sql, cnx))
                {
                    cmm.Parameters.Add(new SqlParameter("@idOrdenTrabajo", idOrdenTrabajo));
                    using (SqlDataReader resultado = cmm.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            ordDetEncontrado = new OrdenTrabajoDetalle()
                            {
                                Id = (int)resultado["Id"],
                                IdOrdenTrabajo = (int)resultado["IdOrdenTrabajo"],
                                IdArticulo = (int)resultado["IdArticulo"],
                                Cantidad = (Decimal)resultado["Cantidad"],
                                Articulo = (string)resultado["Articulo"]
                            };
                            ordDetEncontrados.Add(ordDetEncontrado);

                        }
                    }
                }
            }
            return ordDetEncontrados;
        }
    }
}