using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionPrestamoEquipos.Application.Interfaces;
using GestionPrestamoEquipos.Application.DToS;
using GestionPrestamoEquipos.Application.DToS.EquipoDToS;

namespace GestionPrestamoEquipos.Application.Services.EquipoService
{
    internal class RegistraEquipoService
    {
        private readonly IEquipoRepository _equipoRepository;

        public RegistraEquipoService(IEquipoRepository equipoRepository)
        {
            _equipoRepository = equipoRepository;
        }

        public void Ejecutar(RegistrarEquipoDToS equipoDTO)
        {
            if (
                string.IsNullOrWhiteSpace(equipoDTO.descripcion) ||
                string.IsNullOrWhiteSpace(equipoDTO.nombreEquipo) ||
                string.IsNullOrWhiteSpace(equipoDTO.serial) ||
                equipoDTO.idEstado == 0 ||
                equipoDTO.idTipo == 0
                )
            {
                throw new Exception("Debe actualizar almenos un campo");
            }



        }
    }
}
