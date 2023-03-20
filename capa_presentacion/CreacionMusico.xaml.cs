using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
using capa_entidades;

namespace capa_presentacion
{
    /// <summary>
    /// Lógica de interacción para CreacionMusico.xaml
    /// </summary>
    public partial class CreacionMusico : Page
    {
        Instrumento instrumento;
        string nombre;

        public CreacionMusico()
        {
            InitializeComponent();
            CbInstrumentos.ItemsSource = Enum.GetValues(typeof(Instrumento));
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (CamposCorrectos())
            {
                Musico musico = new Musico();
                musico.Instrumento = instrumento;
                musico.Nombre = nombre;
                GuardarMusico();
                LimpiarFormulario();
            }
        }

        private bool CamposCorrectos()
        {
            if (TbNombre.Text == "")
            {
                MensajesDeError.CampoVacioTb();
                return false;
            }
            if (CbInstrumentos.SelectedItem == null)
            {
                MensajesDeError.CampoVacioCb();
                return false;
            }

            instrumento = (Instrumento)CbInstrumentos.SelectedItem;
            nombre = TbNombre.Text;

            return true;
        }

        private void LimpiarFormulario()
        {
            TbNombre.Text = "";
            CbInstrumentos.SelectedItem = null;
        }

        private void GuardarMusico()
        {
         
        }
    }
}
