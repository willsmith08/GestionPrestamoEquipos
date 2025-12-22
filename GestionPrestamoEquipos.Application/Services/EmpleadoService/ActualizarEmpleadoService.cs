using GestionPrestamoEquipos.Application.DToS;
using GestionPrestamoEquipos.Application.DToS.EmpleadoDToS;
using GestionPrestamoEquipos.Application.Interfaces;
using GestionPrestamoEquipos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Application.Services.EmpleadoService
{
    public class ActualizarEmpleadoService
    {
        private readonly IEmpleadoRepository _empleadoRepository;
        private readonly ICargoEmpleadoRepository _cargoEmpleadoRepository;

        ActualizarEmpleadoService(IEmpleadoRepository empleadoRepository)
        {
            this._empleadoRepository = empleadoRepository;
        }

        public void Ejecutar(EditarEmpleadoDTO empleadoDTO)
        {
            Empleado empleadoBuscado = _empleadoRepository.EmpleadoEspecifico(empleadoDTO.idEmpleado);
            CargoEmpleado cargoBuscado = _cargoEmpleadoRepository.ObtnerCargoEmpleadoPorId(empleadoDTO.idCargo);

            if (empleadoBuscado == null)
            {
                throw new Exception("Seleccione un empleado valido");
            }

            Empleado empleadoActualizar = new Empleado(empleadoBuscado.idEmpleado);

            if (
                string.IsNullOrWhiteSpace(empleadoDTO.numeroDocumento) &&
                string.IsNullOrWhiteSpace(empleadoDTO.gmail) &&
                string.IsNullOrWhiteSpace(empleadoDTO.nombre) &&
                empleadoDTO.idCargo == 0
            )
            {
                throw new Exception("Debe actualizar almenos un campo");
            }

            if (empleadoDTO.idCargo != 0)
            {
                if (cargoBuscado == null)
                {
                    throw new Exception("Seleccione un cargo valido");
                }
                empleadoActualizar.cambiarCargo(cargoBuscado);
            }

            if (!string.IsNullOrWhiteSpace(empleadoDTO.numeroDocumento))
            {
                int documento = 0;
                if (!int.TryParse(empleadoDTO.numeroDocumento, out documento))
                {
                    throw new Exception("El campo documento solo permite numeros");
                }
                empleadoActualizar.cambiarDocumentoEmpleado(documento);
            }

            if (!string.IsNullOrWhiteSpace(empleadoDTO.gmail))
            {
                if (!Regex.IsMatch(empleadoDTO.gmail, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$"))
                {
                    throw new Exception("El gmail es invalido");
                }
                empleadoActualizar.cambiarE_mail(empleadoDTO.gmail);
            }

            if (!string.IsNullOrWhiteSpace(empleadoDTO.nombre))
            {
                empleadoActualizar.cambiarNombre(empleadoDTO.nombre);
            }

            _empleadoRepository.Actualizar(empleadoActualizar);

            
        }

        
    }
}
