using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;


namespace Negocio
{
    public class ProductoNegocio
    {

        //FUNCION PARA LISTAR LOS DATOS DE LA BBDD
        public List<Productos> listar()
        {
            //INSTANCIO LA LISTA
            List<Productos> lista = new List<Productos>();
            //DECLARO EL OBJETO
            Productos aux;
            //INSTANCIO LA CONECCION A LA BASE
            AccesoDatos datos = new AccesoDatos();
                //TIRO LA QUERY
                datos.setearQuery("select id, titulo, descripcion, URLImagen from productos");
                //EJECUTO EL LECTOR
                datos.ejecutarLector();

            //MIENTRAS EL LECTOR LEA, DEVULVE LOS DATOS (DEBE COINSIDIR CON LA QUERY)
           
                while (datos.lector.Read())
                {
                    aux = new Productos();
                    aux.ID = Convert.ToInt32(datos.getReader()["id"]);
                    aux.Titulo = datos.lector["Titulo"].ToString();
                    aux.Descripcion = datos.lector["Descripcion"].ToString();
                    aux.URLImagen = datos.lector["URLImagen"].ToString();

                    lista.Add(aux);
                }
                return lista;
                //datos.cerrarConexion();
        }
        
    }
}
