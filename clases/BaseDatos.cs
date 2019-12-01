using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
class BaseDatos
{
    public static MySqlConnection conexion;
    static string CadenaConectarse = "Server=localhost;Database=Prueba;user=root;password=1234567;";
    MySqlConnection conectarse = new MySqlConnection(CadenaConectarse);
    public void Conectar(Log newLog)
    {
        try
        {
            conectarse.Open();
            newLog.Add("Conectado en la base de datos");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            newLog.Add("Error no se pudo conectar a la base de datos");
        }
    }
    public void Desconectar(Log newLog)
    {
        try
        {
            if (conectarse.State == System.Data.ConnectionState.Open)
            {
                conectarse.Close();
                newLog.Add("Desconectando de la base de datos");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            newLog.Add("Error no se pudo desconectar de la base de datos");
        }
    }
    public void RegistarDato(Log newLog,InformacionAutobus Informacion)
    {
        {
            try
            {
                conectarse.Open();
                string query = "INSERT INTO InformacionBus(RutaDisponible,TiempoEspera,TiempoAhora) VALUES(?Ruta,?Estancia,?Ahora)";
                using (MySqlCommand cmd = new MySqlCommand(query, conectarse))
                {
                    cmd.Parameters.Add("?Ruta", MySqlDbType.VarChar).Value = Informacion.RutaDisponible;
                    cmd.Parameters.Add("?Estancia", MySqlDbType.VarChar).Value = Informacion.TiempoEstancia;
                    cmd.Parameters.Add("?Ahora", MySqlDbType.VarChar).Value = Informacion.TiempoAhora;
                    cmd.ExecuteNonQuery();
                    newLog.Add("Agregado exitosamente a la base de datos");
                }
                conectarse.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                newLog.Add("Error no se pudo agregar en la base de datos");
            }
        }
    }

    public void ConsultarDato(Log newLog, InformacionAutobus Informacion)
    {
        {
            string query = "SELECT * FROM InformacionBus";
            MySqlCommand commandDatabase = new MySqlCommand(query, conectarse);
            MySqlDataReader reader;
            try
            {
                conectarse.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro nada");
                    newLog.Add("No se encontro ningun dato en la base de datos");
                }

                conectarse.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                newLog.Add("Error no se pudo consultar la base de datos");
            }
        }
    }
}
