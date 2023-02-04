using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamen.Modelos
{
    class Componentes : ObservableObject
    {

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }

        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { SetProperty(ref tipo, value); }
        }

        private string foto;

        public string Foto
        {
            get { return foto; }
            set { SetProperty(ref foto, value); }
        }

        private int precio;

        public int Precio
        {
            get { return precio; }
            set { SetProperty(ref precio, value); }
        }
            
        public Componentes() { }

        public Componentes(string nombre, string tipo, string foto, int precio)
        {
            Nombre = nombre;
            Tipo = tipo;
            Foto = foto;
            Precio = precio;
        }

        public ObservableCollection<Componentes> GetSamples()
        {
            var lista = new ObservableCollection<Componentes>();
            lista.Add(new Componentes("AMD Ryzen 7 5800X", "Procesador", "../assets/AMD_Ryzen_7_5800X.jpg", 452));
            lista.Add(new Componentes("Intel Core i7-11700K", "Procesador", "../assets/Intel_Core_i7_11700K.jpg", 365));
            lista.Add(new Componentes("Gainward 471056224", "Tarjeta", "../assets/Gainward_471056224.jpg", 1719));
            lista.Add(new Componentes("ASUS ROG Maximus XIII Extreme", "Placa base", "../assets/ASUS_ROG_Maximus_XIII_Extreme.jpg", 976));
            lista.Add(new Componentes("ASRock X570 Creator", "Placa base", "../assets/ASRock_X570_Creator.jpg", 512));
            return lista;
        }
    }
}
