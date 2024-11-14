using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_t3
{
   
    
        public class Cita1
        {
            public int Numero { get; set; }
            public Estudiante1 Estudiante { get; set; }
            public string Enfermedad { get; set; }
            public double Precio { get; set; }

            public Cita1 (int numero, Estudiante1 estudiante, string enfermedad, double precio)
            {
                Numero = numero;
                Estudiante = estudiante;
                Enfermedad = enfermedad;
                Precio = precio;
            }
        }
    
}
