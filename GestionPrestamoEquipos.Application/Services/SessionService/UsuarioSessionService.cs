using GestionPrestamoEquipos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionPrestamoEquipos.Application.DToS;
using GestionPrestamoEquipos.Application.DToS.EmpleadoDToS;
using GestionPrestamoEquipos.Application.Interfaces;

namespace GestionPrestamoEquipos.Application.Session
{
    public class UsuarioSession
    {
        private readonly IEmpleadoRepository _empleadoRepository;
        public static Empleado empleado { get; private set; }

        public UsuarioSession(IEmpleadoRepository empleadoRepository)
        {
            this._empleadoRepository = empleadoRepository;
        }

        public bool Iniciar(InicioSesionEmpleadoDTO empleadoDTO)
        {
            if (string.IsNullOrWhiteSpace(empleadoDTO.contrasena))
            {
                throw new Exception("Contraseña invalida");
            }
            if (string.IsNullOrWhiteSpace(empleadoDTO.usuario))
            {
                throw new Exception("usuario invalido");
            }

            if ( !_empleadoRepository.VerificarSesion(new Empleado(empleadoDTO.contrasena, empleadoDTO.usuario)) )
            {
                throw new Exception("Usuario o contraseña invalido");
            }

            empleado = _empleadoRepository.EmpleadoEspecificoGmail(empleadoDTO.usuario);
            return true;

        }

        public void Cerrar()
        {
            empleado = null;
        }
    }
}
