using Hotel.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositorios
{
    public class ReservaRepository : Interfaces.IReservaRepository
    {
        private List<Reserva> _reservas = new List<Reserva>(); // Lista en memoria para simular una base de datos

        public void AgregarReserva(Reserva reserva)
        {
            _reservas.Add(reserva); // Agrega una nueva reserva a la lista
        }

        public Reserva BuscarReserva(int idReserva)
        {
            return _reservas.FirstOrDefault(r => r.IdReserva == idReserva); // Busca una reserva por su ID
        }

        public void CancelarReserva(int idReserva)
        {
            _reservas.RemoveAll(r => r.IdReserva == idReserva); // Cancela una reserva por su ID
        }

        public List<Reserva> ObtenerHistorialReservas(int idCliente)
        {
            return _reservas.Where(r => r.IdCliente == idCliente).ToList(); // Obtiene el historial de reservas de un cliente
        }

        public bool ConsultarDisponibilidad(DateTime fechaInicio, DateTime fechaFin)
        {
            // Verifica si hay habitaciones disponibles en el rango de fechas especificado
            return _reservas.All(r => r.FechaFin <= fechaInicio || r.FechaInicio >= fechaFin);
        }
    }
}
