using GestionPrestamoEquipos.Application.Interfaces;
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
    internal class CorreoRegistroEmpleadoExitosoService
    {

        public async void Ejecutar(Empleado empleadoRecibir, Administrador adminEnviar)
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

                        correo.Subject = "SU RGISTRO A SIDO PROCESADO";

                        correo.Body = $@"
Estimado(a) {empleadoRecibir.nombreEmpleado},

Le informamos que su registro en el Sistema de Gestión de Préstamos de Equipos ha sido completado con éxito.

📅 Fecha de registro: {DateTime.Now}

Ya puede acceder al sistema y realizar operaciones según los permisos establecidos para su cargo.

Si necesita asistencia, estamos a su disposición.

Atentamente,  
Equipo de Gestión de Préstamos de Equipos
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
                }
                catch (Exception ex) 
                { 
                    Console.WriteLine($"Error al enviar correo de registro: {ex}"); 
                }
            });
        }
    }
}
