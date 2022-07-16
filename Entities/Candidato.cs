using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Candidato
    {
        protected int CodigoCandidato { get; set; }
        protected int Cedula { get; set; }
        protected string UrlImagen { get; set; }
        protected int IdPuesto { get; set; }
        protected int IdPartido { get; set; }
    }
}
