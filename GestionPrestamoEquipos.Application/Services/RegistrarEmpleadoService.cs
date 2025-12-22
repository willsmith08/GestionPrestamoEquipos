using GestionPrestamoEquipos.Application.Interfaces;
using GestionPrestamoEquipos.Domain.Entities;
using GestionPrestamoEquipos.Application.DToS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using GestionPrestamoEquipos.Application.Services.EnvioCorreosService;

namespace GestionPrestamoEquipos.Application.Services
{
    internal class RegistrarEmpleadoService
    {
        private readonly IEmpleadoRepository _repoEmpleado;
        private readonly ICargoEmpleadoRepository _repoCargoEmpleado;

        RegistrarEmpleadoService(IEmpleadoRepository repoEmpleado, ICargoEmpleadoRepository repoCargoEmpleado)
        {
            _repoEmpleado = repoEmpleado;
            _repoCargoEmpleado = repoCargoEmpleado;
        }

        public bool ValidacionRegistro(RegistrarEmpleadoDTO RegEmpleado)
        {
            if (string.IsNullOrWhiteSpace(RegEmpleado.gmail))
            {
                throw new Exception("El gmail es obligatorio");
            }

            if (string.IsNullOrWhiteSpace(RegEmpleado.nombreEmpleado))
            {
                throw new Exception("El nombre es obligatorio");
            }

            if (string.IsNullOrWhiteSpace(RegEmpleado.documento))
            {
                throw new Exception("El documento es obligatori");
            }

            if (!Regex.IsMatch(RegEmpleado.gmail, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$"))
            {
                throw new Exception("El gmail es invalido");
            }

            int resultadoDoc;
            if (!int.TryParse(RegEmpleado.documento, out resultadoDoc))
            {
                throw new Exception("El documento solo puede contener numeros");
            }

            CargoEmpleado cargoNuevo = _repoCargoEmpleado.ObtnerCargoEmpleadoPorId(RegEmpleado.idCargo);

            if (cargoNuevo == null)
            {
                throw new Exception("Cargo invalido");
            }

            if (_repoEmpleado.ExisteDocumento(resultadoDoc))
            {
                throw new Exception("El documento ingresado ya se encuentra registrado");
            }

            if (_repoEmpleado.ExiteGmail(RegEmpleado.gmail))
            {
                throw new Exception("El gmail ingresado ya se encuentra registrado");
            }

            return true;

        }

        public void Ejecutar(RegistrarEmpleadoDTO RegEmpleado)
        {
            CargoEmpleado cargoNuevo = _repoCargoEmpleado.ObtnerCargoEmpleadoPorId(RegEmpleado.idCargo);
            int resultadoDoc = int.Parse(RegEmpleado.documento);

            Empleado empleadoNuevo = new Empleado();
            empleadoNuevo.cambiarDocumentoEmpleado(resultadoDoc);
            empleadoNuevo.cambiarE_mail(RegEmpleado.gmail);
            empleadoNuevo.cambiarNombre(RegEmpleado.nombreEmpleado);
            empleadoNuevo.cambiarActivo(true);
            empleadoNuevo.cambiarCargo(cargoNuevo);


            _repoEmpleado.Agregar(empleadoNuevo);

            
        }

    }
}
