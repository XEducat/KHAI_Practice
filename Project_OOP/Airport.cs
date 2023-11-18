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
            throw new NotImplementedException();
        }

        public void AddAircraft(IAircraft aircraft)
        {
            throw new NotImplementedException();
        }

        public IAircraft? FindAircraft(string number)
        {
            throw new NotImplementedException();
        }

        public CommercialAircraft? FindCommercialAircraft(string number)
        {
            throw new NotImplementedException();
        }

        public MilitaryAircraft? FindMilitaryAircraft(string number)
        {
            throw new NotImplementedException();
        }

        public List<IAircraft> getAircrafts()
        {
            throw new NotImplementedException();
        }
    }
}
