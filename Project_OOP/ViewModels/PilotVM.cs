using Project_OOP.Enums;
using Project_OOP.Models.Persons;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Project_OOP.ViewModels
{
    public class PilotVM : INotifyPropertyChanged
    {
        private string? pilotName;
        private string? pilotAge;
        private string? pilotExperience;
        private string? selectedPilotRole;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string? PilotName
        {
            get { return pilotName ?? ""; }
            set
            {
                pilotName = value;
                OnPropertyChanged(nameof(PilotName));
            }
        }

        public string? PilotAge
        {
            get { return pilotAge; }
            set
            {
                pilotAge = value;
                OnPropertyChanged(nameof(PilotAge));
            }
        }

        public string? PilotExperience
        {
            get { return pilotExperience; }
            set
            {
                pilotExperience = value;
                OnPropertyChanged(nameof(PilotExperience));
            }
        }

        public string SelectedPilotRole
        {
            get { return selectedPilotRole ?? ""; }
            set
            {
                selectedPilotRole = value;
                OnPropertyChanged(nameof(SelectedPilotRole));
            }
        }

        public ObservableCollection<string> PilotRoles { get; }

        public bool FieldsNotEmpty
        {
            get
            {
                return !string.IsNullOrWhiteSpace(PilotName)
                    && !string.IsNullOrWhiteSpace(PilotAge)
                    && !string.IsNullOrWhiteSpace(PilotExperience)
                    && !string.IsNullOrWhiteSpace(SelectedPilotRole);
            }
        }

        public PilotVM()
        {
            PilotRoles = new ObservableCollection<string>(EnumExtensions.GetDisplayValues<PersonalRole>());
        }

        public Pilot GetPilot()
        {
            // Створення та повернення нового об'єкта Pilot
            if (int.TryParse(PilotAge, out int pilotAge) && int.TryParse(PilotExperience, out int pilotExperience))
            {
                PersonalRole pilotRole = (PersonalRole)PilotRoles.IndexOf(SelectedPilotRole);

                if (pilotRole != PersonalRole.None)
                {
                    return new Pilot(PilotName, pilotAge, pilotExperience, pilotRole);
                }
            }

            // Повернення null або викидання винятку на основі логіки вашого додатка
            return null;
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
