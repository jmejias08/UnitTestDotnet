using Hotel.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Servicios
{
    public class NotificacionService : Interfaces.INotificacionService
    {
        public void EnviarNotificacion(Cliente cliente, string mensaje)
        {
            Console.WriteLine($"Enviando notificación a {cliente.Nombre} ({cliente.Email}): {mensaje}");
        } //
    }
}
