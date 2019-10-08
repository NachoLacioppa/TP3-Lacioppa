using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Vouchers
    {
        public int ID { get; set; }
        public string CodigoVoucher { get; set; }
        public int Estado { get; set; }
        public Clientes idcliente { get; set; }
        public Clientes fechaRegistro { get; set; }
        public Productos idproducto { get; set; }
    }
}
