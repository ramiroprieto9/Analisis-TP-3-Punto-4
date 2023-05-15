using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisis_TP_3_Punto_4
{
    public class Libro
    {
        public Libro(long codigo, string titulo, string autor, string editorial, bool prestado)
        {
            this._codigo = codigo;
            this._titulo = titulo;
            this._autor = autor;
            this._editorial = editorial;
            this._prestado = prestado;
        }

        public long _codigo { get; set; }
        public string _titulo { get; set; }
        public string _autor { get; set; }
        public string _editorial { get; set; }
        public bool _prestado {get; set; }

        public void LibroPrestado(Libro libro)
        {
            if (libro._prestado == true)
            {
                MessageBox.Show("El libro ya fue prestado");
            }
        }

        public void LibroDevuelto (Libro libro)
        {
            libro._prestado = false;

        }

        
    }
}
