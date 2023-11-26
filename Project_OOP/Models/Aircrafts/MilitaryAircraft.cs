using Project_OOP.Interfaces;
using Project_OOP.Models.Persons;

namespace Project_OOP.Moldels.Aircrafts
{
    /// <summary>
    /// Клас характеризує воєнний літак
    /// </summary>
    public class MilitaryAircraft : Aircraft
    {
        //public string Model { get; private set; }
        //public string Number { get; private set; }
        //public int NumberOfSeats { get; private set; }

        //public List<Person> passengerTrain { get; private set; } = new List<Person>();    // Пасажирський склад


        public MilitaryAircraft(string Model, string Number, int NumberOfSeats, List<Person> crew) : base(Model, Number, NumberOfSeats)
        {
            this.passengerTrain = crew;
        }

        public MilitaryAircraft(string Model, string Number, int NumberOfSeats) : base(Model, Number, NumberOfSeats)
        {

        }

        public override void setCrew(List<Person> crew)
        {
            if (isValidCrew(crew))
                throw new Exception("Екіпаж повинен мати капітана та першого пілота.");

            base.setCrew(crew);
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
