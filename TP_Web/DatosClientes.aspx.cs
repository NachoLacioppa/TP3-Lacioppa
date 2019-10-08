using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using System.Data.SqlClient;



namespace TP_Web
{
    public partial class DatosClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            AccesoDatos dt = new AccesoDatos();


            dt.prepareStatement("update Vouchers set estado = 1 where CodigoVoucher = @CodigoVoucher");
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Registro Completo');window.location ='RegistroCorrecto.aspx';", true);
        }
    }
}