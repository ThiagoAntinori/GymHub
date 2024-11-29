using Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public static class InscripcionMapper
    {
        public static Inscripcion Map(SqlDataReader reader)
        {
            try
            {
                return new Inscripcion
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
