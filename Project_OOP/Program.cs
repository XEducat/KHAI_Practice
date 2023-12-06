using Project_OOP.Models;

namespace Project_OOP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            GeographicLocation NewYoukLocation = new GeographicLocation(40.7128, -74.0060, "New York City");
            Airport LA = new Airport("Los Airlance", "B201", NewYoukLocation);

            Application.Run(new AirportForm(LA));
        }
    }
}