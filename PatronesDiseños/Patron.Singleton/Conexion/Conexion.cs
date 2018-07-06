using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron.Singleton.Conexion
{
    public class Conexion
    {
        /// <summary>
        /// Declaración
        /// </summary>
        public static Conexion instancia;
        /// <summary>
        /// Para evitar instancia mediante operador "new"
        /// </summary>
        private Conexion()
        {

        }

        /// <summary>
        /// Para obtener la instancia unicamente por este metodo 
        /// La palabra reservada "static" hace posible el acceso mediante Clase.metodo
        /// </summary>
        /// <returns></returns>
        public static Conexion getInstacia()
        {
            if (instancia == null)
                instancia = new Conexion();
            return instancia;
        }

        public string ConectarBD()
        {
            return "Me conecte a la BD";
        }

        public string DesconectarBD()
        {
            return "Me desconecte de la BD";
        }
    }
}
