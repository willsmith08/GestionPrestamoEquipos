using GestionPrestamoEquipos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Application.Session
{
    internal class UsuarioSession
    {
        public Empleado empleado {  get; private set; }

        public void cambiarEmpleado(Empleado empleado)
        {
            if (empleado == null)
            {
                throw new Exception("Empleado invalido");
            }
        }
    }
}
