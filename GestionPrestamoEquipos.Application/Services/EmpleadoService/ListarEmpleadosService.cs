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
    internal class ListarEmpleadosService
    {
        private readonly IEmpleadoRepository _empleadoRepository;

        public ListarEmpleadosService(IEmpleadoRepository empleadoRepository)
        {
            this._empleadoRepository = empleadoRepository;
        }

        public List<MostrarEmpleadoDTO> Ejecutar(string busqueda)
        {
            List<MostrarEmpleadoDTO> listaEmpleados = new List<MostrarEmpleadoDTO>();

            List<Empleado> empleados = _empleadoRepository.ListarEmpleados(busqueda);

            if (!empleados.Any())
            {
                return listaEmpleados;
            }

            foreach (Empleado empl in empleados)
            {
                listaEmpleados.Add(
                    new MostrarEmpleadoDTO
                    {
                        id = empl.idEmpleado,
                        documento = empl.documentoEmpleado,
                        gmail = empl.e_mail,
                        nombreEmpleado = empl.nombreEmpleado,
                        nombreCargo = empl.CargoEmpleado.nombreCargo,
                    }
                );
            }

            return listaEmpleados;
        }
    }
}
