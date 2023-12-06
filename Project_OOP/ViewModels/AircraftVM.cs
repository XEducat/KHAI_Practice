using Project_OOP.Interfaces;
using Project_OOP.Models.Persons;
using Project_OOP.Moldels;
using Project_OOP.Moldels.Aircrafts;
using Project_OOP.Views;
using System.ComponentModel;
using System.Reflection;

namespace Project_OOP.ViewModels
{
    public class AircraftVM
    {
        //public event EventHandler<PersonCreatedEventArgs> OnPersonCreated;     -- #CAN BE MOVE IN TRASH --
        public BindingList<Person> Persons { get; } = new BindingList<Person>();

        public void CreatePerson(Type personType)
        {
            switch (personType.Name)
            {
                case nameof(Passenger):
                    OpenPassengerForm();
                    break;

                case nameof(Pilot):
                    OpenPilotForm();
                    break;

                default:
                    break;
            }

            // Відправити подію про створення особи
            //OnPersonCreated?.Invoke(this, new PersonCreatedEventArgs(personType.Name));     -- #CAN BE MOVE IN TRASH --
        }

        public Aircraft? CreateAircraft(string selectedType, string model, string number, int numberOfSeats)
        {
            Aircraft? newAircraft = null;

            switch (selectedType)
            {
                case "Комерційний літак":
                    newAircraft = new CommercialAircraft(model, number, numberOfSeats, Persons.ToList());
                    break;

                case "Військовий літак":
                    newAircraft = new MilitaryAircraft(model, number, numberOfSeats, Persons.ToList());
                    break;

                // Додайте інші варіанти за необхідності

                default:
                    break;
            }

            if (newAircraft != null && !newAircraft.IsReadyForFlight())
            {
                throw new Exception(newAircraft.GetFlightReadinessMessage());
            }

            return newAircraft;
        }

        /// <returns> Список відображуваних імен літаків. </returns>
        public List<string> GetAircraftTypes() => GetDisplayNames(typeof(Aircraft));

        /// <returns> Список відображуваних імен осіб. </returns>
        public List<string> GetPersonTypes() => GetDisplayNames(typeof(Person));


        /// <summary>
        /// Метод отримує тип за індексом, який наслідується від заданого базового типу (baseType).
        /// </summary>
        /// <param name="baseType"></param>
        /// <param name="index">Індекс типу</param>
        /// <returns>Вказаний тип, який наслідується від базового типу</returns>
        public Type? GetDerivedTypeAtIndex(Type baseType, int index)
        {
            List<Type> derivedTypes = GetDerivedTypes(baseType);

            if (index >= 0 && index < derivedTypes.Count)
            {
                return derivedTypes[index];
            }

            return null;
        }

        // Отримання типів з данного проекту які наслідуються від нашого baseType
        public List<Type> GetDerivedTypes(Type baseType)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            List<Type> derivedTypes = assembly.GetTypes()
                .Where(type => baseType.IsAssignableFrom(type) && type != baseType)
                .ToList();

            return derivedTypes;
        }

        /// <summary>
        /// Метод отримує всі типи у поточній збірці, які наслідуються від заданого 
        /// базового типу (baseType).
        /// </summary>
        /// <param name="baseType"></param>
        /// <returns> Список відображуваних імен типів</returns>
        public List<string> GetDisplayNames(Type baseType)
        {
            List<Type> derivedTypes = GetDerivedTypes(baseType);
            List<string> displayNames = GetDisplayNames(derivedTypes);
            return displayNames;
        }

        public List<string> GetDisplayNames(List<Type> types)
        {
            List<string> displayNames = types.Select(type => GetDisplayName(type)).ToList();
            return displayNames;
        }


        // Отримати відображуване ім'я для класу
        public string GetDisplayName(Type type)
        {
            DisplayNameAttribute? displayNameAttribute = type.GetCustomAttribute<DisplayNameAttribute>();
            return displayNameAttribute?.DisplayName ?? type.Name;
        }

        private void OpenPassengerForm()
        {
            PassengerForm passengerForm = new PassengerForm();
            passengerForm.OnPassengerCreated += PilotForm_OnPersonCreated;
            passengerForm.ShowDialog();
        }

        private void OpenPilotForm()
        {
            PilotForm pilotForm = new PilotForm();
            pilotForm.OnPilotCreated += PilotForm_OnPersonCreated;
            pilotForm.ShowDialog();
        }

        // Додайте нового пілота до колекції
        private void PilotForm_OnPersonCreated(object? sender, PersonCreatedEventArgs e)
        {
            Persons.Add(e.Person);
        }
    }

}