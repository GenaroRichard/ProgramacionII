using Problema_BANCO_rediseñado.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_BANCO_rediseñado.Dominio
{
    class Cuenta

    {
        DBhelper c1 = new DBhelper();
        Cliente cliente = new Cliente();

        public int CBU { get; set; }
        
        public double Saldo { get; set; }

        public int TipoCuenta { get; set; }

        public DateTime UltimoMovimiento { get; set; }

        public Cliente Cliente
        {
            set { cliente = value; }
            get { return cliente; }
        }
        public Cuenta()
        {


        }



        //-------------------------------------------------------------------------
        public Cuenta( double saldo, int tipoCuenta, DateTime ultimoMovimiento, int DNI_CLIENTE)
        {
            
            Saldo = saldo;
            TipoCuenta = tipoCuenta;
            UltimoMovimiento = ultimoMovimiento;
            cliente.DNI = DNI_CLIENTE;
        }
        public int deshabilitarCuenta(int cbu)
        {
            int estado = 0;
            
            estado = c1.deshabilitarCuenta(cbu);
            return estado;


        }
        public int habilitarCuenta(int cbu)
        {
            int estado = 0;
            estado = c1.habilitarCuenta(cbu);
            return estado;

        }


        public override string ToString()
        {
            return "CBU: " + CBU;

        }

    }
}
