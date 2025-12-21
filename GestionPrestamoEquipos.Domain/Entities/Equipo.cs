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
        public TipoEquipo TipoEquipos { get; private set; }

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

        public void cambiarEstadoEquipo(EstadoEquipo estadoEquipo)
        {
            if (estadoEquipo == null)
            {
                throw new Exception("Seleccione un estado valido");
            }

            this.idEstado = estadoEquipo.idEstado;
            this.EstadoEquipo = estadoEquipo;
        }

        public void cambiarTipoEquipo(TipoEquipo tipoEquipos)
        {
            if (tipoEquipos == null)
            {
                throw new Exception("Seleccione un tipo valido");
            }

            this.TipoEquipos = tipoEquipos;
            this.idTipo = tipoEquipos.idTipo;
        }

        public List<Prestamo> listaPrestamos {  get; private set; }
    }
}
