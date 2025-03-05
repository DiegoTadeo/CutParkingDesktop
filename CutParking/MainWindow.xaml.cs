using System.Windows;
using MaterialDesignThemes.Wpf;

namespace CutParking
{
    public partial class MainWindow : Window
    {
        // Cola de mensajes para Snackbar
        public static readonly SnackbarMessageQueue MessageQueue = new SnackbarMessageQueue();

        public MainWindow()
        {
            InitializeComponent();

            // Asegurar que SnackbarMensaje existe antes de asignar la MessageQueue
            if (SnackbarMensaje != null)
            {
                SnackbarMensaje.MessageQueue = MessageQueue;
            }
        }

        private void IniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            MessageQueue.Enqueue("Iniciando sesión...");
        }

        private void Registrarse_Click(object sender, RoutedEventArgs e)
        {
            MessageQueue.Enqueue("Registrando usuario...");
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            MessageQueue.Enqueue("Saliendo...");
            Application.Current.Shutdown();
        }
    }
}
