using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Giovannis.Modelos.Excepciones;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Giovannis.Modelos.BBDD
{
    public class Consultas : Connector
    {
        public List<List<string>> selectAll(string tabla)
        {
            List<List<string>> pedidos = new List<List<string>>();

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT * FROM {tabla}";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        List<string> fila = new List<string>();
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            fila.Add(registros.GetValue(i).ToString());
                        }
                        pedidos.Add(fila);

                    }
                    registros.Close();
                    this.cerrar();
                    return pedidos;
                }
                catch (SqlException e)
                {
                    conexion.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }
        public int devuelvoTipo(string nUsuario, string passwd)
        {

            int tipo = -1;

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT empleado_tipo FROM Empleados WHERE empleado_dni LIKE '{nUsuario}' AND empleado_password LIKE '{passwd}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        List<string> fila = new List<string>();
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                           tipo = int.Parse(registros.GetValue(i).ToString());
                        }
                       

                    }
                    registros.Close();
                    this.cerrar();
                    return tipo;
                }
                catch (SqlException e)
                {
                    conexion.Close();
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }
        public int existeEmpleado(string nUsuario)
        {

            int marca = -1;

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT COUNT(*) FROM Empleados WHERE empleado_dni LIKE '{nUsuario}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {
                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            marca = int.Parse(registros.GetValue(i).ToString());
                        }


                    }
                    registros.Close();
                    this.cerrar();
                    return marca;
                }
                catch (SqlException e)
                {
                    conexion.Close();
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }
        public int devuelvoPassword(string nUsuario, string passwd)
        {

            int marcador = -1;

            if (this.abrir())
            {
                try
                {
                    string query = $"SELECT COUNT(*) FROM Empleados WHERE empleado_dni LIKE '{nUsuario}' AND empleado_password LIKE '{passwd}'";

                    this.comando = new SqlCommand(query, this.conexion);
                    this.registros = comando.ExecuteReader();

                    while (registros.Read())
                    {

                        for (int i = 0; i < registros.FieldCount; i++)
                        {
                            marcador = int.Parse(registros.GetValue(i).ToString());
                        }


                    }


                    registros.Close();
                    this.cerrar();
                    return marcador;
                }
                catch (SqlException e)
                {
                    conexion.Close();
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la BBDD");
                throw new ConnectionException("No se pudo realizar la conexión");
            }
        }
    }
}
