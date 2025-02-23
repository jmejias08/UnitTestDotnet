using Hotel.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Interfaces
{
    public interface IClienteRepository
    {
        void AgregarCliente(Cliente cliente);
        Cliente BuscarCliente(int idCliente);
        void ActualizarCliente(Cliente cliente);
        void EliminarCliente(int idCliente);
    }
}
