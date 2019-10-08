using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TP_Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        protected void btnVoucher_Click(object sender, EventArgs e)
        {
            AccesoDatos dt = new AccesoDatos();
            List<Vouchers> vou = new List<Vouchers>();
            VoucherNegocio voun = new VoucherNegocio();

            vou = voun.getVoucher(txtVoucher.Text);

            if (vou.Count == 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('VOUCHER EN USO O NO EXISTE');window.location ='Index.aspx';", true);
            }
            else
            {
                Context.Items["CodigoVoucher"] = txtVoucher.Text;
                dt.prepareStatement("update Vouchers set estado = 1 where CodigoVoucher = @CodigoVoucher");
                dt.agregarParametro("@CodigoVoucher", txtVoucher.Text);
                dt.ejecutarAccion();

                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('VOUCHER GANADOR!!!');window.location ='Premios.aspx';", true);
            }
        }   
    }
}
