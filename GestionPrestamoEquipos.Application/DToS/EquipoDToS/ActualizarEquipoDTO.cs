using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Application.DToS.EquipoDToS
{
    internal class ActualizarEquipoDTO
    {
        public int idEquipo {  get; set; }
        public int idEstado { get; set; }
        public int idTipo { get; set; }

        public string descripcion { get; set; }
        public string serial { get; set; }
        public string nombreEquipo { get; set; }
    }
}
