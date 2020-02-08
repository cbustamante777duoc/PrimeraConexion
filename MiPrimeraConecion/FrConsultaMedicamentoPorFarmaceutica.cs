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
    public partial class FrConsultaMedicamentoPorFarmaceutica : Form
    {
        public FrConsultaMedicamentoPorFarmaceutica()
        {
            InitializeComponent();
        }

        private void FrConsultaMedicamentoPorFarmaceutica_Load(object sender, EventArgs e)
        {
            SQL.FiltrarDatosComboBox("ProllenarComboFarmacia", cbxFarmaceutica);
            SQL.ListarProcedimientoAlmacenado("PROLISTAMEDICAMENTOS", dgvMedicamento);
            /*
            // cadena de conexion
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);

            // nombre del procedimiento + cadena de conexion
            SqlCommand cmd = new SqlCommand("ProllenarComboFarmacia",cn);
            // indicar que es un procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure;
            // sql data adapter es le pasa el procedimiento
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable Table = new DataTable();
            //llenado de la tabla
            sda.Fill(Table);
            //llendo del combo box
            cbxFarmaceutica.DataSource = Table;
            // lo que se muestra en pantalla desde la bd
            cbxFarmaceutica.DisplayMember = "NOMBRE";
            // lo que se rescata desde bd
            cbxFarmaceutica.ValueMember = "IIDFORMAFARMACEUTICA";
            */
        }

        private void FILTRAR(object sender, EventArgs e)
        {
            /*
             * nota para mi 
             * puedo hacer eso por que el cbo es de una tabla 
             * y el compartamiento es 
             * selected changed comit
             */

            //capturamos el string que eligio el usurios
            string idforma = cbxFarmaceutica.SelectedValue.ToString();
            SQL.FiltraDatosPorProcedimiento("PROLISTAMEDICAMENTOSPORID ", "@IIDFORMAFARMACEUTICA",idforma,dgvMedicamento);
        }
    }
}
