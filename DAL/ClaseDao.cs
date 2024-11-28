using Entity;
using Mapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClaseDao
    {
        public void CargarNuevaClase(Clase clase)
        {
			try
			{
				using(SqlConnection con = new SqlConnection(ConexionDB.ObtenerConexionDB()))
				{
					con.Open();
					string query = "INSERT INTO CLASE (DESCRIPCION, DIA_CLASE, HORARIO, ENTRENADOR, CAPACIDAD_MAXIMA) VALUES (@Descripcion, @DiaClase, @Horario, @Entrenador, @CapacidadMaxima)";
					using(SqlCommand cmd = new SqlCommand(query, con))
					{
						cmd.Parameters.AddWithValue("@Descripcion", clase.Descripcion);
						cmd.Parameters.AddWithValue("@DiaClase", clase.Diadeclase);
						cmd.Parameters.AddWithValue("@Horario", clase.Horario);
						cmd.Parameters.AddWithValue("@Entrenador", clase.EntrenadorACargo);
						cmd.Parameters.AddWithValue("@CapacidadMaxima", clase.CapacidadMaxima);
						cmd.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{
				throw;
			}
        }

		public void EliminarClase(int idClase)
		{
			try
			{
                using (SqlConnection con = new SqlConnection(ConexionDB.ObtenerConexionDB()))
                {
                    con.Open();
                    string query = "DELETE FROM CLASE WHERE ID_CLASE = @IdClase";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
						cmd.Parameters.AddWithValue("@IdClase", idClase);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
			catch (Exception ex)
			{
				throw;
			}
		}

		public void ModificarClase(Clase clase)
		{
			try
			{
                using (SqlConnection con = new SqlConnection(ConexionDB.ObtenerConexionDB()))
                {
                    con.Open();
					string query = "UPDATE CLASE SET DESCRIPCION = @Descripcion, DIA_CLASE = @DiaClase, HORARIO = @Horario, ENTRENADOR = @Entrenador, CAPACIDAD_MAXIMA = @CapacidadMaxima WHERE ID_CLASE = @IdClase";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
						cmd.Parameters.AddWithValue("@IdClase", clase.IdClase);
                        cmd.Parameters.AddWithValue("@Descripcion", clase.Descripcion);
                        cmd.Parameters.AddWithValue("@DiaClase", clase.Diadeclase);
                        cmd.Parameters.AddWithValue("@Horario", clase.Horario);
                        cmd.Parameters.AddWithValue("@Entrenador", clase.EntrenadorACargo);
                        cmd.Parameters.AddWithValue("@CapacidadMaxima", clase.CapacidadMaxima);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
			catch(Exception ex)
			{
				throw;
			}
		}

		public List<Clase> GetAllClases()
		{
			try
			{
				List<Clase> listaClases = new List<Clase>();
                using (SqlConnection con = new SqlConnection(ConexionDB.ObtenerConexionDB()))
                {
                    con.Open();
                    string query = "SELECT ID_CLASE, DESCRIPCION, DIA_CLASE, HORARIO, ENTRENADOR, CAPACIDAD_MAXIMA FROM CLASE";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
						using(SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								listaClases.Add(ClaseMapper.ClaseMap(reader));
							}
						}
                    }
                }
				return listaClases;
            }
			catch (Exception ex)
			{
				throw;
			}
		}

		public Clase GetById(int idClase)
		{
			try
			{
				Clase clase = null;
                using (SqlConnection con = new SqlConnection(ConexionDB.ObtenerConexionDB()))
                {
                    con.Open();
                    string query = "SELECT ID_CLASE, DESCRIPCION, DIA_CLASE, HORARIO, ENTRENADOR, CAPACIDAD_MAXIMA FROM CLASE WHERE ID_CLASE = @IdClase";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
						cmd.Parameters.AddWithValue("@IdClase", idClase);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
								clase = ClaseMapper.ClaseMap(reader);
                            }
                        }
                    }
                }
                return clase;
            }
			catch (Exception ex)
			{
				throw;
			}
		}
    }
}
