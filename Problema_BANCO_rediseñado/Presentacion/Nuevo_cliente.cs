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

    
    public partial class Nuevo_cliente : Form
    {
        DBhelper c1 = new DBhelper();
        Form1 formulario_principal = new Form1();

        public Nuevo_cliente()
        {
            InitializeComponent();
        }

        private void Nuevo_cliente_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            formulario_principal.Show();
        }

        private void btn_crearCliente_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                Cliente NC = new Cliente();
                NC.Nombre = txt_nombreNUEVOCLIENTE.Text;
                NC.Apellido = txt_apellidoNUEVOCLIENTE.Text;
                NC.DNI = Convert.ToInt32(dni_NUEVOCLIENTE.Text);

                try
                {
                    if (c1.GuardarCliente(NC.Nombre,NC.Apellido,NC.DNI) > 0)
                    {
                        MessageBox.Show("Usuario guardado");
                    }
                    this.Close();
                    formulario_principal.Show();


                }
                catch (Exception)
                {

                    MessageBox.Show("Error al guardar usuario. Intente de nuevo");
                    return;
                }


            }
        }
        private bool validarDNI()
        {
            bool estado = true;
            string DNI = dni_NUEVOCLIENTE.Text;

            foreach(char c in DNI)
            {
                if (!char.IsDigit(c))
                {
                    estado = false;
                }

            }
            return estado;


        }
        private bool validarDatos()
        {
            bool estado;

            if (txt_nombreNUEVOCLIENTE.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR UN NOMBRE VALIDO");
                estado = false;
               
            }
            else if (txt_apellidoNUEVOCLIENTE.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR UN APELLIDO VALIDO");
                estado = false;


            }
           else  if (dni_NUEVOCLIENTE.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR UN DOCUMENTO VALIDO");
                estado = false;
                
            }

            else if (!validarDNI())
            {
                MessageBox.Show("DEBE INGRESAR SOLO NUMEROS EN EL DOCUMENTO");
                estado = false;
            }
            else
            {
                estado = true;

            }
            return estado;
            
        }
    }
}
