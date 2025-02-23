using Hotel.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositorios
{
    public class HabitacionRepository  : Interfaces.IHabitacionRepository
    {
        private List<Habitacion> _habitaciones = new List<Habitacion>(); // Lista en memoria para simular una base de datos

        public void AgregarHabitacion(Habitacion habitacion)
        {
            _habitaciones.Add(habitacion); // Agrega una nueva habitación a la lista
        }

        public List<Habitacion> BuscarHabitacion(string tipo = null, decimal? precio = null, bool? disponible = null)
        {
            return _habitaciones
                .Where(h => (tipo == null || h.Tipo == tipo) &&
                            (precio == null || h.Precio <= precio) &&
                            (disponible == null || h.Disponible == disponible))
                .ToList(); // Filtra las habitaciones según los criterios proporcionados
        }

        public void ActualizarHabitacion(Habitacion habitacion)
        {
            var habExistente = _habitaciones.FirstOrDefault(h => h.IdHabitacion == habitacion.IdHabitacion);
            if (habExistente != null)
            {
                habExistente.Tipo = habitacion.Tipo;
                habExistente.Precio = habitacion.Precio;
                habExistente.Disponible = habitacion.Disponible;
            } // Actualiza los datos de una habitación existente
        }

        public void EliminarHabitacion(int idHabitacion)
        {
            _habitaciones.RemoveAll(h => h.IdHabitacion == idHabitacion); // Elimina una habitación por su ID
        }
    }
}
