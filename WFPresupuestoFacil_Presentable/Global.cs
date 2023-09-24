using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresupuestoFacil_CapaDatos
{
    public class Global
    {
        private static int _globalVarId = 0;
        private static string _globalVarNombre = "";
        private static string _globalVarClave = "";
        private static int _globalVarIdPerfil = 0;
        private static string _globalVarPerfil = "";

        public static int GlobalVarId
        {
            get { return _globalVarId; }
            set { _globalVarId = value; }
        }
        public static string GlobalVarNombre
        {
            get { return _globalVarNombre; }
            set { _globalVarNombre = value; }
        }

        public static string GlobalVarClave
        {
            get { return _globalVarClave; }
            set { _globalVarClave = value; }
        }

        public static int GlobalVarIdPerfil
        {
            get { return _globalVarIdPerfil; }
            set { _globalVarIdPerfil = value; }
        }
        public static string GlobalVarPerfil
        {
            get { return _globalVarPerfil; }
            set { _globalVarPerfil = value; }
        }
    }
}
