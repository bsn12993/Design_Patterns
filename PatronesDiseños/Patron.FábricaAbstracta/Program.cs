using Patron.FábricaAbstracta.Conexion;
using Patron.FábricaAbstracta.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.FábricaAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fabrica de Fabricas
            FabricaAbstracta fabricaBD = FabricaProductor.getProductor("BD");
            IConexionBD cnBD1 = fabricaBD.getBD("MYSQL");

            cnBD1.conectar();

            FabricaAbstracta fabricaREST = FabricaProductor.getProductor("REST");
            IConexionREST cnRS1 = fabricaREST.getREST("COMPRAS");

            cnRS1.LeerURL("https://www.youtube.com/watch?v=QmE-o5R7ZF4&index=4&list=PLvimn1Ins-41Uiugt1WbpyFo1XT1WOquL");

            Console.ReadLine();
        }
    }
}
