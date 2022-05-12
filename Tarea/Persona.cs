using System;
using System.Collections.Generic;
using System.Text;

namespace main
{
    class Persona
    {
        private string nombreCliente;
        private string idCliente;

        public Persona(string nameClient,string idClient)
        {
            this.nombreCliente = nameClient;
            this.idCliente = idClient;
        }
        public Persona()
        {
            nombreCliente = "";
            idCliente = "";
        }

       public string NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }
        public string IDCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

    }

}
