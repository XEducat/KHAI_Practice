using Project_OOP.Interfaces;
using Project_OOP.Models.Persons;

namespace Project_OOP.Moldels.Aircrafts
{
    /// <summary>
    /// Клас характеризує воєнний літак
    /// </summary>
    public class MilitaryAircraft : IAircraft
    {
        public string Model { get; private set; }
        public string Number { get; private set; }
        public int NumberOfSeats { get; private set; }

        public List<Person> passengerTrain { get; private set; } = new List<Person>();    // Пасажирський склад


        public MilitaryAircraft(string Model, string Number, int NumberOfSeats, List<Person> crew) : this(Model, Number, NumberOfSeats)
        {
            this.passengerTrain = crew;
        }

        public MilitaryAircraft(string Model, string Number, int NumberOfSeats)
        {
            this.Model = Model;
            this.Number = Number;
            this.NumberOfSeats = NumberOfSeats;
        }

        // Повертає екіпаж літака
        public List<Person> getCrew()
        {
            List<Person> returnedCrew = new List<Person>();

            foreach (var item in passengerTrain)
            {
                if (item is Passenger) continue;

                returnedCrew.Add(item);
            }

            return returnedCrew;
        }

        public void setCrew(List<Person> crew)
        {
            if (isValidCrew(crew))
                throw new Exception("Екіпаж повинен мати капітана та першого пілота.");

            List<Person> newCrew = new List<Person>();

            foreach (var person in crew)
            {
                if (person is Passenger) continue;

                newCrew.Add(person);
            }

            passengerTrain.RemoveAll(person => !(person is Passenger));
            passengerTrain.AddRange(newCrew);
        }

        // Перевірка чи є капітан та перший пілот у екіпажі
        public bool isValidCrew(List<Person> checkedCrew)
        {
            Pilot? captain = checkedCrew.FirstOrDefault(person => person is Pilot pilot && pilot.Role == PersonalRole.Captain) as Pilot;
            Pilot? firstPilot = checkedCrew.FirstOrDefault(person => person is Pilot pilot && pilot.Role == PersonalRole.FirstPilot) as Pilot;

            return (captain == null || firstPilot == null);
        }
    }
}
