using Patron.FábricaAbstracta.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.FábricaAbstracta.Implementacion
{
    public class ConexionRESTCompras : IConexionREST
    {
        public void LeerURL(string url)
        {
            Console.WriteLine("Conectandose a " + url);
        }
    }
}
