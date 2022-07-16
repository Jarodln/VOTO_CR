using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Votacion
    {
        protected int Id { get; set; }
        protected int IdUsuario { get; set; }
        protected DateTime Fecha { get; set; }
        protected string Hora { get; set; }
        protected int CodigoElectoral { get; set; }
        protected int CodigoPresidente { get; set; }
        protected int CodigoDiputado { get; set; }
    }
}
