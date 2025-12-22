using GestionPrestamoEquipos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GestionPrestamoEquipos.Application.Interfaces
{
    internal interface IEmpleadoRepository
    {
        void Agregar(Empleado empleado);
        void Eliminar(Empleado empleado);
        void Editar(Empleado empleado);
        List<Empleado> ListarEmpleados();

        bool ExiteGmail(string gmailEmpleado);
        bool ExisteDocumento(int documento);
    }
}
