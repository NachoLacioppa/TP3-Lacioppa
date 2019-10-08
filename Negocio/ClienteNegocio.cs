using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;



namespace Negocio
{
    class ClienteNegocio
    {
        public bool altaCliente(Clientes aux)
        {
           
                AccesoDatos data = new AccesoDatos();
                data.prepareStatement("" +
                    "INSERT INTO Clientes VALUES ('" + aux.DNI + "', '" + aux.Nombre + "', '" + aux.Apellido + "', '" + aux.Email + "', '" + aux.Direccion + "', '" + aux.Ciudad + "', '" + aux.codigopostal + "', '" + DateTime.Now + "')");
                data.ejecutarAccion();
                data.cerrarConexion();

                if (data.getAffectedRows() <= 0)
                {
                    return false;
                }
                else return true;
        }
    }
}
