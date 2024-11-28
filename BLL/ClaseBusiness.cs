using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClaseBusiness
    {
        private ClaseDao ClaseDao = new ClaseDao();
        public void CargarNuevaClase(Clase clase)
        {
            try
            {
                if(clase == null) { throw new Exception("La clase es inválida."); }
                if(string.IsNullOrEmpty(clase.Descripcion)) { throw new Exception("La clase debe tener una descripcion.");  }
                if(clase.Descripcion.Length < 3) { throw new Exception("La descripción de la clase debe tener al menos 3 caracteres");  }
                if(string.IsNullOrEmpty(clase.Diadeclase)) { throw new Exception("La clase debe tener un día asignado");  }
                if(string.IsNullOrEmpty(clase.Horario)) { throw new Exception("La clase debe tener un horario asignado"); }
                if(string.IsNullOrEmpty(clase.EntrenadorACargo)) { throw new Exception("La clase debe tener un entrenador a cargo");  }
                if(clase.CapacidadMaxima <= 0) { throw new Exception("La capacidad máxima debe ser mayor que cero.");  }
                ClaseDao.CargarNuevaClase(clase);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void EliminarClase(int idClase)
        {
            try
            {
                if(ClaseDao.GetAllClases().Where(c => c.IdClase == idClase).ToList().Count <= 0)
                {
                    throw new Exception("No se encontró la clase seleccionada");
                }
                ClaseDao.EliminarClase(idClase);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ModificarClase(Clase clase)
        {
            try
            {
                if (clase == null) { throw new Exception("La clase es inválida."); }
                if (ClaseDao.GetAllClases().Where(c => c.IdClase == clase.IdClase).ToList().Count <= 0)
                {
                    throw new Exception("No se encontró la clase seleccionada");
                }
                if (string.IsNullOrEmpty(clase.Descripcion)) { throw new Exception("La clase debe tener una descripcion."); }
                if (clase.Descripcion.Length < 3) { throw new Exception("La descripción de la clase debe tener al menos 3 caracteres"); }
                if (string.IsNullOrEmpty(clase.Diadeclase)) { throw new Exception("La clase debe tener un día asignado"); }
                if (string.IsNullOrEmpty(clase.Horario)) { throw new Exception("La clase debe tener un horario asignado"); }
                if (string.IsNullOrEmpty(clase.EntrenadorACargo)) { throw new Exception("La clase debe tener un entrenador a cargo"); }
                if (clase.CapacidadMaxima <= 0) { throw new Exception("La capacidad máxima debe ser mayor que cero."); }
                ClaseDao.ModificarClase(clase);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Clase> GetAllClases()
        {
            try
            {
                return ClaseDao.GetAllClases();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Clase GetById(int idClase)
        {
            try
            {
                if (ClaseDao.GetAllClases().Where(c => c.IdClase == idClase).ToList().Count <= 0)
                {
                    throw new Exception("No se encontró la clase seleccionada");
                }
                return ClaseDao.GetById(idClase);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
