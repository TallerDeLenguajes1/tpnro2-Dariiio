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

        public Persona(string nombre, string apellido, string dni, DateTime fechaNacimiento)
        {
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
            this.dni = dni ?? throw new ArgumentNullException(nameof(dni));
            this.fechaNacimiento = fechaNacimiento;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }
        public string Dni
        {
            get => dni;
            set => dni = value;
        }
        public int Id
        {
            get => id;
            set => id = value;
        }
        public DateTime FechaNacimiento
        {
            get => fechaNacimiento;
            set => fechaNacimiento = value;
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

    public class Alumno : Persona
    {
        public Alumno() : base()
        {

        }

        public Alumno(string nombre, string apellido, string dni, DateTime fechaNacimiento) : base(nombre, apellido, dni, fechaNacimiento)
        {
        }
    }

    public class Docente : Persona
    {
        string cargo;
        decimal sueldo;
        DateTime fechaAlta;
        public Docente() : base()
        {

        }
        public string Cargo
        {
            get => cargo;
            set => cargo = value;
        }
        public decimal Sueldo
        {
            get => sueldo;
            set => sueldo = value;
        }
        public DateTime FechaAlta
        {
            get => fechaAlta;
            set => fechaAlta = value;
        }
        public int Antiguedad()
        {
            return 0;
        }
        public override string ToString()
        {
            return Nombre + " " + Apellido + " " + Dni + " " + cargo + " ";
        }
    }


}
