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

            dt.prepareStatement("insert into Clientes (DNI, Nombre, Apellido, EMail, Direccion, Ciudad, CodigoPostal, FechaRegistro) values (@DNI, @Nombre, @Apellido, @EMail, @Direccion, @Ciudad, @CodigoPostal, @FechaRegistro)");
            dt.agregarParametro("@DNI", txtDni.Text);
            dt.agregarParametro("@Nombre", txtNombre.Text);
            dt.agregarParametro("@Apellido", txtApellido.Text);
            dt.agregarParametro("@Email", txtEmail.Text);
            dt.agregarParametro("@Direccion", txtDireccion.Text);
            dt.agregarParametro("@Ciudad", txtCiudad.Text);
            dt.agregarParametro("@CodigoPostal", txtPostal.Text);
            dt.agregarParametro("@FechaRegistro", txtFecha.Text);
            dt.ejecutarAccion();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Registro Completo');window.location ='RegistroCorrecto.aspx';", true);
        }
    }
}