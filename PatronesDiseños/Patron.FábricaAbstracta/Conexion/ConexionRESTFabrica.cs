using Patron.FábricaAbstracta.Implementacion;
using Patron.FábricaAbstracta.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.FábricaAbstracta.Conexion
{
    public class ConexionRESTFabrica : FabricaAbstracta
    {
        public IConexionBD getBD(string bd)
        {
            throw new NotImplementedException();
        }

        public IConexionREST getREST(string area)
        {
            if (area == null) return new ConexionRESTNoAreas();
            else if (area.Equals("COMPRAS")) return new ConexionRESTCompras();
            else if (area.Equals("VENTAS")) return new ConexionRESTVentas();
            return new ConexionRESTNoAreas();
        }
    }
}
