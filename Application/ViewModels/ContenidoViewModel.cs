using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class ContenidoViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ImagenPortada { get; set; }
        public string EnlaceVideo { get; set; }
        public int ProductoraId { get; set; }
        public Productora Productora { get; set; }
        public ICollection<Genero> Generos { get; set; }
    }
}
