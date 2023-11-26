using Project_OOP.Interfaces;
using Project_OOP.Models.Persons;

namespace Project_OOP.Moldels.Aircrafts
{
    /// <summary>
    /// Клас характеризує, комерційний літак
    /// </summary>
    public class CommercialAircraft : IAircraft
    {
        public string Model { get; private set; }
        public string Number { get; private set; }
        public int NumberOfSeats { get; private set; }

        public List<Person> passengerTrain { get; private set; } = new List<Person>();  // Пасажирський склад


        public CommercialAircraft(string model, string number, int numberOfSeats, List<Person> passengerTrain) : this(model, number, numberOfSeats)
        {
            this.passengerTrain = passengerTrain;
        }

        public CommercialAircraft(string Model, string Number, int NumberOfSeats)
        {
            this.Model = Model;
            this.Number = Number;
            this.NumberOfSeats = NumberOfSeats;
        }

        // Повертає список пасажирів
        public List<Passenger> getPassangers()
        {
            List<Passenger> passengers = new List<Passenger>();

            foreach (var person in passengerTrain)
            {
                if (person is Passenger passenger)
                {
                    passengers.Add(passenger);
                }
            }

            return passengers;
        }

        public void addPassenger(Passenger passanger)
        {
            passengerTrain.Add(passanger);
        }

        public void addPassengers(IEnumerable<Passenger> passengersToAdd)
        {
            passengerTrain.AddRange(passengersToAdd);
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

        // Перевірка на валідність екіпажу
        private bool isValidCrew(List<Person> checkedCrew)
        {
            Pilot? captain = checkedCrew.FirstOrDefault(person => person is Pilot pilot && pilot.Role == PersonalRole.Captain) as Pilot;
            Pilot? firstPilot = checkedCrew.FirstOrDefault(person => person is Pilot pilot && pilot.Role == PersonalRole.FirstPilot) as Pilot;

            return (captain == null || firstPilot == null);
        }
    }
}
