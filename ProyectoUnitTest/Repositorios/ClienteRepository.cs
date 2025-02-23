using Hotel.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositorios
{
    public class ClienteRepository : Interfaces.IClienteRepository
    {
        private List<Cliente> _clientes = new List<Cliente>(); // Lista en memoria para simular una base de datos

        public void AgregarCliente(Cliente cliente)
        {
            _clientes.Add(cliente); // Agrega un nuevo cliente a la lista
        }

        public Cliente BuscarCliente(int idCliente)
        {
            return _clientes.FirstOrDefault(c => c.IdCliente == idCliente); // Busca un cliente por su ID
        }

        public void ActualizarCliente(Cliente cliente)
        {
            var cliExistente = _clientes.FirstOrDefault(c => c.IdCliente == cliente.IdCliente);
            if (cliExistente != null)
            {
                cliExistente.Nombre = cliente.Nombre;
                cliExistente.Email = cliente.Email;
                cliExistente.Telefono = cliente.Telefono;
            } // Actualiza los datos de un cliente existente
        }

        public void EliminarCliente(int idCliente)
        {
            _clientes.RemoveAll(c => c.IdCliente == idCliente); // Elimina un cliente por su ID
        }
    }
}
