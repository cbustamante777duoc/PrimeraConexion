using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MiPrimeraConecion
{
    public partial class lstPorConsultaSql : Form
    {
        public lstPorConsultaSql()
        {
            InitializeComponent();
        }

        private void lstPorSexo_Load(object sender, EventArgs e)
        {

            /*

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            SqlCommand cmd = new SqlCommand("LISTARXSEXO", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sdata = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            sdata.Fill(tabla);
            dgvListaPorSexo.DataSource = tabla;
            */

            //ClaseUtilitaria.ListarConsulta("select NOMBRE,APPATERNO,EMAIL from Doctor where IIDSEXO = 1",dgvListaPorSexo);
            //probando el metodo listar consulta
            ClaseUtilitaria.ListarConsulta("select * from Medicamento",dgvListaPorSexo);

        }
    }
}
