﻿using Database.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class Generos : BaseBasicEntity
    {
        public ICollection<Contenido>? Contenido { get; set; }
    }
}
