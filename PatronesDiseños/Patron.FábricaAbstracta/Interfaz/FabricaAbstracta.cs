 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.FábricaAbstracta.Interfaz
{
    public interface FabricaAbstracta
    {
        IConexionBD getBD(string bd);
        IConexionREST getREST(string area);
    }
}
