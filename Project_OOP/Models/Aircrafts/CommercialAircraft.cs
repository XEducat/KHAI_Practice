using Project_OOP.Interfaces;
using Project_OOP.Models.Persons;

namespace Project_OOP.Moldels.Aircrafts
{
    /// <summary>
    /// Клас характеризує, комерційний літак
    /// </summary>
    public class CommercialAircraft : Aircraft
    {
        public CommercialAircraft(string model, string number, int numberOfSeats, List<Person> passengerTrain) : base(model, number, numberOfSeats)
        {
            this.passengerTrain = passengerTrain;
        }

        public CommercialAircraft(string Model, string Number, int NumberOfSeats) : base(Model, Number, NumberOfSeats)
        {

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

        public override void setCrew(List<Person> crew)
        {
            if (isValidCrew(crew))
                throw new Exception("Екіпаж повинен мати капітана та першого пілота.");

            base.setCrew(crew);
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