using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Comentario
    {
        public int ID { get; set; }
        public string Texto { get; set; }
        public DateTime Fecha { get; set; }
        public int UsuarioID { get; set; }
        public int PublicacionID { get; set; }
    }
}
