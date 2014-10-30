using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMultimedia
{
    public class Cancion : Multimedia
    {
        public Double Duracion { get; set; }
        public String Formato { get; set; }

        public Cancion()
        {

        }

        public Cancion(String titulo, String autor, Double codigo, Double duracion, String formato)
            : base(titulo, autor, codigo)
        {
            Duracion = duracion;
            Formato = formato;

        }

        public override void PrintDetalle(String separador=" ")
        {
            String[] datos = { Titulo, Autor, Codigo.ToString(), Duracion.ToString(), Formato };
            var texto = String.Join(separador, datos);
            Console.WriteLine(texto);
        }

       
    }
}
