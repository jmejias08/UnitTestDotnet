using Hotel.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Interfaces
{
    public interface INotificacionService
    {
        void EnviarNotificacion(Cliente cliente, string mensaje);

    }
}
