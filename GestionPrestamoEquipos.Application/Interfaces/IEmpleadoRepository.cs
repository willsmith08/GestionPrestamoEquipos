using GestionPrestamoEquipos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GestionPrestamoEquipos.Application.Interfaces
{
    public interface IEmpleadoRepository
    {
        void Agregar(Empleado empleado);
        void Eliminar(Empleado empleado);
        void Actualizar(Empleado empleado);
        List<Empleado> ListarEmpleados(string busqueda);

        bool ExiteGmail(string gmailEmpleado);
        bool ExisteDocumento(int documento);
        bool VericacionPrestamosMora(int idEmpleado);
        Empleado EmpleadoEspecifico(int idEmpleadi);
        Empleado EmpleadoEspecificoDoc(int documento);
    }
}
