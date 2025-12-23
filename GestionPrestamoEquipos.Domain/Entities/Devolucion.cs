using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Domain.Entities
{
    internal class Devolucion
    {

        public Devolucion() { }
        public Devolucion(int idPrestamo) { 
            this.idPrestamo = idPrestamo; 
        }

        public int idDevolucion {  get; private set; }

        public int idPrestamo { get; private set; }
        public Prestamo Prestamo { get; private set; }

        public DateTime fechaDevolucion { get; private set; }

        public void cambiarPrestamo(Prestamo prestamo)
        {
            if (prestamo == null)
            {
                throw new Exception("Prestamo invalido");
            }

            this.idPrestamo = prestamo.idPrestamo;
            this.Prestamo = prestamo;
        }

        public void cambiarFechaDevolucion(DateTime fechaDevolucion)
        {
            if (Prestamo.fechaPrestamo > fechaDevolucion)
            {
                throw new Exception("La fecha de devolucion no puede ser menor a la fecha de prestamo del equipo");
            }

            this.fechaDevolucion = fechaDevolucion;
        }
    }
}
