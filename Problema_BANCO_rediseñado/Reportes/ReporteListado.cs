using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema_BANCO_rediseñado.Reportes
{
    public partial class ReporteListado : Form
    {
        public ReporteListado()
        {
            InitializeComponent();
        }

        private void ReporteListado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
