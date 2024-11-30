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
    public class MiembroDao
    {
        public void CargarNuevoMiembro(Miembro nuevoMiembro)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConexionDB.ObtenerConexionDB()))
                {
                    conexion.Open();
                    string queryAlta = "INSERT INTO MIEMBRO (NOMBRE_APELLIDO, FECHA_NACIMIENTO, CORREO_ELEC, ID_MEMBRESIA) " +
                                       "VALUES (@NOMBRE_APELLIDO, @FECHA_NACIMIENTO, @CORREO_ELEC, @ID_MEMBRESIA)";
                    
                    using (SqlCommand command = new SqlCommand(queryAlta, conexion))
                    {
                        var parameters = MiembroMapper.MapMiembroParametros(nuevoMiembro);
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void EliminarMiembro(int idEliminar)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConexionDB.ObtenerConexionDB()))
                {
                    connection.Open();
                    string queryDelete = "DELETE FROM MIEMBRO where ID_MIEMBRO = @ID_MIEMBRO";
                    using (SqlCommand command = new SqlCommand(queryDelete, connection))
                    {
                        command.Parameters.AddWithValue("@ID_MIEMBRO", idEliminar);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ModificarMiembroData(Miembro miembroAModificar)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConexionDB.ObtenerConexionDB()))
                {
                    con.Open();
                    string query = @"
                UPDATE MIEMBRO 
                SET CORREO_ELEC = @CORREO_ELEC, 
                    ID_MEMBRESIA = @ID_MEMBRESIA
                WHERE ID_MIEMBRO = @ID_MIEMBRO";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@CORREO_ELEC", miembroAModificar.CorreoElectronico);
                        command.Parameters.AddWithValue("@ID_MEMBRESIA", miembroAModificar.Membresia?.IdMembresia ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@ID_MIEMBRO", miembroAModificar.IdMiembro);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar los datos del miembro", ex);
            }
        }

        public List<Miembro> GetMiembrosData()
        {
            List<Miembro> miembros = new List<Miembro>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConexionDB.ObtenerConexionDB()))
                {
                    conexion.Open();
                    string ObtenerMiembros = @"
                SELECT m.ID_MIEMBRO, m.NOMBRE_APELLIDO, m.FECHA_NACIMIENTO, m.CORREO_ELEC, 
                       mb.ID_MEMBRESIA, mb.DESCRIPCION, mb.PRECIO, mb.DURACION_DIAS
                FROM MIEMBRO m
                LEFT JOIN MEMBRESIA mb ON m.ID_MEMBRESIA = mb.ID_MEMBRESIA";

                    using (SqlCommand command = new SqlCommand(ObtenerMiembros, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Miembro miembro = MiembroMapper.MapMiembro(reader);
                                miembros.Add(miembro);
                            }
                        }
                    }
                }
                return miembros;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los datos de los miembros", ex);
            }
        }

        public Miembro BuscarMiembroPorID(int idMiembro)
        {
            Miembro miembro = null;
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConexionDB.ObtenerConexionDB()))
                {
                    conexion.Open();
                    string queryPorID = @"
                SELECT 
                    M.ID_MIEMBRO, M.NOMBRE_APELLIDO, M.FECHA_NACIMIENTO, M.CORREO_ELEC, 
                    MEM.ID_MEMBRESIA, MEM.DESCRIPCION, MEM.PRECIO, MEM.DURACION_DIAS
                FROM MIEMBRO M
                LEFT JOIN MEMBRESIA MEM ON M.ID_MEMBRESIA = MEM.ID_MEMBRESIA
                WHERE M.ID_MIEMBRO = @ID_MIEMBRO";

                    using (SqlCommand command = new SqlCommand(queryPorID, conexion))
                    {
                        command.Parameters.AddWithValue("@ID_MIEMBRO", idMiembro);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                miembro = MiembroMapper.MapMiembro(reader);
                            }
                        }
                    }
                }
                return miembro;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el miembro por ID", ex);
            }
        }
    }
}
