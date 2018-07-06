using Patron.Fabrica.Implementacion;
using Patron.Fabrica.Interfaz;
using Patron.Fabrica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.Fabrica.Conexion
{
    public class ConexionFabrica
    {
        public IConexion getConexion(string bd)
        {
            if (bd == null)
                return new ConexionVacia();
            if (bd.Equals("MYSQL")) return new ConexionMySQL();
            else if (bd.Equals("ORACLE")) return new ConexionOracle();
            else if (bd.Equals("POSTGRESSQL")) return new ConexionPostgreSQL();
            else if (bd.Equals("SQL")) return new ConexionSQLServer();
            return new ConexionVacia();
        }
    }
}
