using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaMultimedia
{
    public abstract class Multimedia 
    {
        public String Titulo { get; set; }

        public String Autor { get; set; }

        public Double Codigo { get; set; }

        public Multimedia()
        {
            
        }

        public Multimedia(String titulo, String autor, Double codigo)
        {
            Titulo = titulo;
            Autor = autor;
            Codigo = codigo;
        }

        public abstract void PrintDetalle(String separador=" ");

        


    }
}
