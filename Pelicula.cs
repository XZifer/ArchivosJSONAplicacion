using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosJSONAplicacion
{
    class Pelicula
    {
        public string Nombre { get; set; }
        public int Año { get; set; }
        public TipoGenero Genero { get; set; }
        public bool EsParaAdultos { get; set; }
        public List<Actor> Actores { get; set; }
    }
}
