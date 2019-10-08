using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class VoucherNegocio
    {
        public List<Vouchers> getVoucher(string codVoucher)
        {
            AccesoDatos data = new AccesoDatos();

            data.setearQuery("select Id, CodigoVoucher, Estado, IdCliente, IdProducto, FechaRegistro from Vouchers where Estado = 0 and CodigoVoucher = '" + codVoucher + "'");
            data.ejecutarLector();
            List<Vouchers> ListaVoucher = new List<Vouchers>();
            Vouchers aux = new Vouchers();

            while (data.getReader().Read())
            {

                aux.ID = Convert.ToInt32(data.getReader()["Id"]);
                aux.CodigoVoucher = data.getReader()["CodigoVoucher"].ToString();
                aux.Estado = Convert.ToInt32(data.getReader()["Estado"]);
                if (!Convert.IsDBNull(data.getReader()["IdCliente"]))
                {
                    aux.idcliente = (Clientes)data.getReader()["IdCliente"];
                }
                else
                {
                    aux.idcliente = null;
                }

                if (!Convert.IsDBNull(data.getReader()["IdProducto"]))
                {
                    aux.idproducto = (Productos)data.getReader()["IdProducto"];
                }
                else
                {
                    aux.idproducto = null;
                }

                if (!Convert.IsDBNull(data.getReader()["FechaRegistro"]))
                {
                    aux.fechaRegistro = (Clientes)data.getReader()["FechaRegistro"];
                }
                else
                {
                    aux.fechaRegistro = null;
                }

                ListaVoucher.Add(aux);
            }

            return ListaVoucher;
        }
    }
}
