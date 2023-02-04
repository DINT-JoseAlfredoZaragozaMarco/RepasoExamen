using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using RepasoExamen.Mensajeria;
using RepasoExamen.Modelos;
using RepasoExamen.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RepasoExamen.VistasModelo
{
    class MainWindowVM : ObservableObject
    {
		private ServicioNavegacion servicioNavegacion;
		private ObservableCollection<Componentes> componentes;

		public ObservableCollection<Componentes> Componentes
        {
			get { return componentes; }
			set { SetProperty(ref componentes, value); }
		}

		private Componentes componenteSeleccionado;

		public Componentes ComponenteSeleccionado
		{
			get { return componenteSeleccionado; }
			set { SetProperty(ref componenteSeleccionado, value);}
		}

		private UserControl	contenidoVentana;

		public UserControl ContenidoVentana
        {
			get { return contenidoVentana; }
			set { SetProperty(ref contenidoVentana, value); }
		}


		public RelayCommand InfoCommand { get; }
        public RelayCommand InfoComponenteCommand { get; }

        public MainWindowVM()
		{
			this.servicioNavegacion = new ServicioNavegacion();
			Componentes = new ObservableCollection<Componentes>();
			ComponenteSeleccionado = new Componentes();

			Componentes = componenteSeleccionado.GetSamples();

			ComponenteSeleccionado = null;

			InfoCommand = new RelayCommand(CargarInfoWindow);
			InfoComponenteCommand = new RelayCommand(CargarComponenteInfoWindow);

			WeakReferenceMessenger.Default.Register<MainWindowVM, EnviarComponenteSeleccionadoMessage>
				(this, (r, m) =>
				{
					if (!m.HasReceivedResponse)
					{
						m.Reply(ComponenteSeleccionado);
					}
				});
		}

		public void CargarInfoWindow()
		{
			this.servicioNavegacion.CargarInfoWindow();
		}

		public void CargarComponenteInfoWindow()
		{
			ContenidoVentana = this.servicioNavegacion.CargarComponenteInfoWindow();
		}
	}
}
