using System;
using System.Collections;
using System.Text;

namespace main
{
    class Piso
    {
        private ArrayList habitaciones;

        

        public Piso(ArrayList habitaciones)
        {
            this.habitaciones = habitaciones;  
        }
        public Piso()
        {
            habitaciones = new ArrayList();
            for (int j = 0; j < 4; j++)
            {
                habitaciones.Add(new Habitaciones());
            }

        }

        public ArrayList Habitaciones { get => habitaciones; set => habitaciones = value; }


        public void liberarHabitacion(Hotel h, string id)
        {
            {

                foreach (Piso p in h.Pisos1)
                {
                    foreach (Habitaciones hab in p.Habitaciones)
                    {
                        if (hab.ClienteAsignado != null) {
                            if (hab.ClienteAsignado.IDCliente == id) {

                                if (hab.ClienteAsignado != null)
                                {
                                    hab.ClaseHabitacion = null;
                                    hab.ClienteAsignado = null;
                                    hab.Estado = "Libre";
                                    break;
                                }
                            }
                            else
                            {

                            }
                        }
                    }
                }
            }
        }
        public void reservarHabitacion(string idHabitacion,Hotel h,Informacion inf,Cliente c)
        {
            
            foreach (Piso p in h.Pisos1)
            {
                foreach (Habitaciones hab in p.Habitaciones )
                {
                        
                    if (idHabitacion == hab.IdHabitacion)
                    {
                        hab.InfoHab = inf;
                        hab.ClienteAsignado = c;
                        hab.Estado = "Ocupado";
                        
                    }
                }
                
            }
        }
        

        public void pagarHabitacion(Hotel h, string id)
        {
            double costoT = 0;

            foreach (Piso p in h.Pisos1)
            {
                foreach (Habitaciones hab in p.Habitaciones)
                {
                    if (hab.ClienteAsignado != null) {
                        if (id == hab.ClienteAsignado.IDCliente)
                        {
                            if (hab.ClaseHabitacion == "PC")
                            {
                                costoT = hab.InfoHab.Costo;
                                costoT = costoT + (costoT * 0.30);
                            }
                            else if (hab.ClaseHabitacion == "SC")
                            {
                                costoT = hab.InfoHab.Costo;
                                costoT = costoT + (costoT * 0.20);
                            }

                        }

                    }
                }
            }
        }






    }
}
