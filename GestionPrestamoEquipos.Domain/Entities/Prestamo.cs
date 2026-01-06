using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionPrestamoEquipos.Domain.Entities
{
    public class Prestamo
    {
        public int idPrestamo { get; private set; }

        public int idEmpleado { get; private set; }
        public Empleado Empleado { get; private set; }
        public int idEquipo { get; private set; }
        public Equipo Equipo { get; private set; }
        public DateTime fechaPrestamo { get; private set; }
        public DateTime fechaEstimadaDevolucion {  get; private set; }
        public DateTime? fechaDevolucion { get; private set; }
        public string observaciones {  get; private set; }

        public void cambiarEmpleado(int idEmpleado)
        {
            if (idEmpleado <= 0)
            {
                throw new Exception("Empleado invalido");
            }

            this.idEmpleado = idEmpleado;
        }
        public void cambiarEquipo(int idEquipo)
        {
            if (idEquipo <= 0)
            {
                throw new Exception("Equipo invalido");
            }

            this.idEquipo = idEquipo;
        }

        public void cambiarFechaEstimadaDevolucion(DateTime fechaEstimadaDevolucion)
        {
            if (fechaEstimadaDevolucion == null)
            {
                throw new Exception("Fecha invalida");
            }

            this.fechaEstimadaDevolucion = fechaEstimadaDevolucion;
        }

        public void cambiarFechaPrestamo(DateTime fechaPrestamo)
        {
            if (fechaPrestamo == null)
            {
                throw new Exception("Fecha invalida");
            }

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

        public void cambiarFechaDevolucion(DateTime fechaDevolucion)
        {
            if (fechaDevolucion == null)
            {
                throw new Exception("Fecha invalida");
            }

            this.fechaDevolucion = fechaDevolucion;
        }

        public Prestamo(int idEmpleado, int idEquipo, DateTime fechaPrestamo, DateTime fechaEstimadaDevolucion, string observaciones)
        {
            cambiarEmpleado(idEmpleado);
            cambiarEquipo(idEquipo);
            cambiarFechaPrestamo(fechaPrestamo);
            cambiarFechaEstimadaDevolucion(fechaEstimadaDevolucion);
            cambiarObservaciones(observaciones);
        }

        public Prestamo(DateTime fechaDevolucion)
        {
            cambiarFechaDevolucion(fechaDevolucion);
        }

        protected Prestamo() { }
    }
}
