using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMultimedia
{
    public class Libro:Multimedia
    {
        public Double Paginas { get; set; }
        public String Idioma { get; set; }
        
        public Libro()
        {
            
        }

        public Libro(String titulo, String autor, Double codigo, Double paginas, String idioma):base(titulo,autor,codigo)
        {
            Paginas = paginas;
            Idioma = idioma;
        }

        public override void PrintDetalle(String separador = " ")
        {
            String[] datos = { Titulo, Autor, Codigo.ToString(), Paginas.ToString(), Idioma };
            var texto = String.Join(separador, datos);
            Console.WriteLine(texto);
        }

       
    }
}
