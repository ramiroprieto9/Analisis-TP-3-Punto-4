using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analisis_TP_3_Punto_4
{
    public class Lector
    {
        public long _numero { get; set; }
        public string _nombre { get; set; }
        public string _apellidos { get; set; }
        public bool _moroso = false;

        public Lector(long numero, string nombre, string apellidos)
        {
            this._numero = numero;
            this._nombre = nombre;
            this._apellidos = apellidos;
        }
    }
}
