using Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public static class MiembroMapper
    {
        // Mapeo de parámetros para las consultas
        public static Dictionary<string, object> MapMiembroParametros(Miembro miembro)
        {
            return new Dictionary<string, object>
        {
            { "@ID_MIEMBRO", miembro.IdMiembro },
            { "@NOMBRE_APELLIDO", miembro.NombreYApellido },
            { "@FECHA_NACIMIENTO", miembro.FechaNacimiento },
            { "@CORREO_ELEC", miembro.CorreoElectronico },
            { "@ID_MEMBRESIA", miembro.Membresia?.IdMembresia ?? (object)DBNull.Value }
        };
        }

        public static Miembro MapMiembro(SqlDataReader reader)
        {
            return new Miembro
            {
                IdMiembro = reader.GetInt32(0),
                NombreYApellido = reader.GetString(1),
                FechaNacimiento = reader.GetDateTime(2),
                CorreoElectronico = reader.GetString(3),
                Membresia = new Membresia
                {
                    IdMembresia = reader.GetInt32(4),
                    Descripcion = reader.GetString(5),
                    Precio = reader.GetDecimal(6),
                    DuracionDias = reader.GetInt32(7)
                }
            };
        }

    }
}
