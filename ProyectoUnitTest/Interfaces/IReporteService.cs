﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Interfaces
{
    public interface IReporteService
    {
        void GenerarReporteOcupacion(DateTime fechaInicio, DateTime fechaFin);
    }
}
