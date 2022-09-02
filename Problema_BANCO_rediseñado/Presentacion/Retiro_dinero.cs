using Problema_BANCO_rediseñado.Presentacion;
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

namespace Problema_BANCO_rediseñado
{
    public partial class Retiro_dinero : Form
    {
        int documento;
        int saldo_cuenta;
        int cbu_cuenta;
        public Retiro_dinero()
        {
            InitializeComponent();

        }
        public Retiro_dinero(int documento,int saldo_cuenta,int cbu_cuenta)
        {
            InitializeComponent();
            this.documento = documento;
            this.saldo_cuenta = saldo_cuenta;
            this.cbu_cuenta = cbu_cuenta;
        }

        private void Retiro_dinero_Load(object sender, EventArgs e)
        {
            lbl_cuentainfo.Text = "Cuenta del cliente de DNI: " + documento;
            lbl_saldo.Text = "Saldo de la cuenta: " + saldo_cuenta;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea salir?","SALIENDO",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                
                Info_cliente form_info_cliente = new Info_cliente();
                form_info_cliente.cargarCuentasDeClienteNRO(documento);

                form_info_cliente.Show();
                this.Hide();
            }
        }

        private void btn_retirar_Click(object sender, EventArgs e)
        {
            if (validarSaldo())
            {
               
                if(Confirmar() == true)
                {
                    MessageBox.Show("retiro exitoso");
                    lbl_saldo.Text = "Saldo de la cuenta: " + (saldo_cuenta - Convert.ToInt32(txtSaldo.Text));
                }

            }

        }
        private bool validarSaldo()
        {
            bool estado = true;
           

            if(( saldo_cuenta - Convert.ToInt32(txtSaldo.Text)) < 0)
            {
                estado = false;
                MessageBox.Show("Cantidad de dinero insuficiente");

            }
          
            return estado;

        }
        private bool Confirmar()
        {
            bool resultado = true;
            SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=banco;Integrated Security=True");
            SqlTransaction t = null;



            try
            {
                connection.Open();
                t = connection.BeginTransaction();
                SqlCommand cmd = new SqlCommand("RETIRO_DINERO_CUENTA", connection,t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cbu_cuenta", cbu_cuenta);
                cmd.Parameters.AddWithValue("@Saldo", (saldo_cuenta - Convert.ToInt32(txtSaldo.Text) ));
                cmd.ExecuteNonQuery();
                t.Commit();



            }
            catch (Exception)
            {

                t.Rollback();
                resultado = false;
                MessageBox.Show("Retiro no realizado. ERROR","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return resultado;
            
        }
    }
}
