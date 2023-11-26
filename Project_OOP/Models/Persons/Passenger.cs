using Project_OOP.Moldels;

namespace Project_OOP.Models.Persons
{
    /// <summary>
    /// Модель представлення пасажиру
    /// </summary>
    public class Passenger : Person
    {
        public string TicketNumber { get; set; }    // Номер білету

        public Passenger(string name, int age, string ticketNumber) : base(name, age)
        {
            TicketNumber = ticketNumber;
        }
    }
}
