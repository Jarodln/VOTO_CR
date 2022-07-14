using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Padron
    {
        protected int Id { get; set; }
        protected int IdUsuario { get; set; }
        protected string CodigoElectoral { get; set; }
        protected DateTime FechaVencimiento { get; set; }
        protected int JuntaReceptora { get; set; }
        protected string Nombre { get; set; }
        protected string PrimerApellido { get; set; }
        protected string SegundoApellido { get; set; }
    }
}
