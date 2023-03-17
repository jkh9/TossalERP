using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TossalERP.Library;

namespace TossalERP
{
    /// <summary>
    /// Lógica de interacción para CreacionMusico.xaml
    /// </summary>
    public partial class CreacionMusico : Window
    {
        public CreacionMusico()
        {
            InitializeComponent();
            Instrumentos.ItemsSource = Enum.GetValues(typeof(Instrumento));
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            
        }
    }
}
