using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Domain.Entities
{
    public class Prestamo
    {
        public Prestamo(int idPrestamo)
        {
            this.idPrestamo = idPrestamo;
        }
        public Prestamo() { }
        public int idPrestamo {  get; private set; }

        public int idEmpleado { get; private set; }
        public Empleado Empleado { get; private set; }

        public int idEquipo { get; private set; }
        public Equipo Equipo { get; private set; }

        public DateTime fechaPrestamo { get; private set; }
        public DateTime fechaEstimadaDevolucion {  get; private set; }
        public string observaciones {  get; private set; }

        public void cambiarEmpleado(Empleado empleado)
        {
            if (empleado == null)
            {
                throw new Exception("Empleado invalido");
            }

            this.idEmpleado = empleado.idEmpleado;
            this.Empleado = empleado;
        }

        public void cambiarEquipo(Equipo equipo)
        {
            if (equipo == null)
            {
                throw new Exception("Equipo invalido");
            }

            this.idEquipo = equipo.idEquipo;
            this.Equipo = equipo;
        }

        public void cambiarFechaEstimadaDevolucion(DateTime fechaEstimadaDevolucion)
        {
            DateTime fechaActual = DateTime.Now;
            if (fechaEstimadaDevolucion == fechaActual)
            {
                if (fechaEstimadaDevolucion.TimeOfDay.TotalMinutes < fechaActual.TimeOfDay.TotalMinutes)
                {
                    throw new Exception("La fecha estimada de devolucion debe ser mayor al menos una hora a la actual");
                }
            }

            if (fechaEstimadaDevolucion < fechaActual)
            {
                throw new Exception("La fecha estimada de devolucion debe ser mayor al menos una hora a la actual");
            }

            this.fechaEstimadaDevolucion = fechaEstimadaDevolucion;
        }

        public void cambiarFechaDevolucion(DateTime fechaDevolucion)
        {
            if (fechaDevolucion < this.fechaPrestamo)
            {
                throw new Exception("La fecha de devolucion debe ser mayor a la fecha del prestamo");
            }
        }

        public void cambiarFechaPrestamo(DateTime fechaPrestamo)
        {
            this.fechaPrestamo = fechaPrestamo;
        }

        public void cambiarObservaciones(string observaciones)
        {
            if (observaciones == null)
            {
                throw new Exception("Observaciones no puede estar vacio");
            }

            this.observaciones = observaciones;
        }
    }
}
