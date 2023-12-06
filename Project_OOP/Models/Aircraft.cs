using Project_OOP.Models.Persons;
using Project_OOP.Moldels;
using System.Text.RegularExpressions;

namespace Project_OOP.Interfaces
{
    public abstract class Aircraft
    {
        private string? model;
        public virtual string? Model  // Модель літака
        { 
            get 
            {
                return model;    
            } 
            protected set 
            {
                if (IsModelValid(value))
                {
                    model = value;
                }
                else
                {
                    throw new FormatException("Невірний формат моделі літака. Модель може містити лише букви, цифри та тире.");
                }
            } 
        }
        public virtual string Number { get; protected set; }      // Номер літака
        public virtual int NumberOfSeats { get; protected set; }  // Кількість місць (з урахуванням місць для екіпажу)
        public virtual List<Person> passengerTrain { get; protected set; } = new List<Person>();  // Пасажирський склад
        public virtual List<Type> DisallowedPersonTypes { get; set; } = new List<Type>();  // Заборонені типи осіб (які можна заносити в passangerTrain)

        protected Aircraft(string Model, string Number, int NumberOfSeats)
        {
            this.Model = Model;
            this.Number = Number;
            this.NumberOfSeats = NumberOfSeats;
        }

        public abstract bool IsReadyForFlight();
        public abstract string GetFlightReadinessMessage();
        public abstract new string ToString();

        /// <summary>
        /// Перебирає список пасажирського складу, прибираючи пасажирів
        /// </summary>
        /// <returns> Повертає екіпаж літакає </returns>
        public virtual List<Person> getCrew()
        {
            List<Person> returnedCrew = new List<Person>();

            foreach (var item in passengerTrain)
            {
                if (item is Passenger) continue;

                returnedCrew.Add(item);
            }

            return returnedCrew;
        }

        /// <summary>
        /// Додає всіх персон в колекцію пасажирського складу(passengerTrain)
        /// видаляючи минулий екіпаж (за винятком объектів класу Passanger).
        /// </summary>
        /// <param name="crew"></param>
        /// <exception cref="Exception"></exception>
        public virtual void setCrew(List<Person> crew)
        {
            List<Person> newCrew = new List<Person>();

            foreach (var person in crew)
            {
                if (person is Passenger) continue;

                newCrew.Add(person);
            }

            passengerTrain.RemoveAll(person => !(person is Passenger));
            passengerTrain.InsertRange(0, newCrew);
        }

        /// <summary>
        /// Перевірка властивості моделі на валідність.
        /// [ Модель містить букви, цифри, тире, а також кириличні символи ]
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual bool IsModelValid(string? model)
        {
            bool isValid = false;

            if (model != null)
            {
                string pattern = @"^[\p{L}0-9\-]*$";

                isValid = Regex.IsMatch(model, pattern);
            }

            return isValid;
        }
    }
}