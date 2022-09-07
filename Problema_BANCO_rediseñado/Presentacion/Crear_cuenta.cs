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
    public partial class Crear_cuenta : Form
    {
        Cliente Cliente = new Cliente();
        
        DBhelper c1 = new DBhelper();
        public int Documento { get; set; }
       
        public Crear_cuenta()
        {
            InitializeComponent();
            
        }

        private void Crear_cuenta_Load(object sender, EventArgs e)
        {
            CargarTiposCuenta();
            CB_tiposCuenta.SelectedIndex = -1;
           
            
            lblDocumetoCliente.Text = "DOCUMENTO DEL CLIENTE: " + Documento;
            
        }

        private void CargarTiposCuenta()
        {
            DataTable tabla = c1.cargarTiposCuenta();
            CB_tiposCuenta.DataSource = tabla;
            CB_tiposCuenta.DisplayMember = tabla.Columns[1].ColumnName;
            CB_tiposCuenta.ValueMember = tabla.Columns[0].ColumnName;
            CB_tiposCuenta.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("DESEA SALIR?","SALIENDO",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)== DialogResult.Yes)
            {

                Info_cliente form_info_cliente = new Info_cliente();
                form_info_cliente.cargarCuentasDeClienteNRO(Documento);

                form_info_cliente.Show();
                this.Hide();




            }
        }

        private void BTNGuardarCuenta_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                int dni = Documento;
                DateTime ultimo_movimiento = dateTimePicker1.Value;
                int id_tipo_cuenta =  Convert.ToInt32( CB_tiposCuenta.SelectedValue);
                int saldo = Convert.ToInt32(txtSaldo.Text);
                int estado = 1;

                Cuenta NC = new Cuenta(saldo, id_tipo_cuenta, ultimo_movimiento, dni);
                Cliente.agregarCuenta(NC);



                try
                {
                    if (c1.CrearCuenta(dni, ultimo_movimiento, id_tipo_cuenta, saldo,estado) > 0)
                    {
                        MessageBox.Show("Cuenta creada");
                    }
                   
                    

                }
                catch (Exception)
                {

                    MessageBox.Show("Cuenta no creada. ERROR");
                    return; 
                }
               
                







            }
            
        }
        private bool validarDatos()
        {
            bool estado = true;
            
            if(CB_tiposCuenta.SelectedIndex == -1)
            {
                MessageBox.Show("DEBE SELECCIONAR UN TIPO DE CUENTA");
                estado = false;

            }
            else if (txtSaldo.Text == "")
            {
                MessageBox.Show("Debe Ingresar un saldo");
                estado = false;

            }
            else if (!validarDNI())
            {
                MessageBox.Show("DEBE INGRESAR SOLO NUMEROS EN EL DOCUMENTO");
                estado = false;
            }
            return estado;

        }
        private bool validarDNI()
        {
            bool estado = true;
            string DNI = txtSaldo.Text;

            foreach (char c in DNI)
            {
                if (!char.IsDigit(c))
                {
                    estado = false;
                }

            }
            return estado;


        }
    }
}
