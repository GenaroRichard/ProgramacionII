using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_BANCO_rediseñado.Dominio
{
    class Cliente
    {
        private int dni;
        public string Nombre { get; set; }
       
        public string Apellido { get; set; }

        public int DNI
        {
            set { dni = value; }
            get { return dni; }
        }

        public List<Cuenta> Cuentas;

        public Cliente()
        {
            Cuentas = new List<Cuenta>();
            dni = 0;

        }
        public void agregarCuenta(Cuenta NC)
        {
            Cuentas.Add(NC);

        }
        public override string ToString()
        {
            return "Nombre: " + Nombre + " , DNI: " + DNI;
        }
        
    }
}
