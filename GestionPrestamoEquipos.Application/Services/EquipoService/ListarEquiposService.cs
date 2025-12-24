using GestionPrestamoEquipos.Application.DToS.EquipoDToS;
using GestionPrestamoEquipos.Application.Interfaces;
using GestionPrestamoEquipos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Application.Services.EquipoService
{
    internal class ListarEquiposService
    {
        private readonly IEquipoRepository _equipoRepository;

        public ListarEquiposService(IEquipoRepository equipoRepository)
        {
            _equipoRepository = equipoRepository;
        }

        public List<ListarEquipoDTO> Ejecutar(string busqueda)
        {
            List<ListarEquipoDTO> listarEquipoDTOs = new List<ListarEquipoDTO>();

            List<Equipo> listaEquipos = _equipoRepository.listarEquipos(busqueda);

            if (listaEquipos.Any())
            {
                foreach (Equipo equ in listaEquipos)
                {
                    listarEquipoDTOs.Add(
                        new ListarEquipoDTO
                        {
                            estado = equ.EstadoEquipo.nombreEstado,
                            idEquipo = equ.idEquipo,
                            nombreEquipo = equ.nombreEquipo,
                            serial = equ.serial,
                            tipo = equ.TipoEquipos.nombreTipo
                        }
                    );
                }
            }

            return listarEquipoDTOs;
        }
    }
}
