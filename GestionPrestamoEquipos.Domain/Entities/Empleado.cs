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
        public CargoEmpleado CargosEmpleados { get; private set; }

        public void cambiarCargo(CargoEmpleado cargo)
        {
            if (cargo == null)
            {
                throw new Exception("Seleccione un cargo valido");
            }

            this.idCargo = cargo.idCargo;
            this.CargosEmpleados = cargo;
        }

        public void cambiarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new Exception("El nombre del empleado no puede estar vacio");
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
                throw new Exception("El gmail del empleado no puede estar vacio");
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

        public List<Prestamo> listaPrestamos {  get; private set; }
    }
}
