using Project_OOP.Enums;
using Project_OOP.Moldels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_OOP.Models.Persons
{
    [DisplayName("Пілот")]
    public sealed class Pilot : Person
    {
        private int expirience;
        public int Expirience {
            get { return expirience; }
            set 
            {
                if(value >= 0 && value <= Age - 16) 
                {
                    expirience = value;
                }
                else
                {
                    throw new ValidationException("Данна кількість робосого стажу неможлива. Вік не відповідає досвіду");
                }
            }
        }

        public override int Age
        {
            get { return age; }
            protected set
            {
                if (value >= 18 && value <= MAX_AGE)
                {
                    age = value;
                }
                else
                {
                    throw new FormatException("Пілот не повнолітний. Введіть коректне число (від 18 до 140).");
                }
            }
        }

        public PersonalRole Role { get; set; }

        public override string DisplayRole
        {
            get
            {
                return base.DisplayRole + " - " + Role.GetDisplayValue();
            }
        }

        public const int MAX_EXPIRIENCE = 70;

        public Pilot(string? name, int age, int expirience, PersonalRole role) : base(name, age)
        {
            Expirience = expirience;
            Role = role;
        }

        public override string ToString()
        {
            return $"{Name}  -  {Age} років | Стаж: {expirience} роки";
        }
    }
}