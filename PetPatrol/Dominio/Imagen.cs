﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Imagen
    {
        public int Id { get; set; }
        public string ImagenURL { get; set; }
        public int IdEntidad { get; set; }
        public string TipoEntidad { get; set; }
    }
}