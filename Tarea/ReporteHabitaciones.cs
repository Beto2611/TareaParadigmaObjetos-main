using System;
using System.Collections.Generic;
using System.Text;

namespace main
{
    class ReporteHabitaciones : IReportes
    {
        public int habitacionesEnMantenimiento(Hotel h)
        {
            int contador = 0;
            foreach (Piso p in h.Pisos1)
            {
                foreach (Habitaciones hab in p.Habitaciones)
                {
                    if (hab.Estado == "Mantenimiento")
                    {
                        contador++;
                    }
                }
            }
            return contador;
        }

        public int habitacionesLibres(Hotel h)
        {
            int contador = 0;
            foreach (Piso p in h.Pisos1)
            {
                foreach (Habitaciones hab in p.Habitaciones)
                {
                    if (hab.Estado == "Libre")
                    {
                        contador++;
                    }
                }
            }
            return contador;
        }

        public int habitacionesOcupadas(Hotel h)
        {
            int contador = 0;
            foreach (Piso p in h.Pisos1)
            {
                foreach (Habitaciones hab in p.Habitaciones)
                {
                    if (hab.Estado == "Ocupado")
                    {
                        contador++;
                    }
                }
            }
            return contador;
        }
    }   
}

