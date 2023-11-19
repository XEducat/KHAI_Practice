using Project_OOP.Interfaces;

namespace Project_OOP.Moldels.Crews
{
    /// <summary>
    /// Модель представлення екіпажу
    /// </summary>
    public class MilitaryCrew : ICrew
    {
        public Pilot Pilot { get; set; }        // Пілот
        public Pilot SecondPilot { get; set; }  // Другий пілот

        public int Membership { get; private set; }    // К-сть членів

        public MilitaryCrew(Pilot pilot, Pilot secondPilot)
        {
            throw new NotImplementedException();
        }
    }
}
