using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionPrestamoEquipos.Domain.Entities
{
    public class CargoEmpleado
    {
        public int idCargo { get; private set; }
        public string nombreCargo { get; private set; }

        private IReadOnlyCollection<Empleado> empleados;
        
        public CargoEmpleado(string nombreCargo)
        {
            cambiarNombreCargo(nombreCargo);
        }

        protected CargoEmpleado() { }

        private void cambiarNombreCargo(string nombreCargo)
        {
            if (string.IsNullOrWhiteSpace(nombreCargo))
            {
                throw new Exception("Nombre invalido");
            }
            this.nombreCargo = nombreCargo;
        }

        
    }
}
