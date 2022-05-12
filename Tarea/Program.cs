using main;
using System;


namespace Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            menu m = new menu();
            m.menuPrincipal();
            Hotel h = new Hotel();
            hotelDisplay hdisplay = new hotelDisplay();
            hdisplay.imprimirHotel(h);
        }
    }
}
