using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int ID { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set;}
        public int Telefono { get; set; }
        public string Email { get; set; }
        public List<Imagen> Imagenes { get; set; }
        public int RolId { get; set; }
    }
}
