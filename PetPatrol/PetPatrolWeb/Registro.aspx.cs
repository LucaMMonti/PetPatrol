using Dominio;
using Negocio;
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
                Contrasena = txtContrasena.Text, // INVESTIGAR HASHING PARA CONTRASEÑAS
                Direccion = txtDireccion.Text,
                Telefono = Convert.ToInt32(txtTelefono.Text),
                Email = txtEmail.Text,
                //Procesar la imagen de perfil, analizar
            };

            UsuarioNegocio negocio = new UsuarioNegocio();
            negocio.RegistrarUsuario(usuario);

            // Redirecciona o muestra un mensaje de éxito
        }
    }
}