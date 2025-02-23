using Hotel.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Interfaces
{
    public interface IHabitacionRepository
    {
        void AgregarHabitacion(Habitacion habitacion);
        List<Habitacion> BuscarHabitacion(string tipo = null, decimal? precio = null, bool? disponible = null);
        void ActualizarHabitacion(Habitacion habitacion);
        void EliminarHabitacion(int idHabitacion);
    }
}
