using GestionPrestamoEquipos.Application.DToS.PrestamoDToS;
using GestionPrestamoEquipos.Application.Interfaces;
using GestionPrestamoEquipos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Application.Services.PrestamoService
{
    public class RegistrarPrestamoService
    {
        private readonly IPrestamoRepository _prestamoRepository;
        private readonly IEmpleadoRepository _empleadoRepository;
        private readonly IEquipoRepository _equipoRepository;

        public RegistrarPrestamoService(IPrestamoRepository prestamoRepository, IEmpleadoRepository empleadoRepository, IEquipoRepository equipoRepository)
        {
            this._prestamoRepository = prestamoRepository;
            _empleadoRepository = empleadoRepository;
            _equipoRepository = equipoRepository;
        }

        public void Ejecutar(RegistrarPrestamoDTO prestamoDTO)
        {
            if (string.IsNullOrWhiteSpace(prestamoDTO.observaciones))
            {
                throw new Exception("El campo de observaciones no puede estar vacio");
            }

            Empleado empleadoBUscado = _empleadoRepository.EmpleadoEspecificoDoc(prestamoDTO.documento);
            Equipo equipoBuscado = _equipoRepository.EquipoEspecifico(prestamoDTO.idEquipo);

            if (equipoBuscado == null)
            {
                throw new Exception("Seleccione un equipo valido");
            }
            if (_equipoRepository.VerificarEquipoPrestado(equipoBuscado.idEquipo))
            {
                throw new Exception("El equipo seleccionado ya se encuentra prestado");
            }


            if (empleadoBUscado == null)
            {
                throw new Exception("Seleccione un empleado valido");
            }
            if (_empleadoRepository.VericacionPrestamosMora(empleadoBUscado.idEmpleado))
            {
                throw new Exception("El empleado tiene prestamos en mora");
            }


            if (DateTime.Compare(prestamoDTO.fechaPrestamo, prestamoDTO.fechaEstimadaDevolucion) == 0)
            {
                throw new Exception("La fecha de prestamo no puede ser igual a la de devolucion");
            }
            if (DateTime.Compare(prestamoDTO.fechaPrestamo, prestamoDTO.fechaEstimadaDevolucion) > 0)
            {
                throw new Exception("La fecha de devolucion no puede ser menor a la de prestamo");
            }

            Prestamo prestamo = new Prestamo
            (
                empleadoBUscado.idEmpleado, 
                equipoBuscado.idEquipo, 
                prestamoDTO.fechaPrestamo, 
                prestamoDTO.fechaEstimadaDevolucion, 
                prestamoDTO.observaciones
            );

            _prestamoRepository.Agregar(prestamo);


        }


    }
}
