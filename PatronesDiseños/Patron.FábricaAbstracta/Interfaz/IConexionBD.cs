﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.FábricaAbstracta.Interfaz
{
    public interface IConexionBD
    {
        void conectar();
        void desconectar();
    }
}
