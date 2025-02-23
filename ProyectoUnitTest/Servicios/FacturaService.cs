using Hotel.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Servicios
{
    public class FacturaService : Interfaces.IFacturaService
    {
        public void GenerarFactura(Reserva reserva)
        {
            Console.WriteLine($"Generando factura para la reserva {reserva.IdReserva}");
        } // Simula la generación de una factura
    }
}
