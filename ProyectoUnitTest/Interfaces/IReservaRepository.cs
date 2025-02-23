using Hotel.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Interfaces
{
    public interface IReservaRepository
    {
        void AgregarReserva(Reserva reserva);
        Reserva BuscarReserva(int idReserva);
        void CancelarReserva(int idReserva);
        List<Reserva> ObtenerHistorialReservas(int idCliente);
        bool ConsultarDisponibilidad(DateTime fechaInicio, DateTime fechaFin);
    }
}
