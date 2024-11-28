using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MembresiaBusiness
    {
        MembresiaDao MembresiaDao = new MembresiaDao();
        public List<Membresia> ObtenerMembresias()
        {
            try
            {
                return MembresiaDao.GetMembresia();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
