using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EjemploBBDD
{
    class conexionBBDD
    {
        public MySqlConnection conecta()
        {
            /*
             * se necesitan 5 parametros para conectar
             * 1ºserver: ip o nombre del servidor
             * 2ºDatabase: nombre de la base
             * Uid: user id not null
             * Pwd: contraseña
             * Port:puerto por defecto es el  3306
             */

            MySqlConnection conexion = new MySqlConnection("" +
                "Server=127.0.0.1;" +
                "Database=videoclub;" +
                "Uid=root1234;" +
                "Pwd=;" +
                "Port=3306");
            conexion.Open();
            return conexion;
        }
    }
    
}
