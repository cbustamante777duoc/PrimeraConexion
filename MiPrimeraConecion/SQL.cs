using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace MiPrimeraConecion
{
   public class SQL
    {
        private static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);

        //pasamos la consulta y el grid por parametro
        public static void ListarConsulta(string consulta, DataGridView grilla)
        {
            //le pasamos la consulta por parametro
            SqlCommand sqlm = new SqlCommand( consulta, cn);
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

        public static void FiltraDatosPorProcedimiento(string nombreDelProcedimiento,string nombreDelParametro, string valorDelParametro, DataGridView grilla)
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

        // en el procedimiento almacenado el nombre y el id estan como as entonce ahora los paso por defecto 
        public static void FiltrarDatosComboBox(string nombreDelProcedimiento, ComboBox comboBox, string displayMember="Nombre", string valueMember="Id")
        {
            // el sql conecion esta arriba
           

            SqlCommand cmd = new SqlCommand(nombreDelProcedimiento, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable Table = new DataTable();
            sda.Fill(Table);
            //llendo del combo box
            comboBox.DataSource = Table;
            // lo que se muestra en pantalla desde la bd (nombre)
            comboBox.DisplayMember = displayMember;
            // lo que se rescata desde bd (el Id)
            comboBox.ValueMember = valueMember;
        }
    }
}
