using Hotel.Entidades;
using Hotel.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[TestFixture]
public class ReservaRepositoryTests
{
    private ReservaRepository _reservaRepo;

    [SetUp]
    public void Setup()
    {
        _reservaRepo = new ReservaRepository(); // Inicializa el repositorio antes de cada prueba
    }

    [Test]
    public void AgregarReserva_DeberiaAgregarReservaCorrectamente()
    {
        // Arrange
        var reserva = new Reserva { IdReserva = 1, IdCliente = 1, IdHabitacion = 1, FechaInicio = DateTime.Now, FechaFin = DateTime.Now.AddDays(3) };

        // Act
        _reservaRepo.AgregarReserva(reserva);

        // Assert
        var reservaEncontrada = _reservaRepo.BuscarReserva(1);
        Assert.That(reservaEncontrada, Is.Not.Null); // Verifica que la reserva se haya agregado
        Assert.That(reservaEncontrada, Is.EqualTo(reserva)); // Verifica que la reserva agregada sea la correcta
    }

    [Test]
    public void AgregarReserva_SinIdClienteOIdHabitacion_DeberiaLanzarExcepcion()
    {
        // Arrange
        var reserva = new Reserva { IdReserva = 3, FechaInicio = DateTime.Now, FechaFin = DateTime.Now.AddDays(3) };

        // Act
        TestDelegate accion = () => _reservaRepo.AgregarReserva(reserva);

        // Assert
        Assert.Throws<Exception>(accion);
    }
    

    [Test]
    public void CancelarReserva_DeberiaEliminarReservaCorrectamente()
    {
        // Arrange
        var reserva = new Reserva { IdReserva = 1, IdCliente = 1, IdHabitacion = 1, FechaInicio = DateTime.Now, FechaFin = DateTime.Now.AddDays(3) };
        _reservaRepo.AgregarReserva(reserva);

        // Act
        _reservaRepo.CancelarReserva(1);

        // Assert
        var reservaEncontrada = _reservaRepo.BuscarReserva(1);
        Assert.That(reservaEncontrada, Is.Null); // Verifica que la reserva se haya eliminado
    }


    [Test]
    public void CancelarReserva_ReservaNoExistente_NoDeberiaLanzarExcepcion()
    {
        // Arrange
        int idReservaInexistente = 99;

        // Act
        TestDelegate accion = () => _reservaRepo.CancelarReserva(idReservaInexistente);

        // Assert
        Assert.DoesNotThrow(accion);
    }


}
