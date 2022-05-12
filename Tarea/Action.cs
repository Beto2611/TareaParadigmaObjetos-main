using System;
using System.Collections.Generic;
using System.Text;

namespace main
{

    class Action
    {
        Hotel h = new Hotel();
        Piso P = new Piso();
        Cliente c = new Cliente();
        Informacion inf = new Informacion();
        hotelDisplay hdisplay = new hotelDisplay();
        ReporteHabitaciones reporteHab = new ReporteHabitaciones();
        ReportesPersonas reportePersonas = new ReportesPersonas();
        ReportesClientes reportesClientes = new ReportesClientes();

        public void freeRooms()
        {
            Console.WriteLine("La cantidad de habitaciones disponibles \n");

            Console.Write(reporteHab.habitacionesLibres(h));
            Console.WriteLine(" \n");

        }


        public void maintenanceUnderRooms()
        {
            Console.WriteLine("La cantidad de habitaciones en Mantenimiento");
            Console.Write(reporteHab.habitacionesEnMantenimiento(h));
            Console.WriteLine(" \n");


        }

        public void busyRooms()
        {
            Console.WriteLine("La cantidad de habitaciones Ocupadas");
            Console.Write(reporteHab.habitacionesOcupadas(h));
            Console.WriteLine("\n");
        }

        public void pagarHabitacion()
        {
            string idCliente;
            Console.WriteLine("Digite su numero de cedula para pagar");
            idCliente = Console.ReadLine();
            P.pagarHabitacion(h, idCliente);
            Console.WriteLine("\n");
        }


        public void printHotel()
        {
            hdisplay.imprimirHotel(h);



        }
        public void printBed()
        {
         
        }

