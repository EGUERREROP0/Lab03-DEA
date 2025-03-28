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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        List<Persona> personas = new List<Persona>();
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string nombres = txtNombre.Text;
            string apellido = txtApellido.Text;

           
            personas.Add(new Persona { nombres = nombres, apellido = apellido });
            dgDemo.ItemsSource = null;
            dgDemo.ItemsSource = personas;
        }
    }
}
