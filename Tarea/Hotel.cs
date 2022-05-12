using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace main
{
    class Hotel
    {

        private ArrayList Pisos;
        int tamFilas;
        int tamCol;
       public Hotel()
        {           
            Pisos = new ArrayList();
            for (int i = 0; i < 4; i++)
            {
                Pisos.Add(new Piso());
            }
        }

        public ArrayList Pisos1 { get => Pisos; set => Pisos = value; }
    }

 
}
