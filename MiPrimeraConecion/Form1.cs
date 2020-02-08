using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MiPrimeraConecion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Listar();
            
        }

        private void dgvclinica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscarClinica = txtBuscar.Text;
            /*
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            SqlCommand cmd = new SqlCommand("ListarClinicaPorId ", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            //inidicar que tiene un parametro el procedimiento almacenado y lo igualamos al texto
            cmd.Parameters.AddWithValue("@IdClinica",buscarClinica);
            DataTable tabla = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(tabla);
            dgvclinica.DataSource = tabla;
            */

            SQL.FiltraDatosPorProcedimiento("ListarClinicaPorId ", "@IdClinica",buscarClinica, dgvclinica);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            Listar();

        }

        //metodo que va a regresar la lista 
        private void Listar()
        {
            SQL.ListarConsulta("select IIDCLINICA, NOMBRE, DIRECCION from CLINICA where BHABILITADO = 1", dgvclinica);
        }
    }
}
