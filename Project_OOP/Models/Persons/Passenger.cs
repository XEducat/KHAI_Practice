using Project_OOP.Moldels;
using System.ComponentModel;

namespace Project_OOP.Models.Persons
{
    /// <summary>
    /// Модель представлення пасажиру
    /// </summary>
    [DisplayName("Пасажир")]
    public class Passenger : Person
    {
        public string TicketNumber { get; set; }    // Номер білету

        public Passenger(string name, int age, string ticketNumber) : base(name, age)
        {
            TicketNumber = ticketNumber;
        }

        public override string ToString()
        {
            return $"{Name} - {Age} років | Білет #{TicketNumber}";
        }
    }
}
