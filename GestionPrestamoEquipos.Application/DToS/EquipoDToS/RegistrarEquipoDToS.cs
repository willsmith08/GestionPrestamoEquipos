using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Application.DToS.EquipoDToS
{
    internal class RegistrarEquipoDToS
    {
        public string nombreEquipo {  get; set; }
        public string serial { get; set; }
        public string descripcion { get; set; }
        public int idEstado { get; set; }
        public int idTipo { get; set; }

    }
}
