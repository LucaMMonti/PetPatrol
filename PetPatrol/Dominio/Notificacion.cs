using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Notificacion
    {
        public int ID { get; set; }
        public string Texto { get; set; }
        public DateTime Fecha { get; set; }
        public int UsuarioID { get; set; }
        public int PublicacionID { get; set; }
        public bool Estado { get; set; }
    }
}
