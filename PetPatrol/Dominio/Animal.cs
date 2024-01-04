using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Animal
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public string Sexo { get; set; }
        public string Color { get; set; }
        public int Edad { get; set; }
        public string Tamanio { get; set; }
        public string Descripcion { get; set; }
        public bool Perdido { get; set; }
        public List<Imagen> Imagenes { get; set; }
        public string FechaPerdida { get; set; }
        public string FechaEncontrada { get; set; }
        public string FechaAdopcion { get; set; }
        public bool Castrado { get; set; }
    }
}
