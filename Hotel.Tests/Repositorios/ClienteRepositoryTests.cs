using Hotel.Entidades;
using Hotel.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[TestFixture]
public class ClienteRepositoryTests
{
    private ClienteRepository _clienteRepo;

    [SetUp]
    public void Setup()
    {
        _clienteRepo = new ClienteRepository(); // Inicializa el repositorio antes de cada prueba
    }

    [Test]
    public void AgregarCliente_DeberiaAgregarClienteCorrectamente()
    {
        // Arrange
        var cliente = new Cliente { IdCliente = 1, Nombre = "Juan Perez", Email = "juan@example.com", Telefono = "123456789" };

        // Act
        _clienteRepo.AgregarCliente(cliente);

        // Assert
        var clienteEncontrado = _clienteRepo.BuscarCliente(1);
        Assert.That(clienteEncontrado, Is.Not.Null); // Verifica que el cliente se haya agregado
        Assert.That(clienteEncontrado, Is.EqualTo(cliente)); // Verifica que el cliente agregado sea el correcto
    }

    [Test]
    public void EliminarCliente_DeberiaEliminarClienteCorrectamente()
    {
        // Arrange
        var cliente = new Cliente { IdCliente = 1, Nombre = "Juan Perez", Email = "juan@example.com", Telefono = "123456789" };
        _clienteRepo.AgregarCliente(cliente);

        // Act
        _clienteRepo.EliminarCliente(1);

        // Assert
        var clienteEncontrado = _clienteRepo.BuscarCliente(1);
        Assert.That(clienteEncontrado, Is.Null); // Verifica que el cliente se haya eliminado
    }
}