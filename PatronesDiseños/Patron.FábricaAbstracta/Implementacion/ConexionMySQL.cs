

using Patron.Fabrica.Model;
using Patron.FábricaAbstracta.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.FábricaAbstracta.Implementacion
{
    public class ConexionMySQL : ConexionParametros, IConexionBD
    {
        public ConexionMySQL()
        {
            this.host = "";
            this.puerto = "";
            this.usuario = "";
            this.contrasenia = "";
        }

        public void conectar()
        {
            Console.WriteLine("Se conectó a MySQL");
        }

        public void desconectar()
        {
            Console.WriteLine("Se desconectó a MySQL");
        }
    }
}
