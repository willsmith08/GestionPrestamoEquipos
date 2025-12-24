using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Application.DToS.EquipoDToS
{
    internal class ListarEquipoDTO
    {
        public int idEquipo {  get; set; }
        public string nombreEquipo { get; set; }
        public string serial { get; set; }
        public string estado { get; set; }
        public string tipo { get; set; }
    }
}
