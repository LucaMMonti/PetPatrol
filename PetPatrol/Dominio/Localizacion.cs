using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Localizacion
    {
        public int ID { get; set; }
        public string Calles { get; set; }
        public string Provincia { get; set; }
        public string Barrio { get; set; }
        public string Coordenadas { get; set; }
    }
}
