using System;
using System.Collections.Generic;
using System.Text;

namespace main
{
    class hotelDisplay
    {
        public hotelDisplay() { 
        
        }
        public void imprimirHotel(Hotel h) {
            String imp = "";
            foreach (Piso p in h.Pisos1)
            {
                foreach (Habitaciones hab in p.Habitaciones)
                {
                    imp = imp + "[" +"H"+hab.IdHabitacion + "." + hab.Estado + "." + hab.ClaseHabitacion + "]";                   
               }
                Console.WriteLine(imp);
                imp = "";
                Console.WriteLine("\n");
            }

        }

        public void imprimirCamas(Hotel h, int numPisos)
        {
            String imp = "";
            
            foreach (Piso p in h.Pisos1)
            {
                foreach (Habitaciones hab in p.Habitaciones)
                {
                    if (numPisos == hab.NumCams) {
                        imp = imp + "[" + "H" + hab.IdHabitacion + "." + hab.Estado + "." + hab.ClaseHabitacion + "]";
                    }

                }
                Console.WriteLine(imp);
                imp = "";
                Console.WriteLine("\n");
            }

        }

    }
}
