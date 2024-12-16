using InventarioApi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace InventarioApi.Data
{
    public class DataArticulo
    {
        //Registrar conteos
        public static bool Registrar(Conteo oConteo)
        {
            using (SqlConnection oConexion = new SqlConnection(Clonexion.connectionBD))
            {
                SqlCommand cmd = new SqlCommand("agregarinventa_conteo", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pConteo", SqlDbType.Int).Value = oConteo.conteo;
                cmd.Parameters.AddWithValue("@plote", SqlDbType.VarChar).Value = oConteo.lote;
                cmd.Parameters.AddWithValue("@pfecha", SqlDbType.DateTime).Value = oConteo.fecha;
                cmd.Parameters.AddWithValue("@pbodega", SqlDbType.VarChar).Value = oConteo.bodega;
                cmd.Parameters.AddWithValue("@pcodigo", SqlDbType.VarChar).Value = oConteo.codigo;
                cmd.Parameters.AddWithValue("@pdescripcion", SqlDbType.VarChar).Value = oConteo.descripcion;
                cmd.Parameters.AddWithValue("@pcantidad", SqlDbType.Decimal).Value = oConteo.cantidad;
                cmd.Parameters.AddWithValue("@pproveedor", SqlDbType.VarChar).Value = oConteo.proveedor;
                cmd.Parameters.AddWithValue("@ptipo", SqlDbType.VarChar).Value = oConteo.tipo;
                cmd.Parameters.AddWithValue("@pubicacion", SqlDbType.VarChar).Value = oConteo.ubicacion;
                cmd.Parameters.AddWithValue("@prack", SqlDbType.VarChar).Value = oConteo.rack;
                cmd.Parameters.AddWithValue("@pum", SqlDbType.VarChar).Value = oConteo.um;
                cmd.Parameters.AddWithValue("@user", SqlDbType.VarChar).Value = oConteo.user;
                //cmd.Parameters.AddWithValue("@pcantidad", oConteo.cantidad);
                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch(Exception ex)
                {
                    return false;
                }
            }
        }
        //Obtener Registros por medio de un id de producto
        public static Articulos Obtener(string Busqueda)
        {
            Articulos oArticulo = new Articulos();
            using (SqlConnection oConexion = new SqlConnection(Clonexion.connectionBD))
            {
                SqlCommand cmd = new SqlCommand("BuscarArticulos", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@busqueda", Busqueda);
                try
                {
                    oConexion.Open();
                    //cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oArticulo = new Articulos()
                            {
                                ARTICULO = dr["ARTICULO"].ToString(),
                                DESCRIPCION = dr["DESCRIPCION"].ToString(),
                                PROVEEDOR = dr["PROVEEDOR"].ToString(),
                                TIPO = dr["TIPO"].ToString(),
                                UM = dr["UM"].ToString()
                            };

                        }
                    }
                    return oArticulo;
                }
                catch (Exception ex)
                {
                    return oArticulo;
                 
                }
            }
        }

        //Obtener Ubicaciones
        //Obtener UBICACIONES por medio de un id de producto
        public static List<UBICACIONES> ObtenerUbicacion(string Codigo)
        {
            List<UBICACIONES> oUbicaciones = new List<UBICACIONES>();
            using (SqlConnection oConexion = new SqlConnection(Clonexion.connectionBD))
            {
                SqlCommand cmd = new SqlCommand("BuscarUbicacion", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", Codigo);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            oUbicaciones.Add(new UBICACIONES()
                            {
                                
                                UBICACION = dr["UBICACION"].ToString(),

                            });
                        }

                    }



                    return oUbicaciones;
                }
                catch (Exception ex)
                {
                    return oUbicaciones;
                }
            }
        }
        //ObtenerLotes por medio del codigo del producto
        public static List<LOTES> ObtenerLote(string Codigo)
        {
            List<LOTES> oLotes = new List<LOTES>();
            using (SqlConnection oConexion = new SqlConnection(Clonexion.connectionBD))
            {
                SqlCommand cmd = new SqlCommand("BuscarLote", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", Codigo);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            oLotes.Add(new LOTES()
                            {

                                LOTE = dr["LOTE"].ToString(),

                            });
                        }

                    }



                    return oLotes;
                }
                catch (Exception ex)
                {
                    return oLotes;
                }
            }
        }

        public static List<Articulos> Listar()
        {
            List<Articulos> oListarArticulo = new List<Articulos>();
            using (SqlConnection oConexion = new SqlConnection(Clonexion.connectionBD))
            {
                SqlCommand cmd = new SqlCommand("usp_listar_art", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            oListarArticulo.Add(new Articulos()
                            {
                                ARTICULO =  dr["ARTICULO"].ToString(),
                                DESCRIPCION = dr["DESCRIPCION"].ToString(),
                                PROVEEDOR = dr["PROVEEDOR"].ToString(),
                                TIPO = dr["TIPO"].ToString(),
                                UM = dr["UM"].ToString()    

                            });
                        }

                    }



                    return oListarArticulo;
                }
                catch (Exception ex)
                {
                    return oListarArticulo;
                }
            }
        }

        public static List<UBICACIONES> ListarUbicacion()
        {
            List<UBICACIONES> oListarUbicacion = new List<UBICACIONES>();
            using (SqlConnection oConexion = new SqlConnection(Clonexion.connectionBD))
            {
                SqlCommand cmd = new SqlCommand("SP_LISTAR_UBICACION", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            oListarUbicacion.Add(new UBICACIONES()
                            {
                                UBICACION = dr["UBICACION"].ToString(),
                                

                            });
                        }

                    }



                    return oListarUbicacion;
                }
                catch (Exception ex)
                {
                    return oListarUbicacion;
                }
            }
        }
        //ListarRacks
        public static List<RACKS> ListaRacks()
        {
            List<RACKS> oListarRacks = new List<RACKS>();
            using (SqlConnection oConexion = new SqlConnection(Clonexion.connectionBD))
            {
                SqlCommand cmd = new SqlCommand("BuscarRack", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            oListarRacks.Add(new RACKS()
                            {
                                RACK = dr["RACK"].ToString(),


                            });
                        }

                    }



                    return oListarRacks;
                }
                catch (Exception ex)
                {
                    return oListarRacks;
                }
            }
        }

        //ListarBodegas
        public static List<BODEGAS> ListaBodegas()
        {
            List<BODEGAS> oListarBodegas = new List<BODEGAS>();
            using (SqlConnection oConexion = new SqlConnection(Clonexion.connectionBD))
            {
                SqlCommand cmd = new SqlCommand("BuscarBodega", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            oListarBodegas.Add(new BODEGAS()
                            {
                                CODIGO = dr["CODIGO"].ToString(),


                            });
                        }

                    }



                    return oListarBodegas;
                }
                catch (Exception ex)
                {
                    return oListarBodegas;
                }
            }
        }

        //ListarUsuarios
        public static List<USUARIOS> ListaUsuarios()
        {
            List<USUARIOS> oListarUsuarios = new List<USUARIOS>();
            using (SqlConnection oConexion = new SqlConnection(Clonexion.connectionBD))
            {
                SqlCommand cmd = new SqlCommand("BuscarUsuario", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            oListarUsuarios.Add(new USUARIOS()
                            {
                                NOMBRE = dr["NOMBRE"].ToString(),


                            });
                        }

                    }



                    return oListarUsuarios;
                }
                catch (Exception ex)
                {
                    return oListarUsuarios;
                }
            }
        }

        //ListarConteos
        public static List<CONTEOS> ListaConteos()
        {
            List<CONTEOS> ocont = new List<CONTEOS>();
            using (SqlConnection oConexion = new SqlConnection(Clonexion.connectionBD))
            {
                SqlCommand cmd = new SqlCommand("BuscarConteos", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            ocont.Add(new CONTEOS()
                            {
                                CONTEO = dr["CONTEO"].ToString(),


                            });
                        }

                    }



                    return ocont;
                }
                catch (Exception ex)
                {
                    return ocont;
                }
            }
        }

    }
}