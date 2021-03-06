using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class PrioridadNegocio
    {
        public void agregar(Prioridad nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string valores = "values('" + nuevo.PrioridadIncidente + "')";
                datos.setearConsulta("INSERT INTO PRIORIDADES (PrioridadIncidente)" + valores);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }
        }
        //PORQUE MUESTRA DOMINIO.PRIORIDAD Y NO EL CONTENIDO?

        public List<Prioridad> listarPrioridades()
        {
            List<Prioridad> lista = new List<Prioridad>();
            Prioridad aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select P.ID Id, P.PrioridadIncidente PrioridadIncidente from PRIORIDADES P");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    aux = new Prioridad(datos.Lector["PrioridadIncidente"].ToString());
                    aux.ID = (int)datos.Lector["ID"];
                    //aux.PrioridadIncidente = datos.Lector["PrioridadIncidente"].ToString();

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete From PRIORIDADES Where ID = " + id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
                datos = null;
            }
        }
        public void modificarPrioridad(Prioridad modificar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update PRIORIDADES set PrioridadIncidente = @prioridad Where ID = @id");
                datos.setearParametro("@prioridad", modificar.PrioridadIncidente);
                datos.setearParametro("@id", modificar.ID);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public Prioridad traerPrioridad(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                Prioridad aux = new Prioridad("5");
                datos.setearConsulta("select P.PrioridadIncidente from PRIORIDADES P WHERE P.ID = " + id);
                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    aux.PrioridadIncidente = (string)datos.Lector["PrioridadIncidente"];
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
