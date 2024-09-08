using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Solicitante
    {
          int id;
          string solicitante;
          string Area;
          string destinatario;
          string Equipo;
          DateTime Fecha;
          string Detalle;

        public int Id { get => id; set => id = value; }
        public string Solicitante1 { get => solicitante; set => solicitante = value; }
        public string Area1 { get => Area; set => Area = value; }
        public string Destinatario { get => destinatario; set => destinatario = value; }
        public string Equipo1 { get => Equipo; set => Equipo = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public string Detalle1 { get => Detalle; set => Detalle = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones Operaciones = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("CALL INSERTAR(");
            Sentencia.Append("'" + Solicitante1 + "',");
            Sentencia.Append("'" + Area1 + "',");
            Sentencia.Append("'" + Destinatario + "',");
            Sentencia.Append("'" + Equipo + "',");
            Sentencia.Append("'" + Fecha.ToString("yyyy-MM-dd") + "',");
            Sentencia.Append("'" + Detalle1 + "');");


            try
            {
                if (Operaciones.EjecutarSentencia(Sentencia.ToString()) >= 0)
                {
                    Resultado = true;
                }
                else
                {
                    Resultado = false;
                }
            }
            catch (Exception ex)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            DataLayer.DBOperaciones operaciones = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();
            Sentencia.Append("CALL ACTUALIZAR(");
            Sentencia.Append("'" + id + "', ");
            Sentencia.Append("'" + Solicitante1 + "', ");
            Sentencia.Append("'" + Area1 + "', ");
            Sentencia.Append("'" + Destinatario + "', ");
            Sentencia.Append("'" + Equipo + "', ");
            Sentencia.Append("'" + Fecha.ToString("yyyy-MM-dd") + "', ");
            Sentencia.Append("'" + Detalle1 + "');");


            try
            {
                if (operaciones.EjecutarSentencia(Sentencia.ToString()) >= 0)
                {
                    Resultado = true;
                }
                else
                {
                    Resultado = false;
                }
            }
            catch (Exception ex)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            //crando el obejto
            DataLayer.DBOperaciones Operacion = new DataLayer.DBOperaciones();
            //permiten construir cadenas los stringBuilder
            StringBuilder Setencia = new StringBuilder();

            Setencia.Append("CALL ELIMINAR(" + id + ");");
            try
            {
                if (Operacion.EjecutarSentencia(Setencia.ToString()) >= 0)
                {
                    Resultado = true;
                }
                else
                {
                    Resultado = false;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public DataTable Buscar(string nombre)
        {
            DataTable Resultado = new DataTable();
            DataLayer.DBOperaciones Operaciones = new DataLayer.DBOperaciones();
            StringBuilder Sentencia = new StringBuilder();

            // Construir la sentencia SQL para llamar al procedimiento almacenado
            Sentencia.Append("CALL BuscarSolicitantes('");
            Sentencia.Append(nombre);
            Sentencia.Append("');");

            try
            {
                // Ejecutar la consulta y obtener los resultados en un DataTable
                Resultado = Operaciones.Consultar(Sentencia.ToString());
            }
            catch (Exception ex)
            {
                Resultado = new DataTable(); // Devuelve un DataTable vacío en caso de error
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }

            return Resultado;
        }
    }

   
}
