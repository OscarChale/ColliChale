using System;
namespace Registro
{
    class Usuario
    {
        private String Nombre;
        private int Matricula;
        public void Registro(String Nombre, int Matricula)
        {
            Console.Write("El estudiante {0} con matricula {1} ingreso correctamente\n", Nombre, Matricula);
            this.Nombre = Nombre;
            this.Matricula = Matricula;
        }
        public void Salir()
        {
            Console.Write("El estudiante {0} con matricula {1} salio correctamente\n", this.Nombre, this.Matricula);
        }

        static void Main(string[] args)
        {
            String Nombre;
            int Matricula;
            Console.Write("Ingrese Su Nombre\n"); Nombre = Console.ReadLine();
            Console.Write("Ingrese Su Matricula\n"); Matricula = int.Parse(Console.ReadLine());
            Usuario NuevoUsuario = new Usuario();
            NuevoUsuario.Registro(Nombre, Matricula);
            NuevoUsuario.Salir();
            Console.ReadKey();
        }
    }
}