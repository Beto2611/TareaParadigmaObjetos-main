using System;
using System.Collections.Generic;
using System.Text;

namespace main
{
    class Cliente : Persona
    {
       private string metodoPago;
       private string telefono;
        
        public Cliente(string nameClient,string idClient,string metodoPag,string telefon):base(nameClient,idClient)
        {
            this.metodoPago = metodoPag;
            this.telefono = telefon;
        } 
        public Cliente()
        {
            metodoPago = "";
            telefono = "";
        }
        
        public string MetodoPago
        {
            get { return metodoPago; }
            set { metodoPago = value; }

        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }



    }
}
