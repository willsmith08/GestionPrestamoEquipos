using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Domain.Entities
{
    internal class EstadoEquipo
    {
        public int idEstado {  get; private set; }
        public string nombreEstado { get; private set; }

        public EstadoEquipo(string nombreEstado)
        {
            editarIdEstado(idEstado);
            editarNombreEstado(nombreEstado);
        }

        private void editarNombreEstado(string nombreEstado)
        {
            if (string.IsNullOrEmpty(nombreEstado))
            {
                throw new Exception("Nombre no puede estar vacio");
            }
            if (string.IsNullOrWhiteSpace(nombreEstado))
            {
                throw new Exception("Nombre no puede estar vacio");
            }
            this.nombreEstado = nombreEstado;
        }

        public List<Equipo> Equipos { get; set; } 
    }
}
