using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Entidades
{
    public class Habitacion
    {
        public int IdHabitacion { get; set; } // Identificador único de la habitación
        public string Tipo { get; set; } // Tipo de habitación (Ej: Individual, Doble, Suite)
        public decimal Precio { get; set; } // Precio por noche
        public bool Disponible { get; set; } // Indica si la habitación está disponible
    }
}
