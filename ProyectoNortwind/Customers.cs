using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoNortwind
{
    public partial class Customers
    {
        //Declarar  un  metodo para obtener todos los datos del cliente
        public string NombresCompletos()
        {
            return ContactName + "   " + ContactTitle;

    }
    }
}