﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Herencia
{
    public abstract class Personaje
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Poder { get; set; }
        public string Genero { get; set; }
    }
}
