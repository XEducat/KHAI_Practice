using Project_OOP.Enums;
using Project_OOP.Interfaces;
using Project_OOP.Models.Persons;
using System.ComponentModel;
using System.Text;

namespace Project_OOP.Moldels.Aircrafts
{
    /// <summary>
    /// Клас характеризує воєнний літак
    /// </summary>

    [DisplayName("Військовий літак")]
    public class MilitaryAircraft : Aircraft
    {
        private bool HasPilot => getCrew().Any(person => person is Pilot pilot && pilot.Role == PersonalRole.Pilot);
        private bool HasFirstPilot => getCrew().Any(person => person is Pilot pilot && pilot.Role == PersonalRole.FirstPilot);

        public override List<Type> DisallowedPersonTypes { get; set; } = new List<Type>
        {
            typeof(Passenger),
            // Add more disallowed types as needed
        };

        public MilitaryAircraft(string Model, string Number, int NumberOfSeats, List<Person> crew) : base(Model, Number, NumberOfSeats)
        {
            if (crew.Any(person => DisallowedPersonTypes.Contains(person.GetType())))
            {
                throw new Exception("Воєнний літак не має пасажирів.");
            }

            this.passengerTrain = crew;
        }

        public MilitaryAircraft(string Model, string Number, int NumberOfSeats) : base(Model, Number, NumberOfSeats)
        {

        }

        public override void setCrew(List<Person> crew)
        {
            if (isNotValidCrew(crew))
                throw new Exception("Екіпаж повинен мати пілота та першого пілота.");

            base.setCrew(crew);
        }

        // Перевірка чи є капітан та перший пілот у екіпажі
        public bool isNotValidCrew(List<Person> checkedCrew)
        {
            Pilot? pilot = checkedCrew.FirstOrDefault(person => person is Pilot pilot && pilot.Role == PersonalRole.Pilot) as Pilot;
            Pilot? firstPilot = checkedCrew.FirstOrDefault(person => person is Pilot pilot && pilot.Role == PersonalRole.FirstPilot) as Pilot;

            return pilot == null || firstPilot == null;
        }

        public override bool IsReadyForFlight()
        {
            return HasPilot && HasFirstPilot;
        }

        public override string GetFlightReadinessMessage()
        {
            if (HasPilot && HasFirstPilot)
            {
                return "Літак готовий до політу.";
            }
            else
            {
                StringBuilder message = new StringBuilder("Не вистачає наступних членів екіпажу: ");

                if (!HasPilot)
                {
                    message.Append("Пілота, ");
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

            return message.ToString();
        }
    }
}
