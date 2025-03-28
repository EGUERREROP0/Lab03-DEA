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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona { nombres = "Juan", apellido = "Perez" });

            dgDemo.ItemsSource = personas;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string nombres = txtNombre.Text;
            string apellido = txtApellido.Text;

            List<Persona> persona = new List<Persona>();
            persona.Add(new Persona { nombres = nombres, apellido = apellido });
            dgDemo.ItemsSource = null;
            dgDemo.ItemsSource = persona;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string nombres = txtNombre.Text;
            string apellido = txtApellido.Text;

            List<Persona> personas = new List<Persona>();
            personas.Add (new Persona { nombres = nombres, apellido = apellido });
            dgDemo.ItemsSource = personas;

        }

        /* Nuevo*/
    }
}
