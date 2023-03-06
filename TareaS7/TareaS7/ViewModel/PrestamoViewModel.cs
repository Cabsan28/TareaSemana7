using System.Collections.ObjectModel;
using TareaS7.Model;

namespace TareaS7.ViewModel
{
    public class PrestamoViewModel
    {
        public ObservableCollection<Prestamo> Prestamos { get; set; }

        public PrestamoViewModel()
        {
            Prestamos = new ObservableCollection<Prestamo>();
        }



        public void AgregarPrestamo(Prestamo prestamo)
        {
            Prestamos.Add(prestamo);
        }
    }
}
