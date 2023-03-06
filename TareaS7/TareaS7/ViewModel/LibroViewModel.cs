using System;
using System.Collections.ObjectModel;
using TareaS7.Model;

namespace TareaS7.ViewModel
{
    public class LibroViewModel
    {
        public ObservableCollection<Libro> Libros { get; set; }

        public LibroViewModel()
        {
            Libros = new ObservableCollection<Libro>();
        }

        public void AgregarLibro(Libro libro)
        {
            Libros.Add(libro);
        }
 
    }
}