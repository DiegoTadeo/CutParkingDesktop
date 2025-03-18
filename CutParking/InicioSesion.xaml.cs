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

namespace CutParking
{
    /// <summary>
    /// Lógica de interacción para InicioSesion.xaml
    /// </summary>
    public partial class InicioSesion : Window
    {
        public InicioSesion()
        {
            InitializeComponent();
            inicio_Click(null, null);
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            MainWindow principal = new MainWindow();
            principal.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //MiPerfil
        {
            MainContent.Content = new TextBlock
            {
                Text = "Contenido de Cuenta",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                FontSize = 20
            };
        }

        private void reservar_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new TextBlock
            {
                Text = "Contenido de Reservar",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                FontSize = 20
            };
        }

        private void vehiculos_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new TextBlock
            {
                Text = "Contenido de Vehiculos",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                FontSize = 20
            };
        }

        private void inicio_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new TextBlock
            {
                Text = "Contenido de Inicio",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                FontSize = 20
            };
        }
    }
}
