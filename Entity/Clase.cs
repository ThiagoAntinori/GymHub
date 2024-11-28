using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Clase
    {
        private int idClase;
        private string descripcion;
        private string diaDeClase;
        private string horario;
        private string entrenadorACargo;
        private int capacidadMaxima;



        public int IdClase { get => idClase; set => idClase = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Diadeclase { get => diaDeClase; set => diaDeClase = value; }
        public string Horario { get => horario; set => horario = value; }
        public string EntrenadorACargo { get => entrenadorACargo; set => entrenadorACargo = value; }
        public int CapacidadMaxima { get => capacidadMaxima; set => capacidadMaxima = value; }

    }
}
