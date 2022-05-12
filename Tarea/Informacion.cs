using System;
using System.Collections.Generic;
using System.Text;

namespace main
{
    class Informacion
    {
      private int canAdultos;
      private int infantes;
      private int canDias;
      private bool todoIncluido;
      private double costo;

        public Informacion(int canAdulto,int infante,int canDia,bool Tincluido)
        {
            this.canAdultos = canAdulto;
            this.infantes = infante;
            this.canDias = canDia;
            this.todoIncluido = Tincluido;
        }
        public Informacion()
        {
            this.canAdultos = 0;
            this.infantes = 0;
            this.canDias = 0;
            this.todoIncluido = false;
        }

        public int CanAdultos
        {
            get { return canAdultos; }
            set { canAdultos = value; }
        }
        public int Infantes {
            get { return infantes; }
            set { infantes = value;}
        }
        public int CanDias
        {
            get { return canDias; }
            set { canDias = value;}
        }

        public bool TodoIncluido {
            get { return todoIncluido; }
            set { todoIncluido = value;}
        
        }

        public double Costo {
            get { return costo; }
            set { costo = value; } 
        }
    }
}
