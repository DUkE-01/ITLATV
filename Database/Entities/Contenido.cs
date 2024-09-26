using Database.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class Contenido : BaseBasicEntity
    {

        public string ImagenPortada { get; set; }
        public string EnlaceVideo { get; set; }
        public int ProductoraId { get; set; }
        public int GenerosId { get; set; }
        public Productora? Productora { get; set; }
        public ICollection<Generos>? Generos { get; set; }


    }
}
