using Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public static class ClaseMapper
    {
        public static Clase ClaseMap(SqlDataReader reader)
        {
            Clase clase = new Clase();
            try
            {
                clase.IdClase = Convert.ToInt32(reader["ID_CLASE"].ToString());
                clase.Descripcion = reader["DESCRIPCION"].ToString();
                clase.Horario = reader["HORARIO"].ToString();
                clase.EntrenadorACargo = reader["ENTRENADOR"].ToString();
                clase.CapacidadMaxima = Convert.ToInt32(reader["CAPACIDAD_MAXIMA"].ToString());
                clase.Diadeclase = reader["DIA_CLASE"].ToString();
                return clase;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mapear los datos de la clase", ex);
            }
        }
    }
}
