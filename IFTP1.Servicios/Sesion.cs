using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using IFTP1.Interfaces;

namespace IFTP1.Servicios
{
    public class Sesion
    {
        private static Sesion _instance;
        
        public static Sesion Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Sesion();
                }

                return _instance;
            }
        }

        private IUsuario _user;

        public IUsuario User
        {
            get { return _user; }
        }
        
        public bool isLogged()
        {
            return this._user != null;
        }
        public void Login(IUsuario _user)
        {
            this._user = _user;
        }

        public void Logout()
        {
            this._user = null;
        }
    }
}
