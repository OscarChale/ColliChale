using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace CARIBEBUS
{
    class BaseDatos
    {
        static string CadenaConectarse = "Server=localhost;Database=bus;user=root;password=123456789;";
        public MySqlConnection conectarse = new MySqlConnection(CadenaConectarse);
        InformacionAutobus Informacion = new InformacionAutobus();
        public void Conectar()
        {
            try
            {
                conectarse.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos" + ex);
            }
        }
        public void Desconectar()
        {
            try
            {
                if (conectarse.State == System.Data.ConnectionState.Open)
                {
                    conectarse.Close();
                    MessageBox.Show("Desconectando de la base de datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no se pudo desconectar de la base de datos"+ex);
            }
        }
        public void RegistarDato(string Ruta, string Tiempo)
        {
            {
                try
                {
                    Informacion.AgregarRegistros(Ruta, Tiempo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error no se pudo agregar los datos" + ex);
                }
            }
        }
        public void EliminarDato(string Ruta, string Tiempo)
        {
            {
                try
                {
                    Informacion.EliminarResgistros(Ruta, Tiempo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error no se pudo agregar los datos" + ex);
                }
            }
        }
        public void Consultar(DataGridView Datos)
        {
            {
                try
                {
                    string sql = "select ruta,estancia,ahora from informacionbus";
                    MySqlCommand cmd = new MySqlCommand(sql, conectarse);
                    MySqlDataAdapter mydb = new MySqlDataAdapter(cmd);
                    DataSet Mostar = new DataSet();
                    mydb.Fill(Mostar);
                    Datos.DataSource = Mostar.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error consultar datos" + ex);
                }
            }
        }
    }
}