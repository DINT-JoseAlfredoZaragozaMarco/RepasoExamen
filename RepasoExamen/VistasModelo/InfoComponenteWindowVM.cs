using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using RepasoExamen.Mensajeria;
using RepasoExamen.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamen.VistasModelo
{
    class InfoComponenteWindowVM : ObservableObject
    {
		private Componentes componente;

		public Componentes Componente
        {
			get { return componente; }
			set { SetProperty(ref componente, value); }
		}

		public InfoComponenteWindowVM()
		{
			Componente = new Componentes();

			Componente = WeakReferenceMessenger.Default.Send<EnviarComponenteSeleccionadoMessage>();
		}
	}
}
