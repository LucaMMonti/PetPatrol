using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Publicacion
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public List<Imagen> Imagenes { get; set; }
        public string TipoPublicacion { get; set; }
        public string Estado { get; set; }
        public int UsuarioID { get; set; }
        public int AnimalID { get; set; }
        public int LocalizacionID { get; set; }
        public int ComentarioID { get; set; }
        public int NotificacionID { get; set; }
    }
}
