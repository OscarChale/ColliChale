namespace Interfaz
{
    using System;

    namespace Interfaces
    {
        class MainClass
        {
            public static void Main(string[] args)
            {
                
                Ave canario = new Ave("Canario");
                Ave cuervo = new Ave("Cuervo");
                
                MainClass main = new MainClass();
                main.imprimir(canario);
                main.imprimir(cuervo);
                Console.ReadKey();
            }
            
            public void imprimir(Ave ave)
            {
                
                Console.WriteLine("Soy un {0} tengo {1} Pata(s), {2} Ala(s) y {3} Cola(s)", ave.Nombre, ave.Patas, ave.Alas, ave.Cola);
                
                Console.WriteLine("Puedo ");
                ave.Comer();
                Console.WriteLine("y tambien puedo ");
                ave.Volar();
            }
        }
        public class Ave : AvePropiedades
        {
            public Ave(string Nombre) : base(Nombre)
            {
            }
        }
        public class AvePropiedades : IAve
        {
            public int Patas = 2;
            public int Alas = 2;
            public int Cola = 1;
            public string Nombre { get; private set; }
            public AvePropiedades(string NAve)
            {
                this.Nombre = NAve;
            }
            public void Volar()
            {
                Console.WriteLine("Volar");
            }
            public void Comer()
            {
                Console.WriteLine("Comer");
            }
        }
        public interface IAve
        {
            void Volar();
            void Comer();
        }
    }
}
