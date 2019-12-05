using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    public abstract class Producto
    {
        protected double precioVenta;
        protected double costoFabrica;
        protected string nombreProducto;

        public Producto(string nombre, double precio, double costo)
        {
            nombreProducto = nombre;
            costoFabrica = costo;
            precioVenta = precio;
        }

        public abstract string imprimirDatos();
    }

    public class Libro : Producto
    {
        public Libro(string titulo, double precio, double costo)
            :base(titulo, precio,costo)
        { 

        }

        public override string imprimirDatos()
        {
            return "Libro: " + nombreProducto + ", Precio: " + precioVenta;
        }
    }

    public class DVD : Producto
    {
        public DVD(string titulo, double precio, double costo)
            : base(titulo, precio, costo)
        { 

        }
        public override string imprimirDatos()
        {
            return "DVD: " + nombreProducto + " Precio: " + precioVenta;
        }

    }



    class Programu
    {
        static void Main(string[] args)
        {

            Libro miLibro = new Libro("Biblioteca del programador", 54.95, 39.95);
            DVD miDVD = new DVD("Curso multimedia de Java", 29.95, 19.95);

            Console.WriteLine("Los datos de mis productos.");
            Console.WriteLine(miLibro.imprimirDatos());
            Console.WriteLine(miDVD.imprimirDatos());


            Console.WriteLine("presione <enter> para terminar.");
            Console.ReadLine();
        }
    }
}
