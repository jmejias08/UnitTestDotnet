using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Entidades
{
    public class Cliente
    {
        public int IdCliente { get; set; } // Identificador único del cliente
        public string Nombre { get; set; } // Nombre completo del cliente
        public string Email { get; set; } // Correo electrónico del cliente
        public string Telefono { get; set; } // Número de teléfono del cliente
    }
}
