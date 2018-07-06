using Patron.Prototype.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.Prototype.Model
{
    public class CuentaAHImpl : ICuenta
    {
        private string tipo { get; set; }
        private double monto { get; set; }

        public CuentaAHImpl()
        {
            tipo = "AHORRO";
        }

        public ICuenta clonar()
        {
            CuentaAHImpl cuenta = null;
            try
            {
                cuenta = (CuentaAHImpl)clonar();
            }
            catch (NotImplementedException e)
            {
                 
            }
            return cuenta;
        }


    }
}
