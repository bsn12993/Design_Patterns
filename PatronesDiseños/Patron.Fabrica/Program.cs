using Patron.Fabrica.Conexion;
using Patron.Fabrica.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.Fabrica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Flexibilidad de no depender de una instancia
            ConexionFabrica fabrica = new ConexionFabrica();
            IConexion cn1 = fabrica.getConexion("MYSQL");
            cn1.conectar();
            cn1.desconectar();

            IConexion cn2 = fabrica.getConexion("SQL");
            cn2.conectar();
            cn2.desconectar();

            IConexion cn3 = fabrica.getConexion("H2");
            cn3.conectar();
            cn3.desconectar();

            Console.ReadLine();
        }
    }
}
