using Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public static class MembresiaMapper
    {
        public static Membresia Map(SqlDataReader reader)
        {
            try
            {
                return new Membresia
                {
                    IdMembresia = Convert.ToInt32(reader["ID_MEMBRESIA"]),
                    Descripcion = reader["DESCRIPCION"].ToString(),
                    Precio = Convert.ToDecimal(reader["PRECIO"].ToString()),
                    DuracionDias = Convert.ToInt32(reader["DURACION_DIAS"].ToString())
                };
            }
            catch
            {
                throw;
            }
        }
    }
}
