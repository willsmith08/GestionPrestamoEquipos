using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionPrestamoEquipos.Domain.Entities;

namespace GestionPrestamoEquipos.Application.Interfaces
{
    internal interface ICargoEmpleadoRepository
    {
        CargoEmpleado ObtnerCargoEmpleadoPorId(int idCargo);
    }
}
