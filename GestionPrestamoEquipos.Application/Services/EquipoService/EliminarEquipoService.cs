using GestionPrestamoEquipos.Application.Interfaces;
using GestionPrestamoEquipos.Application.DToS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionPrestamoEquipos.Application.DToS.EquipoDToS;
using GestionPrestamoEquipos.Domain.Entities;

namespace GestionPrestamoEquipos.Application.Services.EquipoService
{
    internal class EliminarEquipoService
    {
        private readonly IEquipoRepository _equipoRepository;
        public EliminarEquipoService(IEquipoRepository equipoRepository)
        {
            _equipoRepository = equipoRepository;
        }

        public void Ejecutar(EliminarEquipoDTO eliminarEquipoDTO)
        {
            if (eliminarEquipoDTO.idEquipo == 0)
            {
                throw new Exception("Seleccione un equipo valido");
            }

            Equipo equipoBuscado = _equipoRepository.EquipoEspecifico(eliminarEquipoDTO.idEquipo);

            if (equipoBuscado == null)
            {
                throw new Exception("Seleccione un equipo valido");
            }

            if (_equipoRepository.VerificarEquipoPrestado(equipoBuscado.idEquipo))
            {
                throw new Exception("No se pueden eliminar equipos con prestamos activos");
            }

            _equipoRepository.Eliminar(equipoBuscado);
        }
    }
}
