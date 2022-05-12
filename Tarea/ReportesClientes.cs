using System;
using System.Collections.Generic;
using System.Text;

namespace main
{
    class ReportesClientes
    {
        public double dineroClientesTodoIncluido(Hotel h)
        {
            double contadorDinero = 0;
            foreach (Piso p in h.Pisos1)
            {
                foreach (Habitaciones hab in p.Habitaciones)
                {
                    if (hab.InfoHab.TodoIncluido)
                    {
                        contadorDinero = contadorDinero + hab.InfoHab.Costo;
                    }
                    
                }
            }
            return contadorDinero;
        }

        public double dineroClientesSinTodoIncluido(Hotel h)
        {
            double contadorDinero = 0;
            foreach (Piso p in h.Pisos1)
            {
                foreach (Habitaciones hab in p.Habitaciones)
                {
                    if (!hab.InfoHab.TodoIncluido)
                    {
                        contadorDinero = contadorDinero + hab.InfoHab.Costo;
                    }

                }
            }
            return contadorDinero;
        }
        public double dineroClientesTotal(Hotel h)
        {
            double contadorDinero = 0;
            foreach (Piso p in h.Pisos1)
            {
                foreach (Habitaciones hab in p.Habitaciones)
                {
                    
                        contadorDinero = contadorDinero + hab.InfoHab.Costo;
                    

                }
            }
            return contadorDinero;
        }
    }
}
