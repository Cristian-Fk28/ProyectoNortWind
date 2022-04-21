using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoNortwind
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PedidoDataContext pedidos = new PedidoDataContext();
            var consulta = from P in pedidos.Products
                           select P;
            GridView1.DataSource = consulta;
            GridView1.DataBind();
        }
    }
}