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

namespace Problema_BANCO_rediseñado.Reportes
{
    public partial class REPORTE_PERSONALIZADO : Form
    {
        public REPORTE_PERSONALIZADO()
        {
            InitializeComponent();
        }

        private void REPORTE_PERSONALIZADO_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=banco;Integrated Security=True");

            SqlCommand comando = new SqlCommand("reporte_personalizado", connection);
            connection.Open();
            comando.CommandType = CommandType.StoredProcedure;

            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            connection.Close();
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", tabla));

            reportViewer1.RefreshReport(); 


        }
    }
}
