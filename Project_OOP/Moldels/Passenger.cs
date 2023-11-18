namespace Project_OOP.Moldels
{
    /// <summary>
    /// Модель представлення пасажиру
    /// </summary>
    public class Passenger
    {
        public string Name { get; set; }            // Iм'я
        public string TicketNumber { get; set; }    // Номер білету

        public Passenger(string Name, string TicketNumber)
        {
            throw new NotImplementedException();
        }
    }
}
