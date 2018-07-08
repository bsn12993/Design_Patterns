using Patron.Facade.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.Facade.Facade
{
    public class CheckFacade
    {
        private AvionAPI avionAPI;
        private HotelAPI hotelAPI;

        public CheckFacade()
        {
            this.avionAPI = new AvionAPI();
            this.hotelAPI = new HotelAPI();
        } 

        public void buscar(string fechaIda,string fechaVuelta,string origen,string destino)
        {
            avionAPI.buscarVuelos(fechaIda, fechaVuelta, origen, destino);
            hotelAPI.buscarHoteles(fechaIda, fechaVuelta, origen, destino);
        }
    }
}
