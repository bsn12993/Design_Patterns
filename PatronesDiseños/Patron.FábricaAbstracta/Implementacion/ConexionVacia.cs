
using Patron.FábricaAbstracta.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.FábricaAbstracta.Implementacion
{
    public class ConexionVacia : IConexionBD
    {
        public void conectar()
        {
            Console.WriteLine("No se especificó proveedor");
        }

        public void desconectar()
        {
            Console.WriteLine("No se especificó proveedor");
        }
    }
}
