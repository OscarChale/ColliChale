using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARIBEBUS
{
    class Usuario
    {
        public String Nombre;
        public int Matricula;
        public void Registro()
        {
            MessageBox.Show("El estudiante " + this.Nombre + " con matricula " + this.Matricula + " Ingreso Correctamente");
        }
        public void Salir()
        {
            MessageBox.Show("El estudiante "+ this.Nombre + " con matricula "+ this.Matricula+ " salio correctamente");
        }
    }
}
