using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ACCESO
    {
        SqlConnection conexion;

        public void Abrir()
        {
            conexion = new SqlConnection(@"Integrated Security=SSPI; Persist Security Info=False; Initial Catalog=Instituto;Data Source=NombreBD");
        }

        public void Cerrar()
        {
            conexion.Close();
            conexion = null;
            GC.Collect();
        }

        public SqlCommand CrearComando(string sql, List<SqlParameter> parametros = null)
        {
            SqlCommand cmd = new SqlCommand(sql, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            if (parametros != null)
            {
                cmd.Parameters.Add(parametros);
            }

            return cmd;
        }

        public int Escribir(string sql, List<SqlParameter> parametros = null)
        {
            SqlCommand cmd = CrearComando(sql, parametros);
            int filas = 0;
            try
            {
                filas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                filas = -1;
            }
            return filas;
        }

        public DataTable Leer(string sql, List<SqlParameter> parametros = null)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = CrearComando(sql, parametros);
            DataTable t = new DataTable();

            adaptador.Fill(t);
            adaptador = null;
            return t;
        }

        public SqlParameter CrearParametro(string nombre, string valor)
        {
            SqlParameter param = new SqlParameter(nombre, valor);
            param.DbType = DbType.String; return param;
        }
        public SqlParameter CrearParametro(string nombre, int valor)
        {
            SqlParameter param = new SqlParameter(nombre, valor);
            param.DbType = DbType.Int32; return param;
        }
        public SqlParameter CrearParametro(string nombre, float valor)
        {
            SqlParameter param = new SqlParameter(nombre, valor);
            param.DbType = DbType.Single; return param;
        }


    }

}

