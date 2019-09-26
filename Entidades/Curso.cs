using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        string tema;
        DateTime turno;
        decimal cuota;
        List<Alumno> alumnos;
        Docente docente;
        public Curso()
        {
            alumnos = new List<Alumno>();
            docente = new Docente();
        }
        public string Tema
        {
            get => tema;
            set => tema = value;
        }
        public DateTime Turno
        {
            get => turno;
            set => turno = value;
        }
        public decimal Cuota
        {
            get => cuota;
            set => cuota = value;
        }
        public Docente Docente
        {
            get => docente;
            set => docente = value;
        }
        public void CargarAlumno(Alumno alumno)
        {

        }
    }
}
