using GestionPrestamoEquipos.Application.Interfaces;
using GestionPrestamoEquipos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Application.Services.EnvioCorreosService
{
    internal class EnvioCorreoRegistroEmpleado
    {

        public async void AvisoRegistro(Empleado empleadoRecibir, Administrador adminEnviar, bool confirmacion)
        {
            await Task.Run(() =>
            {
                try
                {
                    using (MailMessage correo = new MailMessage())
                    {
                        correo.BodyEncoding = Encoding.UTF8;
                        correo.From = new MailAddress(adminEnviar.Empleado.e_mail);
                        correo.To.Add(empleadoRecibir.e_mail);

                        

                    }
                }
                catch (Exception ex) 
                { 
                    Console.WriteLine($"Error al enviar correo de registro: {ex}"); 
                }
            });
        }
    }
}
