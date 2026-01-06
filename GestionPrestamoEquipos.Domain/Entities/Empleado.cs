using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Domain.Entities
{
    public class Empleado
    {
        public int idEmpleado {  get; private set; }
        public string nombreEmpleado { get; private set; }

        public int documentoEmpleado { get; private set; }

        public string e_mail { get; private set; }

        public bool activo {  get; private set; }

        public int idCargo { get; private set; }
        public CargoEmpleado cargoEmpleado { get; private set; }

        private IReadOnlyCollection<Prestamo> prestamos;

        public Empleado(string nombreEmpleado, int documentoEmpleado, string e_mail, int idCargo)
        {
            cambiarNombre(nombreEmpleado);
            cambiarDocumentoEmpleado(documentoEmpleado);
            cambiarE_mail(e_mail);
            cambiarActivo(true);
            cambiarCargo(idCargo);
        }

        protected Empleado() { }


        public void cambiarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new Exception("Nombre invalido");
            }

            this.nombreEmpleado = nombre;
        }

        public void cambiarDocumentoEmpleado(int documentoEmpleado)
        {
            if (documentoEmpleado <= 0)
            {
                throw new Exception("Documento invalido");
            }

            this.documentoEmpleado = documentoEmpleado;
        }

        public void cambiarE_mail(string e_mail)
        {
            if (string.IsNullOrWhiteSpace(e_mail))
            {
                throw new Exception("Gmail invalido");
            }

            if (!Regex.IsMatch(e_mail, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$"))
            {
                throw new Exception("Gmail invalido");
            }

            this.e_mail = e_mail;
        }

        public void cambiarActivo(bool activo)
        {
            this.activo = activo;
        }

        public void cambiarCargo(int idCargo)
        {
            if (idCargo <= 0)
            {
                throw new Exception("Cargo invalido");
            }

            this.idCargo = idCargo;
        }


    }
}
