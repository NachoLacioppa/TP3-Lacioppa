using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Web
{
    public partial class Premios : System.Web.UI.Page
    {
       public List<Productos> listaProductos { get; set; }
    
        protected void Page_Load(object sender, EventArgs e)
        {
            //EN LA CARGA DE LA PAGINA LLAMO A LA LISTA DEL OBJ PRODUCTOS
            ProductoNegocio negocio = new ProductoNegocio();
            listaProductos = negocio.listar();

        }


       
    }
}