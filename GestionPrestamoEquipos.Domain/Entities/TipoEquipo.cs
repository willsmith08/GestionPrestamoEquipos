using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Domain.Entities
{
    public class TipoEquipo
    {

        public int idTipo { get; private set; }

        public string nombreTipo { get; private set; }

        public IReadOnlyCollection<Equipo> Equipos;

        public TipoEquipo(string nombreTipo)
        {
            cambiarNnombreTipo(nombreTipo);
        }

        protected TipoEquipo() { }

        public void cambiarNnombreTipo(string nombreTipo)
        {
            if (string.IsNullOrWhiteSpace(nombreTipo))
            {
                throw new Exception("Nombre no puede estar vacio");
            }
            this.nombreTipo = nombreTipo;
        }

    }
}
