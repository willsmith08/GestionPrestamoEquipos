using GestionPrestamoEquipos.Application.DToS.EmpleadoDToS;
using GestionPrestamoEquipos.Application.Interfaces;
using GestionPrestamoEquipos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Application.Services.EmpleadoService
{
    public class EliminarEmpleadoService
    {
        private readonly IEmpleadoRepository _empleadoRepository;

        public EliminarEmpleadoService(IEmpleadoRepository empleadoRepository)
        {
            this._empleadoRepository = empleadoRepository;
        }

        public void Ejecutar(EliminarEmpleadoDTO empleadoEliminar)
        {
            Empleado empleadoBuscado = _empleadoRepository.EmpleadoEspecifico(empleadoEliminar.IdEmpleado);

            if (empleadoBuscado == null)
            {
                throw new Exception("Empleado invalido");
            }

            if (_empleadoRepository.VericacionPrestamosPendientes(empleadoBuscado.idEmpleado))
            {
                throw new Exception("No se puede eliminar registros con prestamos activos");
            }

            _empleadoRepository.Eliminar(empleadoBuscado);

        }
    }
}
