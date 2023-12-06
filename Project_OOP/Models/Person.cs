using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Project_OOP.Moldels
{
    // Базовий клас для всіх персон (Наприклад: пасажир, пілот, стюардеса і тд. )
    public abstract class Person
    {
        protected string? name; // Ім'я
        protected int age;     // Вік

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Ім'я повинно містити від 2 до 50 символів")]
        public virtual string? Name
        {
            get { return name ?? ""; }

            protected set 
            {   
                if (value?.Length <= MAX_NAME_LENGTH)
                {
                    if (IsAllLetters(value))
                    {
                        name = value;
                    }
                    else
                    {
                        throw new FormatException("Невірний формат імені, ім'я складається тільки з букв, без пробілів.");
                    }
                }
                else
                {
                    throw new FormatException("Довжина імені занадто велика.");
                }

            }
        }

        public virtual int Age 
        { 
            get { return age; } 
            protected set
            {
                if(value >= 1 && value <= MAX_AGE)
                {
                    age = value;
                }
                else
                {
                    throw new FormatException("Введена кілкість років є неможливою. Введіть коректне число (від 1 до 140).");
                }
            }
        }


        /// <summary>
        /// Роль людини на літаку
        /// </summary>
        public virtual string DisplayRole
        {
            get
            {
                var displayNameAttribute = GetType().GetCustomAttribute<DisplayNameAttribute>();
                return displayNameAttribute?.DisplayName ?? GetType().Name;
            }
        }

        public const int MAX_AGE = 140;
        public const int MAX_NAME_LENGTH = 50;

        protected Person (string? name, int age) 
        {
            this.Name = name;
            this.Age = age;
        }

        public abstract new string ToString();


        // Перевірка, що рядок складається з букв і містить один пробіл між словами
        //private bool IsAllLettersWithOneSpace(string text)
        //{
        //    // Перевірка, що вхід складається з букв і може містити один пробіл між словами
        //    return System.Text.RegularExpressions.Regex.IsMatch(text, @"^[a-zA-Z]+( [a-zA-Z]+)?$");
        //}

        private bool IsAllLetters(string? value)
        {
            return value != null && value.All(char.IsLetter);
        }
    }
}
