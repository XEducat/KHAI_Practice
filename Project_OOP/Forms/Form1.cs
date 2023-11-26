using Project_OOP.Interfaces;
using Project_OOP.Models.Persons;
using Project_OOP.Moldels;
using Project_OOP.Moldels.Aircrafts;

namespace Project_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GeographicLocation NewYoukLocation = new GeographicLocation(40.7128, -74.0060, "New York City");
            Airport LA = new Airport(NewYoukLocation);

            List<Person> Persons1 = new List<Person>() {
                new Pilot("Steve", 48, 15, PersonalRole.Captain),
                new Pilot("Ban", 30, 5, PersonalRole.FirstPilot),
                new Passenger("Mark", 18, "#0001")
            };

            // Виготовили новий літак, та завесли на аеродром. Після за ним закріпили екіпаж
            CommercialAircraft aircraft1 = new CommercialAircraft("Airsock", "PM109", 34, Persons1);

            List<Person> Persons2 = new List<Person>() {
                new Pilot("Вася", 48, 25, PersonalRole.Captain),
                new Pilot("Петя", 30, 8, PersonalRole.FirstPilot),
                new Passenger("Боб", 18, "#0001"),
                new Passenger("Женя", 19, "#0001")
            };

            // Виготовили новий літак, та завесли на аеродром. Після за ним закріпили екіпаж
            MilitaryAircraft aircraft2 = new MilitaryAircraft("Lane", "D2", 22, Persons2);
            LA.AddAircraft(aircraft1);
            LA.AddAircraft(aircraft2);

            List<Person> newСrew = new List<Person>() {
                new Pilot("Бери", 50, 28, PersonalRole.Captain),
                new Pilot("Бран", 55, 30, PersonalRole.FirstPilot)
            };

            List<Passenger> pass = aircraft1.getPassangers();
            List<Person> crew1 = aircraft1.getCrew();
            List<Person> crew2 = aircraft2.getCrew();
            aircraft2.setCrew(newСrew);
            List<Person> newCrew = aircraft2.getCrew();

            //// Додання одного пасажиру
            //CommercialAircraft? commercial = LA.FindCommercialAircraft("PM109");
            //Passenger passenger = new Passenger("Jon", 17, "Ticket#001395");
            //aircraft1.addPassenger(passenger);

            //// Додання колекції пасажирів
            //List<Passenger> passengersCollection = new List<Passenger>();
            //aircraft1.addPassengers(passengersCollection);
        }
    }
}