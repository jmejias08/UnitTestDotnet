using NUnit.Framework;
using Hotel.Entidades;
using Hotel.Repositorios;
using System.Collections.Generic;

[TestFixture]
public class HabitacionRepositoryTests
{
    private HabitacionRepository _habitacionRepo;

    [SetUp]
    public void Setup()
    {
        _habitacionRepo = new HabitacionRepository(); // Inicializa el repositorio antes de cada prueba
    }

    [Test]
    public void AgregarHabitacion_DeberiaAgregarHabitacionCorrectamente()
    {
        // Arrange
        var habitacion = new Habitacion { IdHabitacion = 1, Tipo = "Doble", Precio = 100, Disponible = true };

        // Act
        _habitacionRepo.AgregarHabitacion(habitacion);

        // Assert
        var habitaciones = _habitacionRepo.BuscarHabitacion();
        Assert.That(habitaciones.Count, Is.EqualTo(1)); // Verifica que se haya agregado una habitación
        Assert.That(habitaciones[0], Is.EqualTo(habitacion)); // Verifica que la habitación agregada sea la correcta
    }

    [Test]
    public void BuscarHabitacion_DeberiaFiltrarPorTipo()
    {
        // Arrange
        var habitacion1 = new Habitacion { IdHabitacion = 1, Tipo = "Doble", Precio = 100, Disponible = true };
        var habitacion2 = new Habitacion { IdHabitacion = 2, Tipo = "Individual", Precio = 50, Disponible = true };
        _habitacionRepo.AgregarHabitacion(habitacion1);
        _habitacionRepo.AgregarHabitacion(habitacion2);

        // Act
        var habitaciones = _habitacionRepo.BuscarHabitacion(tipo: "Doble");

        // Assert
        Assert.That(habitaciones.Count, Is.EqualTo(1)); // Verifica que solo haya una habitación del tipo "Doble"
        Assert.That(habitaciones[0].Tipo, Is.EqualTo("Doble")); // Verifica que el tipo de la habitación sea "Doble"
    }
}