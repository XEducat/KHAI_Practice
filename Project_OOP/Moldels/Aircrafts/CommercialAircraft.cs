using Project_OOP.Interfaces;
using Project_OOP.Moldels.Crews;

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

        private List<Passenger> passengers = new List<Passenger>(); // Список пасажирів
        public CommercialCrew crew;                                 // Екіпаж літаку

        public CommercialAircraft(string model, string number, int numberOfSeats, CommercialCrew crew) : this(model, number, numberOfSeats)
        {
            throw new NotImplementedException();
        }

        public CommercialAircraft(string model, string number, int numberOfSeats)
        {
            throw new NotImplementedException();
        }

        // Повертає список пасажирів
        public List<Passenger> getPassangers()
        {
            throw new NotImplementedException();
        }

        public void addPassenger(Passenger passanger)
        {
            throw new NotImplementedException();
        }

        public void addPassengers(IEnumerable<Passenger> passengersToAdd)
        {
            throw new NotImplementedException();
        }

        // Повертає екіпаж літака
        public ICrew getCrew()
        {
            throw new NotImplementedException();
        }

        public void setCrew(CommercialCrew crew)
        {
            throw new NotImplementedException();
        }
    }
}
