using Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MembresiaDao
    {
        public List<Membresia> GetMembresia()
        {
            List<Membresia> listaMembresia = new List<Membresia>();
            try
            {
                using (SqlConnection con = new SqlConnection(ConexionDB.ObtenerConexionDB()))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT ID_MEMBRESIA, DESCRIPCION, PRECIO, DURACION_DIAS FROM MEMBRESIA", con))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Membresia membresia = new Membresia
                                {
                                    IdMembresia = Convert.ToInt32(reader["ID_MEMBRESIA"]),
                                    Descripcion = reader["DESCRIPCION"].ToString(),
                                    Precio = Convert.ToDecimal(reader["PRECIO"]),
                                    DuracionDias = Convert.ToInt32(reader["DURACION_DIAS"])
                                };
                                listaMembresia.Add(membresia);
                            }
                        }
                    }
                }
                return listaMembresia;
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Error de SQL al cargar Membresías", sqlEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Error general al cargar Membresías", ex);
            }
        }

    }
}
