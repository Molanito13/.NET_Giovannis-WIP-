using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Giovannis.Modelos.BBDD
{
    public class Connector
    {
        protected SqlConnection conexion;
        protected SqlCommand comando;
        protected SqlDataReader registros;
        private String cadenaConexion;

        public Connector()
        {
            // Connection string
            cadenaConexion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =  |DataDirectory|data\giovannis.mdf; Integrated Security = True; Connect Timeout = 30";;
            conexion = new SqlConnection(cadenaConexion);

        }

        public Boolean abrir()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (SqlException e)
            {
            
                return false;
            }
        }

        public Boolean cerrar()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (SqlException e)
            {
                return false;
            }
        }
    }
}
