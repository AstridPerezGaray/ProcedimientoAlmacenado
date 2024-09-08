using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace DataLayer
{
    public class DBOperaciones : DBConexion
    {
        public DataTable Consultar(String pConsulta)
        {
            DataTable Resultado = new DataTable();
            MySqlDataAdapter Adaptador = new MySqlDataAdapter();
            MySqlCommand Comando = new MySqlCommand();

            try
            {
                if (base.Conectar())
                {
                    Comando.Connection = base._CONEXION;
                    Comando.CommandType = System.Data.CommandType.Text;
                    Comando.CommandText = pConsulta;
                    Adaptador.SelectCommand = Comando;
                    Adaptador.Fill(Resultado);
                    base.Desconectar();
                }
            }
            catch (Exception ex)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
        public Int32 EjecutarSentencia(String pSetencia)
        {
            Int32 FilasAfectadas = 0;
            MySqlCommand Comando = new MySqlCommand();

            try
            {
                if (base.Conectar())
                {
                    Comando.Connection = base._CONEXION;
                    Comando.CommandType = System.Data.CommandType.Text;
                    Comando.CommandText = pSetencia;
                    FilasAfectadas = Comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                FilasAfectadas = -1;
            }
            return FilasAfectadas;
        }
        public object EjecutarEscalar(string pConsulta)
        {
            object resultado = null;
            MySqlCommand comando = new MySqlCommand();

            try
            {
                if (base.Conectar())
                {
                    comando.Connection = base._CONEXION;
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = pConsulta;
                    resultado = comando.ExecuteScalar();
                    base.Desconectar();
                }
            }
            catch (Exception)
            {
                resultado = null; // Maneja el error según sea necesario
            }

            return resultado;
        }

    }
}

