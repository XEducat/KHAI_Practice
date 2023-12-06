using System.ComponentModel.DataAnnotations;

public static class EnumExtensions
{
    public static string? GetDisplayValue(this Enum value)
    {
        var field = value.GetType().GetField(value.ToString());
        var attribute = (DisplayAttribute?)Attribute.GetCustomAttribute(field, typeof(DisplayAttribute));

        return attribute == null ? value.ToString() : attribute.Name;
    }

    public static IList<string> GetDisplayValues<TEnum>()
    {
        var values = new List<string>();
        foreach (var field in typeof(TEnum).GetFields())
        {
            if (Attribute.GetCustomAttribute(field, typeof(DisplayAttribute)) is DisplayAttribute attribute)
            {
                values.Add(attribute.Name);
            }
        }
        return values;
    }
}
