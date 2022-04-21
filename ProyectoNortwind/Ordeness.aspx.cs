using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoNortwind
{
    public partial class Ordeness : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PedidoDataContext pedidos = new PedidoDataContext();
            var consulta = from O in pedidos.Orders
                           select O;
            GridView1.DataSource = consulta;
            GridView1.DataBind();

        }
    }
}