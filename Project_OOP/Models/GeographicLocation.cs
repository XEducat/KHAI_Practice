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
        Latitude = latitude;
        Longitude = longitude;
        Address = address;
    }

    // Метод для виведення інформації про місцезнаходження
    public override string ToString()
    {
        StringBuilder location = new StringBuilder();
        location.Append($"{Latitude}°, {Longitude}°\n");
        location.Append($"{Address}");
        return location.ToString();
    }
}
