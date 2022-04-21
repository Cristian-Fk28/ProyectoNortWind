using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoNortwind
{
    public partial class Products
    {
        public string NombresCompletos()
        {
            return "NOMBRE: "+ProductName + "    Cantidad Por unidad:" + QuantityPerUnit+"    Precio:  "+ UnitPrice;

        }
    }
}