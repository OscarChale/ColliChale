using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARIBEBUS
{
    class InformacionAutobus
    {
        public String RutaDisponible;
        public String TiempoEstancia;
        public DateTime TiempoAhora;
        public void AgregarRegistros(String Ruta, String Tiempo)
        {
            DateTime Ahora = DateTime.Now;
            this.TiempoAhora = Ahora;
            this.RutaDisponible = Ruta;
            this.TiempoEstancia = Tiempo;
            BaseDatos conexion = new BaseDatos();
            conexion.Conectar();
            string query = "INSERT INTO informacionbus(ruta,estancia,ahora) VALUES(?Ruta,?Estancia,?Ahora)";
            using (MySqlCommand cmd = new MySqlCommand(query, conexion.conectarse))
            {
                cmd.Parameters.Add("?Ruta", MySqlDbType.VarChar).Value = this.RutaDisponible;
                cmd.Parameters.Add("?Estancia", MySqlDbType.VarChar).Value = this.TiempoEstancia;
                cmd.Parameters.Add("?Ahora", MySqlDbType.VarChar).Value = this.TiempoAhora;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos Agregados correctamente");
            }
            conexion.conectarse.Close();
        }
        public void EliminarResgistros(String Ruta, String Tiempo)
        {
            this.RutaDisponible = Ruta;
            this.TiempoEstancia = Tiempo;
            BaseDatos con = new BaseDatos();
            con.Conectar();
            using (MySqlCommand cmd = new MySqlCommand(String.Format("DELETE FROM informacionbus WHERE ruta='{0}' AND estancia='{1}'", this.RutaDisponible, this.TiempoEstancia), con.conectarse))
            {
                cmd.Parameters.AddWithValue("?rutas", MySqlDbType.VarChar).Value = this.RutaDisponible;
                cmd.Parameters.AddWithValue("?estancias", MySqlDbType.VarChar).Value = this.TiempoEstancia;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos eliminados corrextamente");
            }
            con.conectarse.Close();
        }
    }
}