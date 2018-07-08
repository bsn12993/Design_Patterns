using Patron.Facade.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simplificar la logia para el cliente 
            CheckFacade cliente1 = new CheckFacade();
            cliente1.buscar("02/07/2018", "08/07/2018", "Lima", "Cancún");

            CheckFacade cliente2 = new CheckFacade();
            cliente1.buscar("02/07/2018", "08/07/2018", "Lima", "Mexico");

            Console.ReadLine();

        }
    }
}
