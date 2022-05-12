using System;
using System.Collections.Generic;
using System.Text;

namespace main
{
    class ReportesPersonas : IReportes
    {
        public int CantidadPersonasAdultas(Hotel h)
        {
            int contador = 0;
            foreach (Piso p in h.Pisos1)
            {
                foreach (Habitaciones hab in p.Habitaciones)
                {
                    contador = contador + hab.InfoHab.CanAdultos;
                }
            }
            return contador;
        }

        public int CantidadNinos(Hotel h)
        {
            int contador = 0;
            foreach (Piso p in h.Pisos1)
            {
                foreach (Habitaciones hab in p.Habitaciones)
                {
                    contador = contador + hab.InfoHab.Infantes;
                }
            }
            return contador;
        }


    }
}
