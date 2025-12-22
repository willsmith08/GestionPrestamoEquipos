using GestionPrestamoEquipos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Application.Session
{
    public static class UsuarioSession
    {
        public static Empleado empleado {  get; private set; }

        public static void Iniciar(Empleado empleado)
        {
            if (empleado == null)
            {
                throw new Exception("Empleado invalido");
            }
        }

        public static void Cerrar()
        {
            empleado = null;
        }
    }
}
