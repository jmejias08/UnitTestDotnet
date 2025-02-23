using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Servicios
{
    class ReporteService : Interfaces.IReporteService
    {
        public void GenerarReporteOcupacion(DateTime fechaInicio, DateTime fechaFin)
        {
            Console.WriteLine($"Generando reporte de ocupación desde {fechaInicio} hasta {fechaFin}");
        } // Simula la generación de un reporte de ocupación
    }
}
