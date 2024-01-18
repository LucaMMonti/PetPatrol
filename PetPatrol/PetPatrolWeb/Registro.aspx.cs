using Dominio;
using System;

namespace PetPatrolWeb
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario
            {
                NombreUsuario = txtNombreUsuario.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Contrasena = txtContrasena.Text, // Considera aplicar hashing a la contraseña aquí
                                                 // Continúa asignando el resto de las propiedades
            };

            UsuarioNegocio negocio = new UsuarioNegocio();
            negocio.RegistrarUsuario(usuario);

            // Redirecciona o muestra un mensaje de éxito
        }
    }
}