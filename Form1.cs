using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisis_TP_3_Punto_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Libro libro1 = new Libro(452504, "El camino", "Miguel Delibes", "Los Bagre", true);
            Libro libro2 = new Libro(484021, "Cien años de soledad", "Gabriel Garcia Marquez", "Muchachooo", true);
            Libro libro3 = new Libro(871009, "Rayuela", "Julio Cortazar", "Ñoñi LEIVA", true);
            Lector lector1 = new Lector(3644359736, "Ana", "Garcia");
            Lector lector2 = new Lector(3644627101, "Roberto", "Sanchez");
            DateTime fechaprestamo1 = new DateTime(2022, 10, 22);
            Prestamo prestamo1 = new Prestamo(lector1, libro1, fechaprestamo1);
            DateTime fechaprestamo2 = new DateTime(2022, 10, 17);
            Prestamo prestamo2 = new Prestamo(lector1, libro2, fechaprestamo2);
            DateTime fechaprestamo3 = new DateTime(2022, 06, 05);
            Prestamo prestamo3 = new Prestamo(lector2, libro3, fechaprestamo3);
            DateTime fechadevolucion1 = new DateTime(2022, 10, 30);
            prestamo1._fecha_devolucion = fechadevolucion1;
            libro1.LibroDevuelto(libro1);
            DateTime fechadevolucion2 = new DateTime(2022, 11, 04);
            prestamo2._fecha_devolucion = fechadevolucion2;
            libro2.LibroDevuelto(libro2);
            DateTime fechadevolucion3 = new DateTime(2022, 12, 30);
            prestamo3._fecha_devolucion = fechadevolucion3;
            libro3.LibroDevuelto(libro3);
            prestamo1.VerificarFechaDevolucion(prestamo1, lector1);
            prestamo2.VerificarFechaDevolucion(prestamo2, lector1);
            prestamo2.VerificarFechaDevolucion(prestamo3, lector2);
        }
    }
}
