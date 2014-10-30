using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMultimedia
{
    class Program
    {
        static void Main(string[] args)
        {
        
            var cl = crearLibro();
            var cc = CrearCancion();
            Dictionary<String,Libro> tablaLibros=new Dictionary<string, Libro>();     
            Dictionary<String, Cancion> tablaCanciones=new Dictionary<string, Cancion>(); 
        

            private static Libro crearLibro()
            {

            Console.WriteLine(tablaLibros.Count);
            
            Console.Write("Titulo");
            var t = Console.ReadLine();
            
            Console.Write("Autor");
            var a = Console.ReadLine();

            double c = 0;

            Console.Write("Código:");
            double.TryParse(Console.ReadLine(), out c);

            double p = 0;

            Console.Write("Páginas:");
            double.TryParse(Console.ReadLine(), out p);

            Console.Write("Idioma");
            var i = Console.ReadLine();

            tablaLibros.Add(t, new Libro() { Titulo = t, Autor = a, Codigo = c, Paginas = p, Idioma = i});
             

           
        }
    }

        private static Cancion CrearCancion()
        {
            Console.Write("Titulo");
            var tt = Console.ReadLine();
            
            Console.Write("Autor");
            var aa = Console.ReadLine();

            double cc = 0;

            Console.Write("Código:");
            double.TryParse(Console.ReadLine(), out cc);

            double dd = 0;

            Console.Write("Duracion:");
            double.TryParse(Console.ReadLine(), out dd);

            Console.Write("Formato");
            var f = Console.ReadLine();

             tablaCanciones.Add(tt, new Cancion() { Titulo = tt, Autor = aa, Codigo = cc, Duracion = dd, Formato = f});
        }
    }}
