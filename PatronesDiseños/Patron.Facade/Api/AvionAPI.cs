using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.Facade.Api
{
    public class AvionAPI
    {
        public void buscarVuelos(string fechaIda, string fechaVuelta, string origen, string destino)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("Vuelos encontrador para " + destino + " desde " + origen);
            Console.WriteLine("Fecha IDA: " + fechaIda + " Fecha Vuelta: " + fechaVuelta);
            Console.WriteLine("=======================================");
        }
    }
}
