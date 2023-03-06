using System.Collections.ObjectModel;
using TareaS7.Model;

namespace TareaS7.ViewModel
{
    public class PersonaViewModel
    {
        public ObservableCollection<Persona> Personas { get; set; }

        public PersonaViewModel()
        {
            Personas = new ObservableCollection<Persona>();
        }

        public void AgregarPersona(Persona persona)
        {
            Personas.Add(persona);
        }
    }
}