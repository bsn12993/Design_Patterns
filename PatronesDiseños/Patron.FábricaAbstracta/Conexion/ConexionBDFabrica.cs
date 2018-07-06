using Patron.FábricaAbstracta.Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.FábricaAbstracta.Conexion
{
    public class ConexionBDFabrica : FábricaAbstracta.Interfaz.FabricaAbstracta
    {
        public Interfaz.IConexionBD getBD(string bd)
        {
            if (bd == null) return new ConexionVacia();
            if (bd.Equals("MYSQL")) return new ConexionMySQL();
            else if (bd.Equals("ORACLE")) return new ConexionOracle();
            else if (bd.Equals("POSTGRESSQL")) return new ConexionPostgreSQL();
            else if (bd.Equals("SQL")) return new ConexionSQLServer();
            return new ConexionVacia();
        }

        public Interfaz.IConexionREST getREST(string area)
        {
            return null;
        }
    }
}
