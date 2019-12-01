using System;
namespace Builder
{
    class InformacionAutobus
    {

        static void Main(string[] args)
        {
            var InformacionBus = new Informacion();
            InformacionBus.Registro(new AgregarRegistro("68 HEROES"));
            InformacionBus.Contructor("10 MINUTOS",DateTime.Now);
            var Guardar = InformacionBus.AutobusListo;
            InformacionBus.Mostrar(Guardar);

            InformacionBus.Registro(new EditarRegistro("68 BONAMPACK"));
            InformacionBus.Contructor("20 MINUTOS", DateTime.Now);
            var Edicion = InformacionBus.AutobusListo;
            InformacionBus.Mostrar(Edicion);

            Console.ReadKey();
        }
    }

    // Producto final
    public class Autobus
    {
        public string RutaDisponible { get; set; }
        public string TiempoEstancia { get; set; }
        public DateTime TiempoAhora { get; set; }

        public Autobus()
        {

        }

        public Autobus(string Ruta, string Espera, DateTime Ahora) : this()
        {
            RutaDisponible = Ruta;
            TiempoEstancia = Espera;
            TiempoAhora = Ahora;
        }
    }

    // Builder
    public abstract class AutobusBuilder
    {
        // Protected para que las clases que implementen puedan acceder
        protected Autobus _Autobus;
        public string RutaDisponible { get; set; }
        public string TiempoEstancia { get; set; }
        public DateTime TiempoAhora { get; set; }

        public Autobus Obtener() { return _Autobus; }
        public virtual void PasoTiempoEstancia(string Espera) { }
        public virtual void PasoTiempoAhora(DateTime Ahora) { }
    }

    // BuilderConcreto
    public class AgregarRegistro : AutobusBuilder
    {
        public AgregarRegistro(string Ruta)
        {
            _Autobus = new Autobus
            {
                RutaDisponible = Ruta
            };
        }
        public override void PasoTiempoEstancia(string Espera)
        {
            _Autobus.TiempoEstancia = Espera;
        }

        public override void PasoTiempoAhora(DateTime Ahora)
        {
            _Autobus.TiempoAhora = Ahora;
        }
    }

    // Otro BuilderConcreto
    public class EditarRegistro : AutobusBuilder
    {
        public EditarRegistro(string Ruta)
        {
            _Autobus = new Autobus
            {
                RutaDisponible = Ruta
            };
        }
        public override void PasoTiempoEstancia(string Espera)
        {
            _Autobus.TiempoEstancia = Espera;
        }

        public override void PasoTiempoAhora(DateTime Ahora)
        {
            _Autobus.TiempoAhora = Ahora;
        }
    }

    public class EliminarRegistro : AutobusBuilder
    {
        public EliminarRegistro(string Ruta)
        {
            _Autobus.RutaDisponible = "";
        }
        public override void PasoTiempoEstancia(string Espera)
        {
            _Autobus.TiempoEstancia = "";
        }

        public override void PasoTiempoAhora(DateTime Ahora)
        {
            _Autobus.TiempoAhora = Ahora;
        }
    }

    // Director
    class Informacion
    {
        private AutobusBuilder _autobusBuilder;

        public void Registro(AutobusBuilder autobusBuilder)
        {
            _autobusBuilder = autobusBuilder;
        }

        public void Contructor(string Espera, DateTime Ahora)
        {
            _autobusBuilder.PasoTiempoEstancia(Espera);
            _autobusBuilder.PasoTiempoAhora(Ahora);
        }

        public Autobus AutobusListo
        {
            get { return _autobusBuilder.Obtener(); }

        }
        public void Mostrar(Autobus autobus)
        {

            Console.WriteLine("\n---------------------------");
            Console.Write("{1}\nRUTA-{0} con tiempo de espera de {2}\n", autobus.RutaDisponible, autobus.TiempoAhora, autobus.TiempoEstancia);

        }
    }
}