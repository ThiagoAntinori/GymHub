using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Membresia
    {
        private int idMembresia;
        private string descripcion;
        private decimal precio;
        private int duracionDias;

        public int IdMembresia { get => idMembresia; set => idMembresia = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int DuracionDias { get => duracionDias; set => duracionDias = value; }

    }
}
