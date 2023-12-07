
using System.ComponentModel;
using System.Windows.Input;

namespace Patron_MVVM_sin_libreria.ViewModels
{
    // INotifyPropertyChanged: Se utiliza en UI para notificar a XAML cuando las propiedades de un objeto han cambiado
    internal class MainViewModel : INotifyPropertyChanged
    {
        private int _count;

        //Encapsular la variable count
        public int Count 
        { 
            get { return _count; }
            set
            {
                _count = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Count"));
            }
        }

        // Notifica el cambio de propiedad a la interfaz
        public event PropertyChangedEventHandler PropertyChanged;

        //Command nos permite ejecutar acciones
        public ICommand SumarCommand => new Command(Sumar);

        public void Sumar()
        {
            Count++;
        }

    }
}
