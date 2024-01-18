using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class RolNegocio
    {
        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT RolId, NombreRol FROM Roles");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Rol rol = new Rol
                    {
                        RoleId = (int)datos.Lector["RolId"],
                        RoleName = (string)datos.Lector["NombreRol"]
                    };
                    lista.Add(rol);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            return lista;
        }

        public Rol ObtenerRolPorId(int rolId)
        {
            Rol rol = new Rol();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT RolId, NombreRol FROM Roles WHERE RolId = @RolId");
                datos.agregarParametro("@RolId", rolId);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    rol.RoleId = (int)datos.Lector["RolId"];
                    rol.RoleName = (string)datos.Lector["NombreRol"];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return rol;
        }
    }


}
