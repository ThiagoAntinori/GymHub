using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class MiembroBusiness
    {
        private MiembroDao MiembroDao = new MiembroDao();
        private InscripcionBusiness InscripcionBusiness = new InscripcionBusiness();
        public void CargarMiembroBusiness(Miembro nuevoMiembro)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    if (nuevoMiembro == null)
                    {
                        throw new Exception("Debe cargar todos los datos");
                    }
                    if (string.IsNullOrEmpty(nuevoMiembro.NombreYApellido))
                    {
                        throw new Exception("El miembro debe tener nombre y apellido");
                    }
                    if (nuevoMiembro.NombreYApellido.Length < 6)
                    {
                        throw new Exception("El nombre y apellido debe contener mas de 6 caracteres");
                    }
                    if (nuevoMiembro.FechaNacimiento > DateTime.Now)
                    {
                        throw new Exception("La fecha de nacimiento no puede ser mayor a hoy");
                    }
                    if (!nuevoMiembro.CorreoElectronico.Contains('@') || (!nuevoMiembro.CorreoElectronico.Contains(".com.ar")))
                    {
                        throw new Exception("El formato del correo electronico es incorrecto \n ejemplo correcto: nombre.apellido@uai.com.ar");
                    }
                    if (EsMenorDe12Años(nuevoMiembro.FechaNacimiento))
                    {
                        throw new Exception("El miembro no puede ser menor a 12 años.");
                    }
                    MiembroDao.CargarNuevoMiembro(nuevoMiembro);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool EsMenorDe12Años(DateTime fechaNacimiento)
        {
            if ((DateTime.Today.Year - fechaNacimiento.Year) < 12)
            {
                return true;
            }
            if (DateTime.Today.Month < fechaNacimiento.Month)
            {
                return true;
            }
            if (DateTime.Today.Day < fechaNacimiento.Day)
            {
                return true;
            }
            return false;
        }

        public void CargarMultiplesMiembros(List<Miembro> listaMiembros)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    foreach (Miembro miembro in listaMiembros)
                    {
                        CargarMiembroBusiness(miembro);
                    }
                    trx.Complete();
                }
            }
            catch (Exception ex) 
            { 
                throw; 
            }
        }
        

        public void ModificarMiembroBusiness(Miembro miembro)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    Miembro miembrobuscado = new Miembro();
                    miembrobuscado = MiembroDao.BuscarMiembroPorID(miembro.IdMiembro);
                    if (miembrobuscado == null)
                    {
                        throw new Exception("No se encontro el miembro a modificar");
                    }
                    if (!miembro.CorreoElectronico.Contains('@') || (!miembro.CorreoElectronico.Contains(".com.ar")))
                    {
                        throw new Exception("El formato del correo electronico es incorrecto \n ejemplo correcto: nombre.apellido@uai.com.ar");
                    }
                    MiembroDao.ModificarMiembroData(miembro);
                    trx.Complete();

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void EliminarMiembroBusiness(int idMiembro)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    if (idMiembro == null)
                    {
                        throw new Exception("No existe el miembro seleccionado");
                    }
                    if (MiembroDao.BuscarMiembroPorID(idMiembro) == null)
                    {
                        throw new Exception("No existe el miembro seleccionado");
                    }
                    InscripcionBusiness.EliminarInscripcionSegunMiembro(idMiembro);
                    MiembroDao.EliminarMiembro(idMiembro);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Miembro> GetMiembrosBusiness()
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    return MiembroDao.GetMiembrosData();
                    trx.Complete();
                }
            }
            catch (Exception ex) 
            {
                throw; 
            }
        }

        public Miembro BuscarMiembroPorId(int idMiembro)
        {
            try
            {
                return MiembroDao.BuscarMiembroPorID(idMiembro);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
