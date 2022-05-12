using System;
using System.Collections.Generic;
using System.Text;

namespace main
{
    class menu
    {
        Action action = new Action();
        public void menuPrincipal()
        {
            Console.Clear();
            int aux = 1;
            int opcion;
            Console.WriteLine("\n\n                  Menu Principal                              ");
            Console.WriteLine("\n   *************************************************************");
            Console.WriteLine("\n   * 1- Cuántas habitaciones están libres                      *");
            Console.WriteLine("\n   * 2- Cuántas están en mantenimiento                         *");
            Console.WriteLine("\n   * 3- Cuántas habitaciones ocupadas                          *");
            Console.WriteLine("\n   * 4- Cuántas hay desocupadas por cantidad de camas          *");
            Console.WriteLine("\n   * 5- Realizar la ocupación de la habitación                 *");
            Console.WriteLine("\n   * 6- Pagar la habitación utilizando el No. de cédula.       *");
            Console.WriteLine("\n   * 7- Liberar la habitación utilizando el No. de cédula      *");
            Console.WriteLine("\n   * 8- Cuántas personas adultas hay el día de hoy             *");
            Console.WriteLine("\n   * 9- Cuántos niños existen al día de hoy en el hotel        *");
            Console.WriteLine("\n   * 10- Saber cuánto dinero recaudó hoy el hotel. (Sub-Menú)  *");
            Console.WriteLine("\n   * 11- Salir                                                 *");
            Console.WriteLine("\n   *************************************************************");
            Console.WriteLine("\n   Digite una opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    action.freeRooms();
                    Console.WriteLine("Presione Cualquier tecla para continuar ");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    action.maintenanceUnderRooms();
                    Console.WriteLine("Presione Cualquier tecla para continuar ");
                    Console.ReadLine();
                    break;

                case 3:
                    Console.Clear();
                    action.busyRooms();
                    Console.WriteLine("Presione Cualquier tecla para continuar ");
                    Console.ReadLine();
                    break;

                case 4:

                    Console.Clear();
                    action.printHotel();
                    action.cantidadCamas();
                    Console.WriteLine("Presione Cualquier tecla para continuar ");
                    Console.ReadLine();
                    break;

                case 5:
                    Console.Clear();
                    action.reserveRoom();
                    Console.WriteLine("Presione Cualquier tecla para continuar ");
                    Console.ReadLine();
                    break;

                case 6:
                    Console.Clear();
                    action.pagarHabitacion();
                    Console.WriteLine("Presione Cualquier tecla para continuar ");
                    Console.ReadLine();
                    break;

                case 7:
                    Console.Clear();
                    action.liberarLaHabitacion();
                    Console.WriteLine("La habitacion fue liberada ");
                    Console.WriteLine("Presione Cualquier tecla para continuar ");
                    Console.ReadLine();
                    break;
                case 8:
                    Console.Clear();
                    action.cantidadAdultos();
                    Console.WriteLine("Presione Cualquier tecla para continuar ");
                    Console.ReadLine();
                    break;
                case 9:
                    Console.Clear();
                    action.cantidadNinos();
                    Console.WriteLine("Presione Cualquier tecla para continuar ");
                    Console.ReadLine();
                    break;
                case 10:
                    Console.Clear();
                    subMenu();
                    break;
                case 11:
                    Environment.Exit(0);
                    break;
                default:
                    return;

            }

            Console.WriteLine("\n\n");

            if (aux == 1)
            {
                menuPrincipal();
            }

            return;
        }

       public void subMenu()
        {
            Console.Clear();
            int aux = 1;
            int opcionsub;
            Console.WriteLine("\n\n              Sub-Menu Dinero recaudado ");
            Console.WriteLine("\n   *************************************************");
            Console.WriteLine("\n   * 1. Con los clientes, “TODO INCLUIDO”          *");
            Console.WriteLine("\n   * 2- Con los clientes, “Sin TODO INCLUIDO”      *");
            Console.WriteLine("\n   * 3- Con todos los clientes que hay en el hotel *");
            Console.WriteLine("\n   * 4- Volver                                     *");
            Console.WriteLine("\n   *************************************************");
            Console.WriteLine("\n   Digite una opcion: ");
            opcionsub = Convert.ToInt32(Console.ReadLine());
            switch (opcionsub)
            {
                case 1:
                    Console.Clear();
                    action.dineroClientesConTodoIncluido();
                    Console.ReadLine();
                    Console.WriteLine("Presione Cualquier tecla para continuar ");
                    break;
                case 2:
                    Console.Clear();
                    action.dineroClientesSinTodoIncluido();
                    Console.ReadLine();
                    Console.WriteLine("Presione Cualquier tecla para continuar ");
                    break;
                case 3:
                    Console.Clear();
                    action.dineroClientesTotal();
                    Console.ReadLine();
                    Console.WriteLine("Presione Cualquier tecla para continuar ");
                    break;
                case 4:
                    menuPrincipal();
                    break;
                default:
                    break;
            }
            if (aux == 1)
            {
                menuPrincipal();
            }

            return;
        }
    }
}
