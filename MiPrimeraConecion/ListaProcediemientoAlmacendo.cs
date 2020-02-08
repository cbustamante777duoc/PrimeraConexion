using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraConecion
{
    public partial class ListaProcediemientoAlmacendo : Form
    {
        public ListaProcediemientoAlmacendo()
        {
            InitializeComponent();
        }

        private void ListaProcediemientoAlmacendo_Load(object sender, EventArgs e)
        {
            ClaseUtilitaria.ListarProcedimientoAlmacenado("listaPacientes",dgvListaProcedimiento);
        }
    }
}
