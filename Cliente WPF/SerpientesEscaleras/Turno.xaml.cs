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

namespace SerpientesEscaleras
{
    public partial class Turno : Window
    {
        public Turno()
        {
            InitializeComponent();
        }

        public void EligiendoTurno()
        {

        }

        private void Rectangle_Clic(object sender, MouseButtonEventArgs e)
        {
            Rectangle rectangulo = sender as Rectangle;
            var rectanguloSeleccionado = grid_Fondos.Children.Cast<UIElement>().FirstOrDefault(i => i is Rectangle && i.Opacity == 1);
            if (rectanguloSeleccionado != null)
            {
                rectanguloSeleccionado.Opacity = 0;
            }
            rectangulo.Opacity = 1;
        }
    }
}
