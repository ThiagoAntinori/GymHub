using Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public static class ClaseMiembroMapper
    {
        public static ClaseMiembro Map(SqlDataReader reader)
        {
            try
            {
                return new ClaseMiembro
                {
                    FechaInscripcion = Convert.ToDateTime(reader["FECHA_INSCRIPCION"].ToString()),
                    FechaVencimiento = Convert.ToDateTime(reader["FECHA_VENCIMIENTO"].ToString())
                };
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
