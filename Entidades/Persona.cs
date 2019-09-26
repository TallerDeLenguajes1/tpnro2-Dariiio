using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        string nombre, apellido, dni;
        int id;
        DateTime fechaNacimiento;
        public Persona()
        {

        }
        public int Edad()
        {
            return 0;
        }
        public override string ToString()
        {
            return nombre + " " + apellido + " " + dni;
        }
    }
}
