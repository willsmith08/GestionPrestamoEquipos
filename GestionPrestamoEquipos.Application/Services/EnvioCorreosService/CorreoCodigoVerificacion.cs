using GestionPrestamoEquipos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GestionPrestamoEquipos.Application.Services.EnvioCorreosService
{
    public class CorreoCodigoVerificacion
    {
        public static int codigoVerificacion { get; private set; } = 0;
        public async void EnviarCodigo(Empleado empleadoRecibe, Empleado adminEnvia)
        {
            await Task.Run(() =>
            {
                codigoVerificacion = new Random().Next(100,999);

                using (MailMessage correo = new MailMessage())
                {
                    correo.From = new MailAddress(adminEnvia.e_mail);
                    correo.To.Add(empleadoRecibe.e_mail);
                    correo.Subject = "VERIFICACION DE REGISTRO";
                    correo.Body = $@"
Hola {empleadoRecibe.nombreEmpleado},

Para continuar con el proceso de verificación de tu cuenta, por favor ingresa el siguiente código en el sistema:

🔐 Código de verificación: {codigoVerificacion}

Este código es válido por 5 minutos.  
Si tú no solicitaste este código, por favor ignora este mensaje.

Saludos cordiales,
Sistema de Gestión de Préstamos de Equipos
";

                    using (SmtpClient smtp = new SmtpClient())
                    {
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;

                        smtp.UseDefaultCredentials = false;

                        smtp.EnableSsl = true;

                        smtp.Credentials = new NetworkCredential("willtoncel@gmail.com", "panaeutabncqidqa");

                        smtp.Send(correo);
                    }
                }
            });
        }

        public void EliminarCodigo()
        {
            codigoVerificacion = 0;
        }
    }
}
