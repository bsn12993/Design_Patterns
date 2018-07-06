using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.Prototype.Interfaz
{
    public interface ICuenta : ICloneable
    {
        ICuenta clonar();
    }
}
