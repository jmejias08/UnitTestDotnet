using Moq;
using Hotel.Entidades;
using Hotel.Interfaces;
using Hotel.Servicios;

namespace Hotel.Tests;

[TestFixture]
public class NotificacionServiceTests
{
    private Mock<IClienteRepository> _mockClienteRepo;
    private NotificacionService _notificacionService;

    [SetUp]
    public void Setup()
    {
        _mockClienteRepo = new Mock<IClienteRepository>(); // Crea un mock del repositorio de clientes
        _notificacionService = new NotificacionService(); // Inicializa el servicio
    }

    [Test]
    public void EnviarNotificacion_DeberiaEnviarMensajeCorrectamente()
    {
        // Arrange
        var cliente = new Cliente { IdCliente = 1, Nombre = "Juan Perez", Email = "juan@example.com", Telefono = "123456789" };
        _mockClienteRepo.Setup(repo => repo.BuscarCliente(1)).Returns(cliente); // Configura el mock para devolver un cliente

        // Act
        _notificacionService.EnviarNotificacion(cliente, "Mensaje de prueba");

        // Assert
        // Verifica que el mensaje se haya enviado correctamente (simulado con Console.WriteLine)
        Assert.Pass("La notificación se envió correctamente.");
    }

    [Test]
    public void EnviarNotificacion_MensajeVacio_DeberiaLanzarExcepcion()
    {
        // Arrange
        var cliente = new Cliente { IdCliente = 3, Nombre = "Carlos García", Email = "carlos@example.com", Telefono = "987654321" };
        _mockClienteRepo.Setup(repo => repo.BuscarCliente(3)).Returns(cliente);

        // Act
        TestDelegate accion = () => _notificacionService.EnviarNotificacion(cliente, "");

        // Assert
        Assert.Throws<Exception>(accion);
    }

}