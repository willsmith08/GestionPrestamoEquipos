using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Domain.Entities
{
    internal class TipoEquipo
    {
        public int idTipo { get; private set; }
        public string nombreTipo { get; private set; }

        public TipoEquipo(string nombreTipo)
        {
            editarnombreTipo(nombreTipo);
        }

        public void editarnombreTipo(string nombreTipo)
        {
            if (string.IsNullOrEmpty(nombreTipo))
            {
                throw new Exception("Nombre no puede estar vacio");
            }
            if (string.IsNullOrWhiteSpace(nombreTipo))
            {
                throw new Exception("Nombre no puede estar vacio");
            }
            this.nombreTipo = nombreTipo;
        }

        public List<Equipo> Equipos { get; set; }
    }
}