        public void reserveRoom()
        {
            string nombre;
            string idCliente;
            string metodoPago;
            string telefono;
            string numeroCuenta;
            Console.WriteLine("Digite el nombre del cliente: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Digite el ID del cliente: ");
            idCliente = Console.ReadLine();
            Console.WriteLine("Digite textualmente el metodo de pago del cliente: ");
            Console.WriteLine("1.Efectivo\n");
            Console.WriteLine("2.Tarjeta de débito\n");
            Console.WriteLine("3.Tarjeta de crédito\n");
            metodoPago = Console.ReadLine();
            Console.WriteLine("Digite  el numero telefonico del cliente: ");
            telefono = Console.ReadLine();
            Console.WriteLine("Digite textualmente el numero de cuenta del cliente: ");
            numeroCuenta = Console.ReadLine();
            c.IDCliente = idCliente;
            c.NombreCliente = nombre;
            c.MetodoPago = metodoPago;
            c.Telefono = telefono;

            int canAdultos = 0;
            int canNinos = 0;
            int canDias = 0;
            bool todoIncluido = false;
            double costo = 0;
            char cti;
            bool a = false;
            int canPersonas = 0;
            int horaEntrada = 0;
            double descuento = 0;
            string habId;

            Console.WriteLine("Digite cantidad de personas adultas(minimo 1): ");
            canAdultos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cantidad de adultos procesada.. ");
            if (canAdultos < 0)
            {
                Console.WriteLine("Numero invalido Digitelo Nuevamente");
                canAdultos = Convert.ToInt32(Console.ReadLine());
            }

            else
            {
                Console.WriteLine("Digite cantidad de ninos: ");
                canNinos = Convert.ToInt32(Console.ReadLine()); ;
                while (canNinos > (5 - canAdultos))
                {
                    Console.WriteLine("Digite cantidad de personas ninos: ");
                    canNinos = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Digite S si es todo incluido o digite N si no es todo includo: ");
                cti = Convert.ToChar(Console.ReadLine());
                //------------------------
                if (cti == 'S')
                {
                    a = true;
                    todoIncluido = true;
                }
                else todoIncluido = false;
                canPersonas = canNinos + canAdultos;
                //--------------------
                if (todoIncluido)
                {
                    costo = (canAdultos * 300) + (canNinos * 200);
                }
                else
                {
                    Console.WriteLine("Digite la hora de entrada al hotel(ejemplo 13 seria para la 1 pm)");
                    horaEntrada = Convert.ToInt32(Console.ReadLine());
                    if (horaEntrada > 18)
                    {
                        switch (canPersonas)
                        {
                            case 1:
                                descuento = 0.25;
                                break;
                            case 2:
                                descuento = 0.20;
                                break;
                            case 3:
                                descuento = 0.15;
                                break;
                            default:
                                descuento = 0.10;
                                break;
                        }
                    }

                }
                //--------------------
                Console.WriteLine("Digite la cantidad de noches a quedarse: ");
                canDias = Convert.ToInt32(Console.ReadLine());
                switch (canPersonas)
                {

                    case 1:
                        if (a)
                        {
                            costo = costo * canDias;
                        }
                        else
                        {
                            costo = 150 * canDias;
                            costo = costo + (costo * descuento);
                        }
                        break;
                    case 2:
                        if (a)
                        {
                            costo = costo * canDias;
                        }
                        else
                        {
                            costo = 250 * canDias;
                            costo = costo + (costo * descuento);
                        }
                        break;
                    case 3:
                        if (a)
                        {
                            costo = costo * canDias;
                        }
                        else
                        {
                            costo = 350 * canDias;
                            costo = costo + (costo * descuento);
                        }
                        break;
                    default:
                        if (a)
                        {
                            costo = costo * canDias;
                        }
                        else
                        {
                            costo = 400 * canDias;
                            costo = costo + (costo * descuento);
                        }
                        break;
                }


            }
            inf.CanAdultos = canAdultos;
            inf.CanDias = canDias;
            inf.Costo = costo;
            inf.Infantes = canNinos;
            inf.TodoIncluido = todoIncluido;
            printHotel();
            Console.WriteLine("Digite el id de la habitacion que desea:");
            habId = Console.ReadLine();
            P.reservarHabitacion(habId, h, inf, c);

        }
        public void liberarLaHabitacion()
        {
            string idCliente;
            Console.WriteLine("Digite el id del cliente para la habitacion que desea liberar: ");
            idCliente = Console.ReadLine();
            P.liberarHabitacion(h, idCliente);

        }

        public void cantidadAdultos()
        {
            Console.WriteLine("La cantidad de adultos en el Hotel es de");
            Console.WriteLine(reportePersonas.CantidadPersonasAdultas(h));
            Console.WriteLine(" \n");


        }

        public void cantidadNinos()
        {
            Console.WriteLine("La cantidad de ninos en el Hotel es de");
            Console.WriteLine(reportePersonas.CantidadNinos(h));
            Console.WriteLine(" \n");



        }
        public void dineroClientesSinTodoIncluido()
        {
            Console.WriteLine("La cantidad de dinero Clientes Sin todo Incluido es de");
            Console.WriteLine(reportesClientes.dineroClientesSinTodoIncluido(h));
            Console.WriteLine(" \n");

        }
        public void dineroClientesConTodoIncluido()
        {
            Console.WriteLine("La cantidad de dinero Clientes Sin todo Incluido es de");
            Console.WriteLine(reportesClientes.dineroClientesTodoIncluido(h));
            Console.WriteLine("\n");

        }
        public void dineroClientesTotal()
        {
            Console.WriteLine("La cantidad de dinero Recaudado en el hotel");
            Console.WriteLine(reportesClientes.dineroClientesTotal(h));
            Console.WriteLine("\n");
        }


        public void cantidadCamas(){

            int canPisos;
            Console.WriteLine("Digite la cantidad de habitaciones que necesita");
            canPisos = Convert.ToInt32(Console.ReadLine());
            hdisplay.imprimirCamas(h,canPisos);
            Console.WriteLine("\n");
        }
    }








    }
   


