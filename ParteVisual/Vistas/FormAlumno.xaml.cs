using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ParteVisual.Vistas
{
    /// <summary>
    /// Lógica de interacción para FormAlumno.xaml
    /// </summary>
    public partial class FormAlumno : Window
    {
        Alumno alumno;
        public FormAlumno()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool alumnoValido = true;
            if (TbxNombre.Text == "" || TbxNombre == null)
                alumnoValido = false;

            if (TbxApellido.Text == "" || TbxApellido == null)
                alumnoValido = false;

            if (TbxDni.Text == "" || TbxDni == null)
                alumnoValido = false;

            if (DtpckNacimiento.SelectedDate == null)
                alumnoValido = false;

            if (alumnoValido)
                alumno = new Alumno(TbxNombre.Text, TbxApellido.Text, TbxDni.Text, DtpckNacimiento.SelectedDate.Value);
            else
                MessageBox.Show("MAL");
        }
        public Alumno GetAlumno()
        {
            return this.alumno;
        }
    }
}
