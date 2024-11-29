using DAL;
using Entity;
using Mapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class InscripcionBusiness
    {
        InscripcionDao InscripcionDao = new InscripcionDao();
        public void CargarNuevaInscripcion(Inscripcion inscripcion)
        {
            try
            {
                using(var trx = new TransactionScope())
                {
                    if (inscripcion.Clase == null) { throw new Exception("La inscripción debe estar asociada a una Clase."); }
                    if (inscripcion.Miembro == null) { throw new Exception("La inscripción debe tener un miembro asociado"); }
                    if (this.GetAll().Where(i => i.Clase.IdClase == inscripcion.Clase.IdClase
                        && i.Miembro.IdMiembro == inscripcion.Miembro.IdMiembro).ToList().Count == 1)
                    {
                        throw new Exception("El miembro seleccionado ya se encuentra inscripto a la clase seleccionada");
                    }
                    if (inscripcion.FechaVencimiento < DateTime.Today) { throw new Exception("La fecha de vencimiento debe ser posterior al día de hoy"); }
                    if (inscripcion.Clase.CapacidadMaxima == this.GetAll()
                        .Where(i => i.Clase.IdClase == inscripcion.Clase.IdClase)
                        .ToList().Count + 1) { throw new Exception("La clase seleccionada alcanzó su capacidad máxima"); }
                    inscripcion.FechaInscripcion = DateTime.Today;
                    InscripcionDao.CargarInscripcion(inscripcion);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void CargarMultiplesInscripciones(List<Inscripcion> listaInscripciones)
        {
            try
            {
                using(var trx = new TransactionScope())
                {
                    foreach(Inscripcion ins in listaInscripciones)
                    {
                        CargarNuevaInscripcion(ins);
                    }
                    trx.Complete();
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public void EliminarInscripcion(int idClase, int idMiembro)
        {
            try
            {
                if (this.GetAll().Where(i => i.Clase.IdClase == idClase
                    && i.Miembro.IdMiembro == idMiembro).ToList().Count <= 0)
                {
                    throw new Exception("El miembro seleccionado no está inscripto a la clase seleccionada");
                }
                InscripcionDao.EliminarInscripcion(idClase, idMiembro);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ModificarFechaVencimiento(int idClase, int idMiembro, DateTime nuevaFechaVencimiento)
        {
            try
            {
                if (this.GetAll().Where(i => i.Clase.IdClase == idClase
                    && i.Miembro.IdMiembro == idMiembro).ToList().Count <= 0)
                {
                    throw new Exception("El miembro seleccionado no está inscripto a la clase seleccionada");
                }
                if(nuevaFechaVencimiento < DateTime.Today)
                {
                    throw new Exception("La fecha de vencimiento debe ser posterior al día de hoy");
                }
                if(nuevaFechaVencimiento < this.GetAll().Where(i => i.Clase.IdClase == idClase
                    && i.Miembro.IdMiembro == idMiembro).FirstOrDefault()!.FechaVencimiento)
                {
                    throw new Exception("Solo es posible seleccionar una fecha de vencimiento posterior a la vigente");
                }
                InscripcionDao.ModificarFechaVencimiento(idClase, idMiembro, nuevaFechaVencimiento);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Inscripcion> GetAll()
        {
            try
            {
                return InscripcionDao.GetAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Inscripcion> GetByClaseId(int idClase)
        {
            try
            {
                return InscripcionDao.GetAll().Where(i => i.Clase.IdClase == idClase).ToList();
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public List<Inscripcion> GetByMiembroId(int idMiembro)
        {
            try
            {
                return InscripcionDao.GetAll().Where(i => i.Miembro.IdMiembro == idMiembro).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
