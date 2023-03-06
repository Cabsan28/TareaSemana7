using Xamarin.Forms;
using System;
using System.Collections.ObjectModel;
using TareaS7.Model;
using TareaS7.ViewModel;

namespace TareaS7
{
    public partial class MainPage : TabbedPage
    {
        private LibroViewModel libroViewModel;
        private PersonaViewModel personaViewModel;
        private PrestamoViewModel prestamoViewModel;

        public MainPage()
        {
            InitializeComponent();

             
            libroViewModel = new LibroViewModel();
            personaViewModel = new PersonaViewModel();
            prestamoViewModel = new PrestamoViewModel();

           
            var librosPage = new ContentPage();
            librosPage.Content = new ListView() { ItemsSource = libroViewModel.Libros };
            librosPage.Title = "Libros";

            var personasPage = new ContentPage();
            personasPage.Content = new ListView() { ItemsSource = personaViewModel.Personas };
            personasPage.Title = "Personas";

            var prestamosPage = new ContentPage();
            prestamosPage.Content = new ListView() { ItemsSource = prestamoViewModel.Prestamos };
            prestamosPage.Title = "Préstamos";

          
            Children.Add(librosPage);
            Children.Add(personasPage);
            Children.Add(prestamosPage);
        }
        private void AgregarLibro_Clicked(object sender, EventArgs e)
        {
            var nombre = txtNombreLibro.Text;
            var autor = txtAutor.Text;
            var fechaImpresion = dpFechaImpresion.Date;

            var libro = new Libro
            {
                Nombre = nombre,
                Autor = autor,
                FechaImpresion = fechaImpresion
            };

            libroViewModel.AgregarLibro(libro);

            txtNombreLibro.Text = "";
            txtAutor.Text = "";
            dpFechaImpresion.Date = DateTime.Now;

            lstLibros.SelectedItem = null;
        }

        private void AgregarPersona_Clicked(object sender, EventArgs e)
        {
            var nombre = txtNombrePersona.Text;
            var numeroCuenta = txtNumeroCuenta.Text;

            var persona = new Persona
            {
                Nombre = nombre,
                NumeroCuenta = numeroCuenta
            };

            personaViewModel.AgregarPersona(persona);

            txtNombrePersona.Text = "";
            txtNumeroCuenta.Text = "";

            lstPersonas.SelectedItem = null;
        }


        private void AgregarPrestamo_Clicked(object sender, EventArgs e)
        {
            var persona = txtPersona.Text;
            var libro = txtLibro.Text;
            var fechaPrestamo = dpFechaPrestamo.Date;
            var fechaDevolucion = dpFechaDevolucion.Date;

            var prestamo = new Prestamo
            {
                Persona = persona,
                Libro = libro,
                FechaPrestamo = fechaPrestamo,
                FechaDevolucion = fechaDevolucion
            };

            prestamoViewModel.AgregarPrestamo(prestamo);

            txtPersona.Text = "";
            txtLibro.Text = "";
            dpFechaPrestamo.Date = DateTime.Now;
            dpFechaDevolucion.Date = DateTime.Now;

            lstPrestamos.SelectedItem = null;
        }
    }

}
