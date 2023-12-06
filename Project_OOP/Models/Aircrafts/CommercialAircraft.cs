using Project_OOP.Enums;
using Project_OOP.Interfaces;
using Project_OOP.Models.Persons;
using System.ComponentModel;
using System.Text;

namespace Project_OOP.Moldels.Aircrafts
{
    /// <summary>
    /// Клас характеризує, комерційний літак
    /// </summary>

    [DisplayName("Комерційний літак")]
    public class CommercialAircraft : Aircraft
    {
        private bool HasCaptain => getCrew().Any(person => person is Pilot pilot && pilot.Role == PersonalRole.Captain);
        private bool HasFirstPilot => getCrew().Any(person => person is Pilot pilot && pilot.Role == PersonalRole.FirstPilot);

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
            if (isNotValidCrew(crew))
                throw new Exception("Екіпаж повинен мати капітана та першого пілота.");

            base.setCrew(crew);
        }

        // Перевірка на валідність екіпажу
        private bool isNotValidCrew(List<Person> checkedCrew)
        {
            Pilot? captain = checkedCrew.FirstOrDefault(person => person is Pilot pilot && pilot.Role == PersonalRole.Captain) as Pilot;
            Pilot? firstPilot = checkedCrew.FirstOrDefault(person => person is Pilot pilot && pilot.Role == PersonalRole.FirstPilot) as Pilot;

            return (captain == null || firstPilot == null);
        }

        public override bool IsReadyForFlight()
        {
            return HasCaptain && HasFirstPilot;
        }

        public override string GetFlightReadinessMessage()
        {
            if (HasCaptain && HasFirstPilot)
            {
                return "Літак готовий до політу.";
            }
            else
            {
                StringBuilder message = new StringBuilder("Не вистачає наступних членів екіпажу: ");

                if (!HasCaptain)
                {
                    message.Append("Капітана, ");
                }

                if (!HasFirstPilot)
                {
                    message.Append("Першого пілота, ");
                }

                message.Remove(message.Length - 2, 2); // Remove the last comma and space

                return message.ToString();
            }
        }

        public override string ToString()
        {
            StringBuilder message = new StringBuilder("Екіпаж: \n");
            int personIndex = 1;

            foreach (var person in getCrew())
            {
                message.AppendLine(personIndex + ". " + person.ToString());
                personIndex++;
            }

            personIndex = 1;
            message.AppendLine("\nПасажири: ");
            foreach (var person in getPassangers())
            {
                message.AppendLine(personIndex + ". " + person.ToString());
                personIndex++;
            }

            return message.ToString();
        }
    }
}