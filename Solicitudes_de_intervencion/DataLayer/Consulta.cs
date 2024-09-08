using Mysqlx.Crud;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Consulta
    {
        public static DataTable Solicitudes()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"call MostrarSolicitantes; ";
            DBOperaciones operacion = new DBOperaciones();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }catch (Exception ex)
            {

            }
            return Resultado;
        }
    }
}
