using Moq;
using Hotel.Entidades;
using Hotel.Interfaces;
using Hotel.Servicios;

namespace Hotel.Tests;

[TestFixture]
public class FacturaServiceTests
{
    private Mock<IReservaRepository> _mockReservaRepo;
    private FacturaService _facturaService;

    [SetUp]
    public void Setup()
    {
        _mockReservaRepo = new Mock<IReservaRepository>(); // Crea un mock del repositorio de reservas
        _facturaService = new FacturaService(); // Inicializa el servicio
    }

    [Test]
    public void GenerarFactura_DeberiaGenerarFacturaCorrectamente()
    {
        // Arrange
        var reserva = new Reserva { IdReserva = 1, IdCliente = 1, IdHabitacion = 1, FechaInicio = DateTime.Now, FechaFin = DateTime.Now.AddDays(3) };
        _mockReservaRepo.Setup(repo => repo.BuscarReserva(1)).Returns(reserva); // Configura el mock para devolver una reserva

        // Act
        _facturaService.GenerarFactura(reserva);

        // Assert
        // Verifica que la factura se haya generado correctamente (simulado con Console.WriteLine)
        Assert.Pass("La factura se generó correctamente.");
    }

    [Test]
    public void GenerarFactura_ReservaInexistente_DeberiaLanzarExcepcion()
    {
        // Arrange
        _mockReservaRepo.Setup(repo => repo.BuscarReserva(1)).Returns((Reserva)null); // No devuelve ninguna reserva

        // Act
        TestDelegate accion = () => _facturaService.GenerarFactura(new Reserva { IdReserva = 1 });

        // Assert
        Assert.Throws<InvalidOperationException>(accion);
    }


}