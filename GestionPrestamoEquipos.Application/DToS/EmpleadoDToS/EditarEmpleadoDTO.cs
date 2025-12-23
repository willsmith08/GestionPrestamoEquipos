using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Application.DToS.EmpleadoDToS
{
    public class EditarEmpleadoDTO
    {
        public int idEmpleado {  get; set; }
        public int idCargo { get; set; }
        public string nombre { get; set; }
        public string gmail { get; set; }
        public string numeroDocumento { get; set; }
    }
}
