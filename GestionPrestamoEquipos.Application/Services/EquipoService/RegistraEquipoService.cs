using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionPrestamoEquipos.Application.Interfaces;
using GestionPrestamoEquipos.Application.DToS;
using GestionPrestamoEquipos.Application.DToS.EquipoDToS;
using GestionPrestamoEquipos.Domain.Entities;

namespace GestionPrestamoEquipos.Application.Services.EquipoService
{
    internal class RegistraEquipoService
    {
        private readonly IEquipoRepository _equipoRepository;
        private readonly ITipoEquipoRepository _tipoEquipoRepository;
        private readonly IEstadoEquipoRepository _estadoEquipoRepository;

        public RegistraEquipoService(IEquipoRepository equipoRepository, ITipoEquipoRepository tipoEquipoRepository, IEstadoEquipoRepository estadoEquipoRepository)
        {
            _equipoRepository = equipoRepository;
            _tipoEquipoRepository = tipoEquipoRepository;
            _estadoEquipoRepository = estadoEquipoRepository;
        }

        public void Ejecutar(RegistrarEquipoDToS equipoDTO)
        {
            if (
                string.IsNullOrWhiteSpace(equipoDTO.descripcion) ||
                string.IsNullOrWhiteSpace(equipoDTO.nombreEquipo) ||
                string.IsNullOrWhiteSpace(equipoDTO.serial)
                )
            {
                throw new Exception("Debe actualizar almenos un campo");
            }

            if ( equipoDTO.idEstado == 0)
            {
                throw new Exception("Seleccione el estado en el que se encuentra el equipo");
            }
            if (equipoDTO.idTipo == 0)
            {
                throw new Exception("Seleccione un tipo de equipo");
            }

            TipoEquipo tipoEquipoBuscado = _tipoEquipoRepository.TipoEspecifico(equipoDTO.idTipo);

            if (tipoEquipoBuscado == null)
            {
                throw new Exception("Tipo equipo invalido");
            }

            EstadoEquipo estadoEquipoBuscado = _estadoEquipoRepository.EstadoEquipoEspecifico(equipoDTO.idEstado);

            if (estadoEquipoBuscado == null)
            {
                throw new Exception("Estado equipo invalido");
            }

            if (_equipoRepository.ExisteSerial(equipoDTO.serial))
            {
                throw new Exception("Ya existe un equipo registrado con este numero de serie");
            }

            Equipo equipo = new Equipo();
            equipo.cambiardescripcion(equipoDTO.descripcion);
            equipo.cambiarNombreEquipo(equipoDTO.nombreEquipo);
            equipo.cambiarEstadoEquipo(estadoEquipoBuscado);
            equipo.cambiarSerial(equipoDTO.serial);
            equipo.cambiarTipoEquipo(tipoEquipoBuscado);

            _equipoRepository.Agregar(equipo);


        }
    }
}
