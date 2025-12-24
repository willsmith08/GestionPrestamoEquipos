using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionPrestamoEquipos.Application.DToS;
using GestionPrestamoEquipos.Application.Interfaces;
using GestionPrestamoEquipos.Domain.Entities;

namespace GestionPrestamoEquipos.Application.Services.CargoService
{
    internal class ListarCargoEmpleadoService
    {
        private readonly ICargoEmpleadoRepository _cargoEmpleadoRepository;

        public ListarCargoEmpleadoService(ICargoEmpleadoRepository cargoEmpleadoRepository)
        {
            this._cargoEmpleadoRepository = cargoEmpleadoRepository;
        }

        public List<CargoEmpleadoDTO> Ejecutar()
        {
            List<CargoEmpleadoDTO> listaCargos = new List<CargoEmpleadoDTO>();

            List<CargoEmpleado> cargosEmpleados = _cargoEmpleadoRepository.ListarCargos();

            if (!cargosEmpleados.Any())
            {
                throw new Exception("No existen cargos registrados");
            }

            foreach (CargoEmpleado cargo in cargosEmpleados)
            {
                listaCargos.Add(new CargoEmpleadoDTO
                {
                    idCargo = cargo.idCargo,
                    nombreCargo = cargo.nombreCargo,
                });
            }

            return listaCargos;
        }
    }
}
