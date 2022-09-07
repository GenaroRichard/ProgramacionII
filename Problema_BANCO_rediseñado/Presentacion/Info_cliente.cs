using Problema_BANCO_rediseñado.AccesoDatos;
using Problema_BANCO_rediseñado.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema_BANCO_rediseñado.Presentacion
{
    public partial class Info_cliente : Form
    {
        Crear_cuenta crear_Cuenta_form = new Crear_cuenta();
        Cuenta cuenta = new Cuenta();

        Form1 formulario_inicial = new Form1();
        DBhelper c1 = new DBhelper();
        int documento;
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Info_cliente()
        {
            InitializeComponent();
            documento = 0;
            
        }

        private void Info_cliente_Load(object sender, EventArgs e)
        {
            
            txt_nombreCliente.Enabled = false;
            txt_apellidocliente.Enabled = false;
            txt_dniCliente.Enabled = false;
            cargarNombreApellidoDni(this.documento);

        }
        public void cargarCuentasDeClienteNRO(int documento)
        {
            this.documento = documento;
            crear_Cuenta_form.Documento = documento;




            DataTable tabla = c1.cargarCuentasClientes(this.documento);
            
            for(int i = 0; i< tabla.Rows.Count; i++)
            {
                string CBU = (tabla.Rows[i][0].ToString());
                string tipoCuenta = tabla.Rows[i][1].ToString();
                string UltimoMovimiento = tabla.Rows[i][2].ToString();
                string saldo = tabla.Rows[i][3].ToString();
                int estado = Convert.ToInt32(tabla.Rows[i][4]);

                

               if(estado == 1)
                    dataGridView1.Rows.Add(CBU, tipoCuenta, UltimoMovimiento, saldo);
               else
                    dataGridView2.Rows.Add(CBU, tipoCuenta, saldo);
                dataGridView1.InvalidateColumn(4);
            }
            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea salir?","SALIENDO",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                formulario_inicial.Show();

            }
        }
        public void cargarNombreApellidoDni(int documento)
        {
            DataTable tabla = c1.obtenerNombeApellidoDni(this.documento);
            txt_nombreCliente.Text = tabla.Rows[0][0].ToString();
            txt_apellidocliente.Text = tabla.Rows[0][1].ToString();
            txt_dniCliente.Text = tabla.Rows[0][2].ToString();
            lbl_cartelBienvenida.Text = "Información de cuentas de " + txt_nombreCliente.Text + " " + txt_apellidocliente.Text;

        }

        private void BTN_NuevaCuenta_Click(object sender, EventArgs e)
        {
            
            crear_Cuenta_form.ShowDialog();
            this.Close();
           
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentCell.ColumnIndex == 4)
            {
                var filaSeleccionada = dataGridView1.CurrentRow;

                int cbu = Convert.ToInt32(filaSeleccionada.Cells["cbuCLM"].Value);

                

                if(MessageBox.Show("Desea deshabilitar la cuenta?","ELIMINANDO CUENTA",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)== DialogResult.Yes)
                {
                    try
                    {
                        if (cuenta.deshabilitarCuenta(cbu) > 0)
                        {
                            MessageBox.Show("Cuenta deshabilitada");

                        }

                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error al deshabilitar la cuenta");
                    }

                }
                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();
                
                this.cargarCuentasDeClienteNRO(documento);

               
               



            }else if(dataGridView1.CurrentCell.ColumnIndex == 5)
            {
                var filaSeleccionada = dataGridView1.CurrentRow;
                int saldo = Convert.ToInt32(filaSeleccionada.Cells["saldoCLM"].Value);
                int cbu_cuenta = Convert.ToInt32(filaSeleccionada.Cells["cbuCLM"].Value);

                Retiro_dinero retiro_Dinero = new Retiro_dinero(documento, saldo,cbu_cuenta);
                retiro_Dinero.ShowDialog();
                this.Close();
                


            }

            
        }
        public bool confirmar()
        {

            bool resultado = true;









            return resultado;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView2.CurrentCell.ColumnIndex == 3)
            {
                var filaSelecionada = dataGridView2.CurrentRow;

                int cbu = Convert.ToInt32(filaSelecionada.Cells["CBUclm2"].Value);

                if(MessageBox.Show("DESEA HABILIAR LA CUENTA?","HABILITANDO CUENTA",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)== DialogResult.Yes)
                {
                    


                    try
                    {
                        if (cuenta.habilitarCuenta(cbu) > 0)
                        {
                            MessageBox.Show("Cuenta habilitada");

                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("CUENTA NO HABILITADA. ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    dataGridView1.Rows.Clear();
                    dataGridView2.Rows.Clear();

                    this.cargarCuentasDeClienteNRO(documento);

                }

            }
        }
    }
}
