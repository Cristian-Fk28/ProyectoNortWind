using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoNortwind
{
    public partial class Clientes : System.Web.UI.Page
    {
        PedidoDataContext pedido = new PedidoDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DropDownList1.DataSource = from p in pedido.Customers select p;
                DropDownList1.DataTextField = "CustomerID";
                DropDownList1.DataValueField = "CustomerID";
                DropDownList1.DataBind();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            PedidoDataContext pedido = new PedidoDataContext();
            var consulta = from C in pedido.Customers
                           select C;
            GridView1.DataSource = consulta;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            PedidoDataContext pedido = new PedidoDataContext();
            var consulta = from C in pedido.Customers
                           select new
                           {
                               Compañia=C.CompanyName,
                               Cliente=C.ContactName,
                               Profesion=C.ContactTitle
                           };
            GridView1.DataSource = consulta;
            GridView1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (PedidoDataContext pedido = new PedidoDataContext())
            {

                var consulta = pedido.Customers.Where(C => C.CustomerID == DropDownList1.SelectedValue);
                GridView1.DataSource = consulta;
                GridView1.DataBind();


            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            using (PedidoDataContext pedido = new PedidoDataContext())
            {
                var nro =TextBox1.Text;
                var consulta = pedido.Customers.Where(C => C.Phone == nro);
                GridView1.DataSource = consulta;
                GridView1.DataBind();

            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            using (PedidoDataContext ventas = new PedidoDataContext())
            {

                using (PedidoDataContext pedido = new PedidoDataContext())
                {
                    var nro = TextBox2.Text;
                    var consulta = pedido.Customers.Where(C => C.City == nro);
                    GridView1.DataSource = consulta;
                    GridView1.DataBind();

                }
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            using (PedidoDataContext ventas = new PedidoDataContext())
            {

                var consulta = from C in ventas.Customers
                               select new
                               {

                                      ID= C.CustomerID,
                                   Nombre_Completos_y_Profesion = C.NombresCompletos(),
                                   C.Address

                               };
                GridView1.DataSource = consulta;
                GridView1.DataBind();

            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            using (PedidoDataContext ventas = new PedidoDataContext())
            {

                var consulta = from P in ventas.Orders
                               group P by P.Customers.CustomerID into D
                               select new
                               {

                                   CustomerID=D.Key,
                                   ID_de_Empleado = D.Average(P=>P.EmployeeID),
                                   Nombre_del_Barco = D.Where(P => P.ShipName).ToLIST(),
                                   Fecha_de_Orden = D.Select(P => P.OrderDate),
                                   Fecha_de_Envio = D.Select(P => P.ShippedDate),
                                   Promedio_de_Transportes = D.Average(P=>P.Freight),
                                   Cantidad = D.Count(),
                                   Pais_de_Envio=D.Select(P=>P.ShipRegion)

                               };
                GridView1.DataSource = consulta;
                GridView1.DataBind();

            }
        }
    }
}