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


        protected void btnPremio_Click(Object sender, CommandEventArgs e)
        {
            AccesoDatos dt = new AccesoDatos();
            ProductoNegocio n = new ProductoNegocio();
            
  
            dt.prepareStatement("update Vouchers set idProducto = @idProducto where CodigoVoucher = @Codigovoucher");
            dt.agregarParametro("@CodigoVoucher", Context.Items["CodigoVoucher"]);
            dt.agregarParametro("@idProducto", );
            dt.ejecutarAccion();

            ScriptManager.RegisterStartupScript(this, this.GetType(),"alert","alert('Premio elegido!');window.location ='DatosClientes.aspx';",true);
        }
    }
}