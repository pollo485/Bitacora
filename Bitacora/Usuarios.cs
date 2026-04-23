using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitacora
{
    public class Usuarios
    {
        public string NombreUsuario { get; set; } = "";
        public string ContrasenaUsuario { get; set; } = "";
        public DateTime FechaUsuario { get; set; } = DateTime.Now;
    }
}
