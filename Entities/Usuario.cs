using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Usuario
    {
        protected int Id { get; set; }
        protected int Cedula { get; set; }
        protected string NombreUsuario { get; set; }
        protected string Contrasenna { get; set; }
        protected string Correo { get; set; }
        protected string Nombre { get; set; }
        protected string PrimerApellido { get; set; }
        protected string SegundoApellido { get; set; }
        protected DateTime FechaVencimiento { get; set; }
        protected int IdPregSeguridad { get; set; }
        protected string RespuestaSeguridad { get; set; }
        protected int IdPerfil { get; set; }
        protected string CodigoElectoral { get; set; }
        protected string Estado { get; set; }
    }
}
