namespace Project_OOP.Interfaces
{
    public interface IAircraft
    {
        string Model { get; }       // Модель літака
        string Number { get; }      // Номер літака
        int NumberOfSeats { get; }  // Кількість місць (з урахуванням місць для екіпажу)

        ICrew getCrew();
    }
}
