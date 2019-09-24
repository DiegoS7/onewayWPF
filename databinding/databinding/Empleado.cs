using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databinding
{
    class Empleado
    {
        public string Nombre { get; set; }
        public string Titulo { get; set; }

        public static Empleado GetEmpleado()
        {
            var emp = new Empleado()
            {
                Nombre = "Diego Sandoval", Titulo = "Todologo"
            };
            return emp;
        }
    
    } 
}
