using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patron.Singleton.Conexion;

namespace Patron.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //El patron singleton permite crear una unica instancia de una clase para toda la aplicacion
            //Beneficio: rendimiento en memoria
            //Desventaja: no se puede abusar del patron

            Conexion.Conexion c = Conexion.Conexion.getInstacia();
            c.ConectarBD();
            c.DesconectarBD();

            bool ruta = (c.GetType() == typeof(Conexion.Conexion));
            Console.WriteLine(ruta);
            Console.ReadLine();
        }
    }
}
