using Project_OOP.Interfaces;
using Project_OOP.Moldels.Aircrafts;

namespace Project_OOP
{
    public class Airport
    {
        public string Name { get; private set; }      // Назва
        public string Code { get; private set; }      // Код
        public GeographicLocation Location  { get; private set; }  // Місцезнаходження
        private List<IAircraft> aircrafts = new List<IAircraft>();    // Список літаків

        public Airport(GeographicLocation location)
        {
            this.Location = location;
        }

        public void AddAircraft(IAircraft aircraft)
        {
            aircrafts.Add(aircraft);
        }

        public IAircraft? FindAircraft(string number)
        {
            return aircrafts.FirstOrDefault(a => a.Number == number);
        }

        public CommercialAircraft? FindCommercialAircraft(string Number)
        {
            return (CommercialAircraft?)FindAircraft(Number);
        }

        public MilitaryAircraft? FindMilitaryAircraft(string model)
        {
            return (MilitaryAircraft?)FindAircraft(model);
        }

        public List<IAircraft> getAircrafts()
        {
            throw new NotImplementedException();
        }
    }
}
