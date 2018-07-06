using Patron.FábricaAbstracta.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.FábricaAbstracta.Conexion
{
    public static class FabricaProductor
    {
        private static FabricaAbstracta conexionAbstracta;
        
        public static FabricaAbstracta getProductor(string valor)
        {
            if (valor.Equals("BD")) return conexionAbstracta = new ConexionBDFabrica();
            else if (valor.Equals("REST")) return conexionAbstracta = new ConexionRESTFabrica();
            return conexionAbstracta;
        }
    }
}
