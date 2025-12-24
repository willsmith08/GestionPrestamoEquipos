using GestionPrestamoEquipos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Application.Interfaces
{
    internal interface IEquipoRepository
    {
        void Agregar(Equipo equipo);
        void Actualizar(Equipo equipo);
        void Eliminar(Equipo equipo);

        List<Equipo> listarEquipos();

        bool ExisteSerial(string serial);
    }
}
