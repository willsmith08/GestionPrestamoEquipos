using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Application.DToS
{
    public class RegistrarEmpleadoDTO
    {
        public string nombreEmpleado {  get; set; }
        public string documento { get; set; }
        public string gmail { get; set; }

        public int idCargo { get; set; }
    }
}
