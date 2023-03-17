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
using TossalERP.Library;

namespace TossalERP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonCrearActo_Click(object sender, RoutedEventArgs e)
        {
            CreacionActo form = new CreacionActo();
            form.ShowDialog();
        }

        private void ButtonCrearMusico_Click(object sender, RoutedEventArgs e)
        {
            CreacionMusico form = new CreacionMusico();
            form.ShowDialog();
        }

        private void ButtonVerMusicos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonVerActos_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
