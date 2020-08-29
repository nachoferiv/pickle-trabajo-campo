using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFTP1.Interfaces
{
    public interface IUsuario
    {
        string Username { get; set; }
        string Password { get; set; }
    }
}
