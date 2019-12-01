using System;
    class InformacionAutobus
    {
        public String RutaDisponible;
        public String TiempoEstancia;
        public DateTime TiempoAhora;
        public void AgregarRegistros(String RutaDisponible, String TiempoEstancia)
        {
            DateTime Ahora = DateTime.Now;
            Console.Write("{1}\nRUTA-{0} con tiempo de espera de {2}\n", RutaDisponible, Ahora, TiempoEstancia);
            this.RutaDisponible = RutaDisponible;
            this.TiempoEstancia = TiempoEstancia;
        }
        public void EliminarResgistros(String RutaDisponible, String TiempoEstancia)
        {
            DateTime Ahora = DateTime.Now;
            Console.Write("{1}\nRUTA-{0} Eliminado\n", this.RutaDisponible, Ahora);
            this.RutaDisponible = "";
            this.TiempoEstancia = "";
        }
        public void EditarRegistros(String RutaDisponible, String TiempoEstancia)
        {
            DateTime Ahora = DateTime.Now;
            Console.Write("{1}\nRUTA-{0} con tiempo de espera de {2}\n", RutaDisponible, Ahora, TiempoEstancia);
            this.RutaDisponible = RutaDisponible;
            this.TiempoEstancia = TiempoEstancia;
        }

        static void Main(string[] args)
        {
            String RutaDisponible;
            String TiempoEstancia;
            Console.Write("Ingrese su Ruta Disponible\n"); RutaDisponible = Console.ReadLine();
            Console.Write("Ingrese el Tiempo de espera\n"); TiempoEstancia = Console.ReadLine();
            InformacionAutobus NuevoUsuario = new InformacionAutobus();
            NuevoUsuario.AgregarRegistros(RutaDisponible, TiempoEstancia);
            NuevoUsuario.EliminarResgistros(RutaDisponible, TiempoEstancia);
            Console.Write("Ingrese Dato a editar\n"); RutaDisponible = Console.ReadLine();
            Console.Write("Ingrese el Tiempo de espera\n"); TiempoEstancia = Console.ReadLine();
            NuevoUsuario.EditarRegistros(RutaDisponible, TiempoEstancia);
            Console.ReadKey();
        }
    }