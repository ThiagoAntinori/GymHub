using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    public class ConexionDB
    {
        private const string GetConnectionString = "ConexionDB";
        public static string ObtenerConexionDB()
        {
            return ConfigurationManager.ConnectionStrings[GetConnectionString].ConnectionString;
        }
    }
}
