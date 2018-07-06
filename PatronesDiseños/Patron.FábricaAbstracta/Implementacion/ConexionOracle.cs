
using Patron.Fabrica.Model;
using Patron.FábricaAbstracta.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.FábricaAbstracta.Implementacion
{
    public class ConexionOracle : ConexionParametros, IConexionBD
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
