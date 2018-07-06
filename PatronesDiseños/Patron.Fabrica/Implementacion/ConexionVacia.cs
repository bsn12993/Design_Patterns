using Patron.Fabrica.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.Fabrica.Implementacion
{
    public class ConexionVacia : IConexion
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
