using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IFTP1.Interfaces;

namespace IFTP1.EE
{
    public class EEUsuario : Entity, IUsuario
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumDocumento { get; set; }
        public string Telefono { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaBaja { get; set; }

    }
}
