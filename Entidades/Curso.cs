using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Curso
    {
        string tema;
        DateTime turno;
        decimal cuota;
        decimal inscripcion;
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
            //set => cuota = value;
        }
        public decimal Inscripcion
        {
            get => inscripcion;
            set => inscripcion = value;
        }
        public Docente Docente
        {
            get => docente;
            set => docente = value;
        }
        public void CargarAlumno(Alumno alumno)
        {
            this.alumnos.Add(alumno);
        }
        public virtual void CalcularCuota()
        {

        }
    }
    public class Presencial : Curso
    {
        public Presencial() : base()
        {

        }
        public override void CalcularCuota()
        {

        }
    }
    public class SemiPresencial : Curso
    {
        public SemiPresencial() : base()
        {

        }
        public override void CalcularCuota()
        {

        }
    }
    public class NoPresencial : Curso
    {
        public NoPresencial() : base()
        {

        }
        public override void CalcularCuota()
        {

        }
    }

}
