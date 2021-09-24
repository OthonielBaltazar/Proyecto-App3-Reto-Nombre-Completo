namespace App3.ViewModels
{
    class NombreCompletoViewModel : ViewModelBase
    {
        string nombre;
        string apellido1;
        string apellido2;

        public string Nombre
        {
            get => nombre;
            set
            {
                if (string.Equals(nombre, value)) return;
                nombre = value;
                RaisePropertyChanged(nameof(Nombre));
                RaisePropertyChanged(nameof(NombreCompleto));
            }
        }

        public string Apellido1
        {
            get => apellido1;
            set
            {
                if (string.Equals(apellido1, value)) return;
                apellido1 = value;
                RaisePropertyChanged(nameof(Apellido1));
                RaisePropertyChanged(nameof(NombreCompleto));
            }
        }

        public string Apellido2
        {
            get => apellido2;
            set
            {
                if (string.Equals(apellido2, value)) return;
                apellido2 = value;
                RaisePropertyChanged(nameof(Apellido2));
                RaisePropertyChanged(nameof(NombreCompleto));
            }
        }

        public string NombreCompleto
        {
            get => string.Format("Tu nombre completo es : {0} {1} {2} ", nombre,apellido1, apellido2);
        }

    }
}

