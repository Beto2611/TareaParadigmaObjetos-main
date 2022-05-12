using System;
using System.Collections.Generic;
using System.Text;

namespace main
{
    class Habitaciones
    {
        private string idHabitacion;
        private string estado;
        private string claseHabitacion;
        private int habitacionAsignada;
        private int numCamas;
        private Informacion infoHab;
        private Cliente clienteAsignado;

        public Habitaciones(string idHabitacion,string estado,string claseHabitacion,int habitacionAsignada,int numCamas,Informacion infoHab,Cliente clienteAsignado)
        {
            this.idHabitacion = idHabitacion;
            this.estado = estado;
            this.claseHabitacion = claseHabitacion;
            this.habitacionAsignada = habitacionAsignada;
            this.numCamas = numCamas;
            this.infoHab = infoHab;
            this.clienteAsignado = clienteAsignado;

        }

        public Habitaciones()
        {
            this.idHabitacion = idGenerator.GetInstance().generarId();
            this.estado = "Libre";
            this.claseHabitacion = idGenerator.GetInstance().generarClaseHabitacion();
            this.habitacionAsignada = 0;
            this.numCamas = idGenerator.GetInstance().generarNumeroCamas();
            this.infoHab = new Informacion();
            this.clienteAsignado = null;

        }
        public string IdHabitacion {

            get { return idHabitacion; }
            set { idHabitacion = value; }
        }
        public string Estado {
           get { return estado; }
           set { estado = value;}        
        
        }
        public string ClaseHabitacion {
            get { return claseHabitacion ; }
            set { claseHabitacion = value; }
        }
        public int HabitacionAsignada {
            get { return habitacionAsignada; }
            set { habitacionAsignada = value; }
        }

        public int NumCams {
            get { return numCamas; }
            set { numCamas = value; }
        
        }

        public Informacion InfoHab
        {
            get { return infoHab; }
            set { infoHab = value; }
        }



        public Cliente ClienteAsignado
        {
            get { return clienteAsignado; }
            set { clienteAsignado = value; }

        }











    }




}
