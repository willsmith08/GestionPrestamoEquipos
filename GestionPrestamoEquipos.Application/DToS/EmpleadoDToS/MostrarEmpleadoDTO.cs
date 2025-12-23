using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Application.DToS.EmpleadoDToS
{
    internal class MostrarEmpleadoDTO
    {
        public int id {  get; set; }
        public string nombreEmpleado { get; set; }
        public int documento { get; set; }
        public string gmail { get; set; }
        public string nombreCargo { get; set; }
    }
}
