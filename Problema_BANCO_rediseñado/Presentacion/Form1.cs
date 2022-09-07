using Problema_BANCO_rediseñado.AccesoDatos;
using Problema_BANCO_rediseñado.Dominio;
using Problema_BANCO_rediseñado.Presentacion;
using Problema_BANCO_rediseñado.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema_BANCO_rediseñado
{
    public partial class Form1 : Form
    {
        Crear_cuenta crear_Cuenta = new Crear_cuenta();
        List<Cliente> lclientes = new List<Cliente>();
        DBhelper c1 = new DBhelper();
        public Form1()
        {
            InitializeComponent();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nuevo_cliente nuevo_Cliente_form = new Nuevo_cliente();
            nuevo_Cliente_form.ShowDialog();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("DESEA SALIR?", "SALIENDO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void cargarCuentasGuardadas()
        {
            DataTable tabla = c1.CargarUsuarios();

            for(int i = 0; i < tabla.Rows.Count; i++)
            {
                Cliente NC = new Cliente();
                NC.Nombre = tabla.Rows[i][0].ToString();
                NC.Apellido = tabla.Rows[i][1].ToString();
                NC.DNI = Convert.ToInt32(tabla.Rows[i][2]);
                lclientes.Add(NC);
                

            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCuentasGuardadas();
        }

        private void BTN_iniciar_sesion_Click(object sender, EventArgs e)
        {
            
            if(ExisteCliente() == true)
            {
                Info_cliente form_info_cliente = new Info_cliente();
                form_info_cliente.cargarCuentasDeClienteNRO(Convert.ToInt32(txt_documento_inicioSesion.Text));
                
                form_info_cliente.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("el usuario no existe");
            }
        }
        private bool ExisteCliente()
        {
            bool estado = false;

            int documentoAvalidar = Convert.ToInt32(txt_documento_inicioSesion.Text);
            for(int i = 0;i < lclientes.Count; i++)
            {
                if(lclientes[i].DNI == documentoAvalidar)
                {
                     estado = true;
                }
               
                

            }
            return estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteListado reporteListado = new ReporteListado();
            reporteListado.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            REPORTE_PERSONALIZADO rEPORTE_PERSONALIZADO = new REPORTE_PERSONALIZADO();
            rEPORTE_PERSONALIZADO.ShowDialog();
        }
    }
}
