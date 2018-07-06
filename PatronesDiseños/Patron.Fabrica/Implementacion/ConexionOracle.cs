using Patron.Fabrica.Interfaz;
using Patron.Fabrica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.Fabrica.Implementacion
{
    public class ConexionOracle : ConexionParametros, IConexion
    {
        public ConexionOracle()
        {
            this.host = "";
            this.puerto = "";
            this.usuario = "";
            this.contrasenia = "";
        }

        public void conectar()
        {
            Console.WriteLine("Se conectó a Oracle");
        }

        public void desconectar()
        {
            Console.WriteLine("Se desconectó a Oracle");
        }
    }
}
