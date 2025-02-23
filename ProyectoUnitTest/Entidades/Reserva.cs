using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Entidades
{
    public class Reserva
    {
        public int IdReserva { get; set; } // Identificador único de la reserva
        public int IdCliente { get; set; } // ID del cliente que realiza la reserva
        public int IdHabitacion { get; set; } // ID de la habitación reservada
        public DateTime FechaInicio { get; set; } // Fecha de inicio de la reserva
        public DateTime FechaFin { get; set; } // Fecha de fin de la reserva
    }
}
