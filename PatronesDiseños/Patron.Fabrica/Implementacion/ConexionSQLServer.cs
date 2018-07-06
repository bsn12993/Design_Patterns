using Patron.Fabrica.Interfaz;
using Patron.Fabrica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.Fabrica.Implementacion
{
    public class ConexionSQLServer : ConexionParametros, IConexion
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
