using Project_OOP.Models.Persons;
using Project_OOP.Moldels;

namespace Project_OOP.Interfaces
{
    public abstract class Aircraft
    {
        public virtual string Model { get; protected set; }       // Модель літака
        public virtual string Number { get; protected set; }      // Номер літака
        public virtual int NumberOfSeats { get; protected set; }  // Кількість місць (з урахуванням місць для екіпажу)
        public virtual List<Person> passengerTrain { get; protected set; } = new List<Person>();  // Пасажирський склад

        protected Aircraft(string Model, string Number, int NumberOfSeats)
        {
            this.Model = Model;
            this.Number = Number;
            this.NumberOfSeats = NumberOfSeats;
        }

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
    }
}