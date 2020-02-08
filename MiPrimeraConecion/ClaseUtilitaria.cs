using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace MiPrimeraConecion
{
  public  class ClaseUtilitaria
    {
        private static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);

        //metodo que recibe un string de consulta
        public static void ListarConsulta(string consulta, DataGridView grilla)
        {
            //le pasamos la consulta por parametro
            SqlCommand sqlm = new SqlCommand(consulta, cn);
            //pasando la conexion
            SqlDataAdapter sda = new SqlDataAdapter(sqlm);
            //creando una tabla vacia
            DataTable table = new DataTable();
            //llenando la tabla
            sda.Fill(table);
            //igualando la tabla con el grid
            grilla.DataSource = table;
        }

        public static void ListarProcedimientoAlmacenado(string nombreDelProcedimiento, DataGridView grilla)
        {
            SqlCommand sqlm = new SqlCommand(nombreDelProcedimiento, cn);
            //decir al programa que es un procedimineto almacenado
            sqlm.CommandType = CommandType.StoredProcedure;
            //pasando la conexion
            SqlDataAdapter sda = new SqlDataAdapter(sqlm);
            //creando una tabla vacia
            DataTable table = new DataTable();
            //llenando la tabla
            sda.Fill(table);
            //igualando la tabla con el grid
            grilla.DataSource = table;

        }
        /*
        public static void ListarProcedimientoAlmacenadoPorfiltro(string nombreProcedimiento,string valorParametro ,string parametro,DataGridView grilla)
        {
           
            SqlCommand cmd = new SqlCommand(nombreProcedimiento, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(parametro, valorParametro);
            DataTable tabla = new DataTable();
            SqlDataAdapter sdata = new SqlDataAdapter(cmd);
            sdata.Fill(tabla);
            grilla.DataSource = tabla;
            
            
        }
        */

        public static void FiltraDatosPorProcedimiento(string nombreDelProcedimiento, string nombreDelParametro, string valorDelParametro, DataGridView grilla)
        {

            SqlCommand cmd = new SqlCommand(nombreDelProcedimiento, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            //inidicar que tiene un parametro el procedimiento almacenado y lo igualamos al valor del parametro
            cmd.Parameters.AddWithValue(nombreDelParametro, valorDelParametro);
            DataTable tabla = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(tabla);
            grilla.DataSource = tabla;
        }



    }
}
