using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Domain.Entities
{
    public class Equipo
    {
        public int idEquipo { get; private set; }

        public string nombreEquipo { get; private set; }

        public string serial { get; private set; }

        public string descripcion { get; private set; }

        public int idEstado { get; private set; }
        public EstadoEquipo EstadoEquipo { get; private set; }


        public int idTipo { get; private set; }
        public TipoEquipo TipoEquipo { get; private set; }

        public IReadOnlyCollection<Prestamo> prestamos;

        public void cambiarNombreEquipo(string nombreEquipo)
        {
            if (string.IsNullOrWhiteSpace(nombreEquipo))
            {
                throw new Exception("El nombre del equipo no puede estar vacio");
            }
            this.nombreEquipo = nombreEquipo.Trim();
        }
        public void cambiarSerial(string serial)
        {
            if (string.IsNullOrWhiteSpace(serial))
            {
                throw new Exception("El serial del equipo no puede estar vacio");
            }
            this.serial = serial.Trim();
        }
        public void cambiardescripcion(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                throw new Exception("La descripcion del equipo no puede estar vacio");
            }
            this.descripcion = descripcion.Trim();
        }

        public void cambiarEstadoEquipo(int idEstadoEquipo)
        {
            if (idEstadoEquipo <= 0)
            {
                throw new Exception("Estado invalido");
            }

            this.idEstado = idEstadoEquipo;
        }

        public void cambiarTipoEquipo(int idTipoEquipos)
        {
            if (idTipoEquipos <= 0)
            {
                throw new Exception("Tipo de equipo invalido");
            }

            this.idTipo = idTipoEquipos;
        }

        public Equipo(string nombre, string serial, string descripcion, int idEstado, int idTipo)
        {
            cambiarNombreEquipo(nombre);
            cambiarSerial(serial);
            cambiardescripcion(descripcion);
            cambiarEstadoEquipo(idEstado);
            cambiarTipoEquipo(idTipo);
        }

        protected Equipo() { }

        
    }
}
