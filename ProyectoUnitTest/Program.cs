using Hotel.Entidades;
using Hotel.Repositorios;
using Hotel.Servicios;

class Program
{
    static void Main(string[] args)
    {
        // Crear repositorios
        var habitacionRepo = new HabitacionRepository();
        var clienteRepo = new ClienteRepository();
        var reservaRepo = new ReservaRepository();

        // Crear servicios
        var notificacionService = new NotificacionService();
        var facturaService = new FacturaService();
        var reporteService = new ReporteService();

        // Registrar una habitación
        var habitacion = new Habitacion { IdHabitacion = 1, Tipo = "Doble", Precio = 100, Disponible = true };
        habitacionRepo.AgregarHabitacion(habitacion);

        // Registrar un cliente
        var cliente = new Cliente { IdCliente = 1, Nombre = "Juan Perez", Email = "juan@example.com", Telefono = "123456789" };
        clienteRepo.AgregarCliente(cliente);

        // Hacer una reserva
        var reserva = new Reserva { IdReserva = 1, IdCliente = 1, IdHabitacion = 1, FechaInicio = DateTime.Now, FechaFin = DateTime.Now.AddDays(3) };
        reservaRepo.AgregarReserva(reserva);

        // Enviar notificación de check-in
        notificacionService.EnviarNotificacion(cliente, "Su check-in está programado para el " + reserva.FechaInicio);

        // Generar factura
        facturaService.GenerarFactura(reserva);

        // Generar reporte de ocupación
        reporteService.GenerarReporteOcupacion(DateTime.Now, DateTime.Now.AddDays(7));
    }
}