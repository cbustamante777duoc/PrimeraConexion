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
    public partial class ListadoPorEspecialidad : Form
    {
        public ListadoPorEspecialidad()
        {
            InitializeComponent();
        }

        private void ListadoPorEspecialidad_Load(object sender, EventArgs e)
        {
         
            SQL.ListarProcedimientoAlmacenado("ListarEspecialidadPorHabilitado",dgvListadoEspecialidades);
   
        }

        private void Filtra(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text;
            SQL.FiltraDatosPorProcedimiento("listarEspecialidadPorNombre", "@nombreEspecialidad", nombre, dgvListadoEspecialidades);
        }
    }
}
