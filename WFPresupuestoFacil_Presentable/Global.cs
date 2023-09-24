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
        private static string _globalVarCorreo = "";
        private static string _globalVarTelefono = "";
        private static int _globalVarEdad = 0;
        private static string _globalVarPosicion = "";

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

        public static string GlobalVarCorreo
        {
            get { return _globalVarCorreo; }
            set { _globalVarCorreo = value; }
        }
        public static string GlobalVarTelefono
        {
            get { return _globalVarTelefono; }
            set { _globalVarTelefono = value; }
        }

        public static int GlobalVarEdad
        {
            get { return _globalVarEdad; }
            set { _globalVarEdad = value; }
        }
        public static string GlobalVarPosicion
        {
            get { return _globalVarPosicion; }
            set { _globalVarPosicion = value; }
        }

    }
}
