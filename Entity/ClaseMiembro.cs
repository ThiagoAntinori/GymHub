using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ClaseMiembro
    {
        private Clase clase;
        private Miembro miembro;

        private DateTime fechaInscripcion;
        private DateTime fechaVencimiento;

        public DateTime FechaInscripcion { get => fechaInscripcion; set => fechaInscripcion = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public string DescripcionClase { get => clase.Descripcion; }
        public string NombreMiembro { get => miembro.NombreYApellido; }
        public Clase Clase { get => clase; set => clase = value; }
        public Miembro Miembro { get => miembro; set => miembro = value; }
    }
}
