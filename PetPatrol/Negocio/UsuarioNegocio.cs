using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public void RegistrarUsuario(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //Incluir la lógica para hash de la contraseña
                string consulta = "INSERT INTO Usuarios (NombreUsuario, Contrasena, Nombre, Apellido, Direccion, Telefono, Email, RolId) VALUES (@NombreUsuario, @Contrasena, @Nombre, @Apellido, @Direccion, @Telefono, @Email, @RolId)";
                datos.setearConsulta(consulta);
                datos.agregarParametro("@NombreUsuario", usuario.NombreUsuario);
                datos.agregarParametro("@Contrasena", usuario.Contrasena);
                datos.agregarParametro("@Nombre", usuario.Nombre);
                datos.agregarParametro("@Apellido", usuario.Apellido);
                datos.agregarParametro("@Direccion", usuario.Direccion);
                datos.agregarParametro("@Telefono", usuario.Telefono);
                datos.agregarParametro("@Email", usuario.Email);
                datos.agregarParametro("@RolId", usuario.RolId);
                                
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

    }
}
