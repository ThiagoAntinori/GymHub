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
        public void CargarMiembroBusiness(Miembro nuevomiembro)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    if (nuevomiembro == null)
                    {
                        throw new Exception("Debe cargar todos los datos");
                    }
                    if (string.IsNullOrEmpty(nuevomiembro.NombreYApellido))
                    {
                        throw new Exception("El miembro debe tener nombre y apellido");
                    }
                    if (nuevomiembro.NombreYApellido.Length < 6)
                    {
                        throw new Exception("El nombre y apellido debe contener mas de 6 caracteres");
                    }
                    if (nuevomiembro.FechaNacimiento > DateTime.Now)
                    {
                        throw new Exception("La fecha de nacimiento no puede ser mayor a hoy");
                    }
                    if (!nuevomiembro.CorreoElectronico.Contains('@') || (!nuevomiembro.CorreoElectronico.Contains(".com.ar")))
                    {
                        throw new Exception("El formato del correo electronico es incorrecto \n ejemplo correcto: nombre.apellido@uai.com.ar");
                    }
                    if ((DateTime.Now.Year - nuevomiembro.FechaNacimiento.Year) < 12)
                    {
                        throw new Exception("El miembro debe tener mas de 12 años de edad");
                    }
                    MiembroDao.CargarNuevoMiembro(nuevomiembro);
                    trx.Complete();
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void CargarMultiplesMiembros(List<Miembro> miembrosBorrador)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())
                {
                    foreach (Miembro miembro in miembrosBorrador)
                    {
                        CargarMiembroBusiness(miembro);
                    }
                    trx.Complete();
                }
            }
            catch (Exception ex) { throw; }
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
            catch (Exception ex) { throw; }
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
