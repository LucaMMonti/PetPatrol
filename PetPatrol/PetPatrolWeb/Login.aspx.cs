using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetPatrolWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string contrasena = txtContrasena.Text;

            // Aquí se debe implementar la lógica para verificar las credenciales del usuario.
            // Si las credenciales son correctas, redirige al usuario a la página principal o a su perfil.

            // Ejemplo de redirección:
            // Response.Redirect("Default.aspx");
        }   
    }
}