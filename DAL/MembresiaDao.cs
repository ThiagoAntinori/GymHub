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
                                listaMembresia.Add(MembresiaMapper.Map(reader));
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
