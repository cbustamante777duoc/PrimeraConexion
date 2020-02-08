using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraConecion
{
    public partial class lstProcedimientoAlmacenadoPorfiltro : Form
    {
        public lstProcedimientoAlmacenadoPorfiltro()
        {
            InitializeComponent();
            listarComienzo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtFiltro.Text;
            //ClaseUtilitaria.ListarProcedimientoAlmacenadoPorfiltro("listaPorIdPaciente", "@id",id,dgvListaProcedimiento);
            //   SQL.FiltraDatosPorProcedimiento("listaPorIdPaciente", "@id",id,dgvListaProcedimiento);
            /*   SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
               SqlCommand cmd = new SqlCommand("listaPorIdPaciente",cn);
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@id",id);
               DataTable tabla = new DataTable();
               SqlDataAdapter sdata = new SqlDataAdapter(cmd);
               sdata.Fill(tabla);
               dgvListaProcedimiento.DataSource = tabla;
               */
              ClaseUtilitaria.FiltraDatosPorProcedimiento("listaPorIdPaciente", "@id",id,dgvListaProcedimiento);
  

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listarComienzo();
            txtFiltro.Text = "";
        }

        private void listarComienzo()
        {
            ClaseUtilitaria.ListarConsulta("select * from Paciente",dgvListaProcedimiento);
        }
    }
}
