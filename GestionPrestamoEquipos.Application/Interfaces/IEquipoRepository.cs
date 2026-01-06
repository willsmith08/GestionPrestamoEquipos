using GestionPrestamoEquipos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Application.Interfaces
{
    public interface IEquipoRepository
    {
        void Agregar(Equipo equipo);
        void Actualizar(Equipo equipo);
        void Eliminar(Equipo equipo);

        List<Equipo> listarEquipos(string busqueda);

        bool ExisteSerial(string serial);

        Equipo EquipoEspecifico(int idEquipo);

        bool VerificarEquipoPrestado(int idEquipo);
    }
}
