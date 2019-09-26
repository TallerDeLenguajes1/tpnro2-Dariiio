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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ParteVisual
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Docente aa = new Docente();
            Docente bb = new Docente();
            Alumno aaa = new Alumno();
            aa.Nombre = "aaaa";
            aa.Apellido = "eee";
            aa.Dni = "1212121";
            aa.Cargo = "Emperador";
            //aa = bb;
            Curso cc = new Presencial();
            cc.Docente = aa;
            cc.CargarAlumno(aaa);
            MessageBox.Show(cc.Docente.ToString());
        }
    }
}
