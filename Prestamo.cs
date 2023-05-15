using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisis_TP_3_Punto_4
{
    public class Prestamo
    {
        public Prestamo(Lector lector, Libro libro, DateTime fecha_prestamo)
        {
            this._lector = lector;
            this._libro = libro;
            this._fecha_prestamo = fecha_prestamo;
        }

        public Lector _lector { get; set; }
        public Libro _libro { get; set; }
        public DateTime _fecha_prestamo { get; set; }
        public DateTime _fecha_devolucion { get; set; }

        public void VerificarFechaDevolucion(Prestamo prestamo, Lector lector)
        {
            if (prestamo._fecha_devolucion > prestamo._fecha_prestamo.AddDays(15))
            {
                lector._moroso = true;
                MessageBox.Show("Devolución con retraso");
            }
            else
            {
                MessageBox.Show("Devolución en tiempo y forma");
            }
        }

        //public DateTime GetFechaDevolucion(int dia, int mes, int año) 
        //{
        //    DateTime fecha = new DateTime(dia, mes, año);
        //    return fecha;
        //}

    }
    
}
