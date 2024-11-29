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
    public class InscripcionDao
    {
        private ClaseDao ClaseDao = new ClaseDao();
        private MiembroDao MiembroDao = new MiembroDao();

        public void CargarInscripcion(Inscripcion inscripcion)
        {
            try 
            {
                using(SqlConnection con = new SqlConnection(ConexionDB.ObtenerConexionDB()))
                {
                    con.Open();
                    string query = "INSERT INTO CLASE_MIEMBRO (ID_CLASE, ID_MIEMBRO, FECHA_INSCRIPCION, FECHA_VENCIMIENTO) VALUES (@IdClase, @IdMiembro, @FechaInscripcion, @FechaVencimiento)";
                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@IdClase", inscripcion.Clase.IdClase);
                        cmd.Parameters.AddWithValue("@IdMiembro", inscripcion.Miembro.IdMiembro);
                        cmd.Parameters.AddWithValue("@FechaInscripcion", inscripcion.FechaInscripcion);
                        cmd.Parameters.AddWithValue("@FechaVencimiento", inscripcion.FechaVencimiento);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public void EliminarInscripcion(int idClase, int idMiembro)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConexionDB.ObtenerConexionDB()))
                {
                    con.Open();
                    string query = "DELETE FROM CLASE_MIEMBRO WHERE ID_CLASE = @IdClase AND ID_MIEMBRO = @IdMiembro";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@IdClase", idClase);
                        cmd.Parameters.AddWithValue("@IdMiembro", idMiembro);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ModificarFechaVencimiento(int idClase, int idMiembro, DateTime nuevaFechaVencimiento)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConexionDB.ObtenerConexionDB()))
                {
                    con.Open();
                    string query = "UPDATE CLASE_MIEMBRO SET FECHA_VENCIMIENTO = @FechaVencimiento WHERE ID_CLASE = @IdClase AND ID_MIEMBRO = @IdMiembro";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@IdClase", idClase);
                        cmd.Parameters.AddWithValue("@IdMiembro", idMiembro);
                        cmd.Parameters.AddWithValue("@FechaVencimiento", nuevaFechaVencimiento);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Inscripcion> GetAll()
        {
            try
            {
                List<Inscripcion> listaInscripciones = new List<Inscripcion>();
                using (SqlConnection con = new SqlConnection(ConexionDB.ObtenerConexionDB()))
                {
                    con.Open();
                    string query = "SELECT ID_CLASE, ID_MIEMBRO, FECHA_VENCIMIENTO, FECHA_INSCRIPCION FROM CLASE_MIEMBRO";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Inscripcion inscripcion = InscripcionMapper.Map(reader);
                                inscripcion.Clase = ClaseDao.GetById(Convert.ToInt32(reader["ID_CLASE"].ToString()));
                                inscripcion.Miembro = MiembroDao.BuscarMiembroPorID(Convert.ToInt32(reader["ID_MIEMBRO"].ToString()));
                                listaInscripciones.Add(inscripcion);
                            }
                        }
                    }
                }
                return listaInscripciones;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
