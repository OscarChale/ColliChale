using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARIBEBUS
{
    public partial class Form2 : Form
    {
        BaseDatos Datos = new BaseDatos();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos.RegistarDato(textBox1.Text,textBox2.Text);
            Application.DoEvents();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Datos.Consultar(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Datos.Desconectar();
            MessageBox.Show("Desconectando.....");
            Form1 bus = new Form1();
            bus.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Datos.EliminarDato(textBox1.Text,textBox2.Text);
        }
    }
}
