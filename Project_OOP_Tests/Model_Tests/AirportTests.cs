using Project_OOP.Interfaces;
using Project_OOP.Moldels.Aircrafts;
using Project_OOP.Models.Persons;
using Project_OOP.Models;

namespace Model_Tests
{
    [TestClass]
    [TestCategory("ModelTests")]
    public class AirportTests
    {
        [TestMethod]
        public void ConstructorSetsLocationCorrectly()
        {
            // Arrange
            GeographicLocation location = new GeographicLocation(40.7128, -74.0060, "New York");
            string Name = "New Air";
            string Code = "A000";

            // Act
            Airport airport = new Airport(Name, Code, location);

            // Assert
            Assert.AreEqual(Name, airport.Name);
            Assert.AreEqual(Code, airport.Code);
            Assert.AreEqual(location, airport.Location);
        }

        [TestMethod]
        public void AddPassenger_AddsPassengerToList()
        {
            // Arrange
            CommercialAircraft aircraft = new CommercialAircraft("Boeing", "123", 150);
            Passenger passenger = new Passenger("John", 30, "ABC123");

            // Act
            aircraft.addPassenger(passenger);

            // Assert
            CollectionAssert.Contains(aircraft.getPassangers(), passenger);
        }

        [TestMethod]
        public void FindAircraft_ReturnsCorrectAircraft()
        {
            // Arrange
            Airport airport = new Airport("New Air", "A000", new GeographicLocation(40.7128, -74.0060, "New York"));
            Aircraft aircraft1 = new CommercialAircraft("Boeing-737", "ABC123", 150);
            Aircraft aircraft2 = new MilitaryAircraft("F-16", "12345", 2);
            airport.AddAircraft(aircraft1);
            airport.AddAircraft(aircraft2);

            // Act
            Aircraft? foundAircraft = airport.FindAircraft("ABC123");

            // Assert
            Assert.IsNotNull(foundAircraft);
            Assert.AreEqual(aircraft1, foundAircraft);
        }

        [TestMethod]
        public void FindCommercialAircraft_ReturnsCorrectCommercialAircraft()
        {
            // Arrange
            Airport airport = new Airport("New Air", "A000", new GeographicLocation(40.7128, -74.0060, "New York"));
            CommercialAircraft commercialAircraft = new CommercialAircraft("Boeing-737", "ABC123", 150);
            airport.AddAircraft(commercialAircraft);

            // Act
            CommercialAircraft? foundCommercialAircraft = airport.FindCommercialAircraft("ABC123");

            // Assert
            Assert.IsNotNull(foundCommercialAircraft);
            Assert.AreEqual(commercialAircraft, foundCommercialAircraft);
        }

        [TestMethod]
        public void FindMilitaryAircraft_ReturnsCorrectMilitaryAircraft()
        {
            // Arrange
            Airport airport = new Airport("New Air", "A000", new GeographicLocation(40.7128, -74.0060, "New York"));
            MilitaryAircraft militaryAircraft = new MilitaryAircraft("F-16", "12345", 2);
            airport.AddAircraft(militaryAircraft);

            // Act
            MilitaryAircraft? foundMilitaryAircraft = airport.FindMilitaryAircraft("12345");

            // Assert
            Assert.IsNotNull(foundMilitaryAircraft);
            Assert.AreEqual(militaryAircraft, foundMilitaryAircraft);
        }
    }
}
