using GestionPrestamoEquipos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Application.Interfaces
{
    public interface IPrestamoRepository
    {
        void Agregar(Prestamo prestamo);
        void Eliminar(Prestamo prestamo);
        void Actualizar(Prestamo prestamo);

        List<Prestamo> ListarPrestamos();

        List<Prestamo> PrestamosMora();
    }
}
