using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace capa_entidades
{
    internal class MensajesDeError
    {
        static internal void CampoVacioCb()
        {
            string messageBoxText = "Seleccione alguna de las opciones";
            string caption = "Campo Vacío";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Warning;

            MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes); 
        }
        static internal void CampoVacioTb()
        {
            string messageBoxText = "Rellene el campo";
            string caption = "Campo Vacío";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Warning;

            MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
        }
    }
}

