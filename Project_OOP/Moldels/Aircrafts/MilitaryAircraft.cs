using Project_OOP.Interfaces;
using Project_OOP.Moldels.Crews;

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
        private MilitaryCrew crew;    // Екіпаж літака


        public MilitaryAircraft(MilitaryCrew crew, string Model, string Number, int NumberOfSeats) : this(Model, Number, NumberOfSeats)
        {
            throw new NotImplementedException();
        }

        public MilitaryAircraft(string model, string number, int numberOfSeats)
        {
            throw new NotImplementedException();
        }

        // Повертає екіпаж літака
        public ICrew getCrew()
        {
            throw new NotImplementedException();
        }

        public void setCrew(MilitaryCrew crew)
        {
            throw new NotImplementedException();
        }
    }
}
