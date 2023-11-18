using Project_OOP.Interfaces;

namespace Project_OOP.Moldels.Crews
{
    /// <summary>
    /// Клас, характеризує екіпаж комерційного літака
    /// </summary>
    public class CommercialCrew : ICrew
    {
        public Pilot Captain { get; private set; }      // Капітан
        public Pilot FirstPilot { get; private set; }   // Перший пілот
        public Pilot? SecondPilot { get; private set; } // Другий пілот

        public int Membership { get; private set; }    // К-сть членів

        public CommercialCrew(Pilot Сapitan, Pilot FirstPilot, Pilot? SecondPilot = null)
        {
            throw new NotImplementedException();
        }
    }
}
