using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Problema_BANCO_rediseñado.AccesoDatos
{
    class DBhelper
    {
        private SqlConnection connection;

        public DBhelper()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-9LO9F2L;Initial Catalog=banco;Integrated Security=True");

        }
        public int GuardarCliente(string nombre,string apellido,int dni)
        {
            int estado = 0;
            connection.Open();
            SqlCommand cAC = new SqlCommand("INSERTAR_NUEVO_CLIENTE", connection);
            cAC.CommandType = CommandType.StoredProcedure;
            cAC.Parameters.AddWithValue("@nombre", nombre);
            cAC.Parameters.AddWithValue("@apellido", apellido);
            cAC.Parameters.AddWithValue("@DNI", dni);

            estado = cAC.ExecuteNonQuery();
            connection.Close();
          





            return estado;
        }
        public int CrearCuenta(int dni,DateTime ultimo_movimiento,int id_tipo_cuenta,int saldo)
        {
            int estado = 0;
           
            connection.Open();
            SqlCommand cAC2 = new SqlCommand("INSERTAR_NUEVA_CUENTA", connection);
            cAC2.CommandType = CommandType.StoredProcedure;
            cAC2.Parameters.AddWithValue("@ultimo_movimiento",ultimo_movimiento );
            cAC2.Parameters.AddWithValue("@id_tipo_cuenta", id_tipo_cuenta);
            cAC2.Parameters.AddWithValue("@dni_cliente", dni);
            cAC2.Parameters.AddWithValue("@saldo", saldo);

            estado = cAC2.ExecuteNonQuery();
            connection.Close();


            return estado;
        }
        public DataTable CargarUsuarios()
        {
            DataTable tabla = new DataTable();
            connection.Open();
            SqlCommand cSP1 = new SqlCommand("cargar_lista_usuario", connection);
            cSP1.CommandType = CommandType.StoredProcedure;
            tabla.Load(cSP1.ExecuteReader());
            connection.Close();



            return tabla;


        }
        public DataTable cargarCuentasClientes(int DNI_CLIENTE)
        {
            DataTable tabla = new DataTable();
            connection.Open();
            SqlCommand cSP3 = new SqlCommand("cargar_cuentas_cliente", connection);
            cSP3.CommandType = CommandType.StoredProcedure;
            cSP3.Parameters.AddWithValue("@DNIcliente", DNI_CLIENTE);
            tabla.Load(cSP3.ExecuteReader());
            connection.Close();

            return tabla;
        }
        public DataTable obtenerNombeApellidoDni(int DNI)
        {
            DataTable tabla = new DataTable();
            connection.Open();
            SqlCommand cSP4 = new SqlCommand("OBTENER_NOMBREAPELLIDO_DNI", connection);
            cSP4.CommandType = CommandType.StoredProcedure;
            cSP4.Parameters.AddWithValue("@DNIcliente",DNI);
            tabla.Load(cSP4.ExecuteReader());
            connection.Close();

            return tabla;
        }
        public DataTable cargarTiposCuenta()
        {
            DataTable tabla = new DataTable();
            connection.Open();
            SqlCommand cSP2 = new SqlCommand("cargar_tipos_cuenta", connection);
            cSP2.CommandType = CommandType.StoredProcedure;
            tabla.Load(cSP2.ExecuteReader());
            connection.Close();
            return tabla;

        }
        public int borrarCuenta(int cbu)
        {
            int estado = 0;
            connection.Open();
            SqlCommand spQUITARCUENTA = new SqlCommand("QUITAR_CUENTA_CLIENTE", connection);
            spQUITARCUENTA.CommandType = CommandType.StoredProcedure;
            spQUITARCUENTA.Parameters.AddWithValue("@CBUcuenta", cbu);
            estado = spQUITARCUENTA.ExecuteNonQuery();
            connection.Close();
            return estado;

        }
       

    }
}
