using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Miembro
    {
        private int idMiembro;
        private string nombreYApellido;
        private DateTime fechaNacimiento;
        private string correoElectronico;
        private Membresia membresia;

        public int IdMiembro { get => idMiembro; set => idMiembro = value; }
        public string NombreYApellido { get => nombreYApellido; set => nombreYApellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public Membresia Membresia { get => membresia; set => membresia = value; }
        public string MembresiaDescripcion => membresia?.Descripcion ?? "Sin Membresía";

    }
}
