using System.Text;

/// <summary>
/// Клас, характеризує місцезнаходження на земній карті
/// </summary>
public class GeographicLocation
{
    public readonly double Latitude;    // Широта
    public readonly double Longitude;   // Довгота
    public readonly string Address;     // Адреса

    // Конструктор класу
    public GeographicLocation(double latitude, double longitude, string address)
    {
        throw new NotImplementedException();
    }

    // Метод для виведення інформації про місцезнаходження
    public override string ToString()
    {
        throw new NotImplementedException();
    }
}
