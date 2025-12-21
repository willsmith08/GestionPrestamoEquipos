using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Domain.Entities
{
    public class Administrador
    {
        public int idAdmin { get; private set; }
        public string contrasena { get; private set; }

        public int idEmpleado { get; private set; }
        public Empleado Empleado { get; private set; }

        public void cambiarContraseña(string contrasena)
        {
            if (string.IsNullOrWhiteSpace(contrasena))
            {
                throw new Exception("La contraseña no puede estar vacia");
            }
            this.contrasena = contrasena;
        }

        public void cambiarEmpleado(Empleado empleado)
        {
            if (empleado == null)
            {
                throw new Exception("Empleado invalido");
            }

            this.idEmpleado = empleado.idEmpleado;
            this.Empleado = empleado;
        }
    }
}
