using Patron.FábricaAbstracta.Interfaz;
using Patron.Fabrica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.FábricaAbstracta.Implementacion
{
    public class ConexionSQLServer : ConexionParametros, IConexionBD
    {
        public ConexionSQLServer()
        {
            this.host = "";
            this.puerto = "";
            this.usuario = "";
            this.contrasenia = "";
        }

        public void conectar()
        {
            Console.WriteLine("Se conectó a SQL Server");
        }

        public void desconectar()
        {
            Console.WriteLine("Se desconectó a SQL Server");
        }
    }
}
