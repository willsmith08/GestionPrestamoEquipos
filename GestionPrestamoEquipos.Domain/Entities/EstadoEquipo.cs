using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Domain.Entities
{
    public class EstadoEquipo
    {
        public int idEstado {  get; private set; }

        public string nombreEstado { get; private set; }

        public IReadOnlyCollection<Equipo> Equipo;

        public void editarNombreEstado(string nombreEstado)
        {
            if (string.IsNullOrWhiteSpace(nombreEstado))
            {
                throw new Exception("El nombre del estado del equipo no puede estar vacio");
            }
            this.nombreEstado = nombreEstado;
        }

        protected EstadoEquipo() { }

        public EstadoEquipo(string nombreEstado)
        {
            editarNombreEstado(nombreEstado);
        }

    }
}
