using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Domain.Entities
{
    public class CargoEmpleado
    {
        public CargoEmpleado(int idCargoEmpleado)
        {
            this.idCargo = idCargoEmpleado;
        }
        public CargoEmpleado() { }

        public int idCargo { get; private set; }
        public string nombreCargo { get; private set; }

        public CargoEmpleado(string nombreCargo)
        {
            editarNombreCargo(nombreCargo);
        }

        private void editarNombreCargo(string nombreCargo)
        {
            if (string.IsNullOrEmpty(nombreCargo))
            {
                throw new Exception("Nombre no puede estar vacio");
            }
            if (string.IsNullOrWhiteSpace(nombreCargo))
            {
                throw new Exception("Nombre no puede estar vacio");
            }
            this.nombreCargo = nombreCargo;
        }

        public List<Empleado> Empleados { get; private set; }
    }
}
