using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Domain.Entities
{
    public class TipoEquipo
    {
        public TipoEquipo(int id)
        {
            this.idTipo = id;
        }
        public TipoEquipo(int id, string nombreTipo)
        {
            this.idTipo = id;
            this.cambiarNnombreTipo(nombreTipo);
        }
        public int idTipo { get; private set; }
        public string nombreTipo { get; private set; }

        public TipoEquipo(string nombreTipo)
        {
            cambiarNnombreTipo(nombreTipo);
        }

        public void cambiarNnombreTipo(string nombreTipo)
        {
            if (string.IsNullOrWhiteSpace(nombreTipo))
            {
                throw new Exception("Nombre no puede estar vacio");
            }
            this.nombreTipo = nombreTipo;
        }

        



        public List<Equipo> Equipos { get; private set; }
    }
}
