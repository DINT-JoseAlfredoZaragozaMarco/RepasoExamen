using RepasoExamen.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RepasoExamen.Servicios
{
    class ServicioNavegacion
    {
        public ServicioNavegacion() { }

        public bool CargarInfoWindow()
        {
            InfoWindow info = new InfoWindow();
            bool result = (bool)info.ShowDialog();
            return result;
        }

        public UserControl CargarComponenteInfoWindow()
        {
            return new ComponenteInfo();
        }
    }
}
