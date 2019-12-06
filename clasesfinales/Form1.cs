using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CARIBEBUS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseDatos conexion = new BaseDatos();
            Usuario nuevo = new Usuario();
            nuevo.Nombre = textBox1.Text;
            nuevo.Matricula = Convert.ToInt32(textBox2.Text);
            conexion.Conectar();
            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = conexion.conectarse;
            codigo.CommandText = ("select * from usuarios where nombre='" + nuevo.Nombre + "'and matricula='" + nuevo.Matricula + "'");
            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                nuevo.Registro();
                Form2 bus = new Form2();
                bus.Show();
                this.Close();
            }
            else {
                MessageBox.Show("Error nombre o matricula incorrectos");
            }
        }
    }
}
