using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Application.DToS.PrestamoDToS
{
    public class RegistrarPrestamoDTO
    {
        public int idEmpleado { get; set; }
        public int idEquipo { get; set; }

        public DateTime fechaPrestamo { get; set; }

        public DateTime fechaEstimadaDevolucion { get; set; }

        public string observaciones { get; set; }
    }
}
