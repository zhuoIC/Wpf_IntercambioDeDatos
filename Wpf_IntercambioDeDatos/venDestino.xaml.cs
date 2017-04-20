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

namespace Wpf_IntercambioDeDatos
{
    /// <summary>
    /// Lógica de interacción para verDestino.xaml
    /// </summary>
    public partial class VenDestino : Window
    {
        public VenDestino()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            tbxDestino.Text = (Application.Current as App).Dato;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            tbxDestino.Text = (Application.Current as App).Dato;
        }
    }
}
