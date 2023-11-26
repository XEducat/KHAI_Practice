using Project_OOP.Interfaces;
using Project_OOP.Moldels;

namespace Project_OOP.Models.Persons
{
    public class Pilot : Person
    {
        public int Expirience { get; set; }

        public PersonalRole Role { get; set; }

        public Pilot(string name, int age, int expirience, PersonalRole role) : base(name, age)
        {
            Expirience = expirience;
            Role = role;
        }
    }
}