using DAL;
using Entity;
using Mapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClaseMiembroBusiness
    {
        ClaseMiembroDao ClaseMiembroDao = new ClaseMiembroDao();
        public void CargarClaseMiembro(ClaseMiembro claseMiembro)
        {
            try
            {
                if(claseMiembro.Clase == null){ throw new Exception("La inscripción debe estar asociada a una Clase.");  }
                if(claseMiembro.Miembro == null) { throw new Exception("La inscripción debe tener un miembro asociado");  }
                if(this.GetAll().Where(cm => cm.Clase.IdClase == claseMiembro.Clase.IdClase 
                    && cm.Miembro.IdMiembro == claseMiembro.Miembro.IdMiembro).ToList().Count >= 1)
                {
                    throw new Exception("El miembro seleccionado ya se encuentra inscripto a la clase seleccionada");
                }
                if(claseMiembro.FechaVencimiento < DateTime.Today) { throw new Exception("La fecha de vencimiento debe ser posterior al día de hoy");  }
                if(claseMiembro.Clase.CapacidadMaxima == this.GetAll()
                    .Where(cm => cm.Clase.IdClase == claseMiembro.Clase.IdClase)
                    .ToList().Count + 1) { throw new Exception("La clase seleccionada alcanzó su capacidad máxima");  }
                claseMiembro.FechaInscripcion = DateTime.Today;
                ClaseMiembroDao.CargarClaseMiembro(claseMiembro);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void EliminarClaseMiembro(int idClase, int idMiembro)
        {
            try
            {
                if (this.GetAll().Where(cm => cm.Clase.IdClase == idClase
                    && cm.Miembro.IdMiembro == idMiembro).ToList().Count <= 0)
                {
                    throw new Exception("El miembro seleccionado no está inscripto a la clase seleccionada");
                }
                ClaseMiembroDao.EliminarClaseMiembro(idClase, idMiembro);
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
                if (this.GetAll().Where(cm => cm.Clase.IdClase == idClase
                    && cm.Miembro.IdMiembro == idMiembro).ToList().Count <= 0)
                {
                    throw new Exception("El miembro seleccionado no está inscripto a la clase seleccionada");
                }
                if(nuevaFechaVencimiento < DateTime.Today)
                {
                    throw new Exception("La fecha de vencimiento debe ser posterior al día de hoy");
                }
                if(nuevaFechaVencimiento < this.GetAll().Where(cm => cm.Clase.IdClase == idClase
                    && cm.Miembro.IdMiembro == idMiembro).FirstOrDefault()!.FechaVencimiento)
                {
                    throw new Exception("Solo es posible seleccionar una fecha de vencimiento posterior a la vigente");
                }
                ClaseMiembroDao.ModificarFechaVencimiento(idClase, idMiembro, nuevaFechaVencimiento);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<ClaseMiembro> GetAll()
        {
            try
            {
                return ClaseMiembroDao.GetAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<ClaseMiembro> GetByClaseId(int idClase)
        {
            try
            {
                return ClaseMiembroDao.GetAll().Where(cm => cm.Clase.IdClase == idClase).ToList();
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public List<ClaseMiembro> GetByMiembroId(int idMiembro)
        {
            try
            {
                return ClaseMiembroDao.GetAll().Where(cm => cm.Miembro.IdMiembro == idMiembro).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
