﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.Fabrica.Interfaz
{
    public interface IConexion
    {
        void conectar();
        void desconectar();
    }
}
