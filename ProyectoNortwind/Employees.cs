using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoNortwind
{
    public partial class Employees
    {
        public string NombresCompletos()
        {
            return "NOMBRE:"+ FirstName + "   APELLIDO:"+ LastName+"  PROFESSION: "+ Title +"  DIRECCION:"+ Address +"   REGION:"+ Region +"    PAIS:"+ Country;

        }
    }
}