using Project_OOP.Moldels;
using Project_OOP.Moldels.Aircrafts;
using Project_OOP.Moldels.Crews;

namespace Aircraft_Tests
{
    [TestClass]
    public class CommercialAircraftTests
    {
        [TestMethod]
        public void ConstructorWithCrewSetsPropertiesCorrectly()
        {
            // Arrange
            string model = "Boeing 737";
            string number = "ABC123";
            int numberOfSeats = 150;
            CommercialCrew crew = new CommercialCrew(new Pilot("John Doe", 38, 15), new Pilot("Jane Doe", 35, 10));

            // Act
            CommercialAircraft commercialAircraft = new CommercialAircraft(model, number, numberOfSeats, crew);

            // Assert
            Assert.AreEqual(model, commercialAircraft.Model);
            Assert.AreEqual(number, commercialAircraft.Number);
            Assert.AreEqual(numberOfSeats, commercialAircraft.NumberOfSeats);
            Assert.AreEqual(crew, commercialAircraft.getCrew());
        }

        [TestMethod]
        public void ConstructorWithoutCrewSetsPropertiesCorrectly()
        {
            // Arrange
            string model = "Boeing 737";
            string number = "ABC123";
            int numberOfSeats = 150;

            // Act
            CommercialAircraft commercialAircraft = new CommercialAircraft(model, number, numberOfSeats);

            // Assert
            Assert.AreEqual(model, commercialAircraft.Model);
            Assert.AreEqual(number, commercialAircraft.Number);
            Assert.AreEqual(numberOfSeats, commercialAircraft.NumberOfSeats);
            Assert.IsNull(commercialAircraft.getCrew());
        }

        [TestMethod]
        public void SetCrew_SetsCrewCorrectly()
        {
            // Arrange
            CommercialAircraft commercialAircraft = new CommercialAircraft("Boeing 737", "ABC123", 150);
            CommercialCrew crew = new CommercialCrew(new Pilot("John Doe", 38, 15), new Pilot("Jane Doe", 35, 10));

            // Act
            commercialAircraft.setCrew(crew);

            // Assert
            Assert.AreEqual(crew, commercialAircraft.getCrew());
        }

        [TestMethod]
        public void GetPassengers_ReturnsCorrectPassengerList()
        {
            // Arrange
            CommercialAircraft commercialAircraft = new CommercialAircraft("Boeing 737", "ABC123", 150);
            Passenger passenger1 = new Passenger("Passenger1", "#00001");
            Passenger passenger2 = new Passenger("Passenger2", "#00002");

            // Act
            commercialAircraft.addPassenger(passenger1);
            commercialAircraft.addPassenger(passenger2);
            var passengers = commercialAircraft.getPassangers();

            // Assert
            Assert.IsNotNull(passengers);
            Assert.AreEqual(2, passengers.Count);
            CollectionAssert.Contains(passengers, passenger1);
            CollectionAssert.Contains(passengers, passenger2);
        }

        [TestMethod]
        public void AddPassengers_ReturnsCorrectPassengerList()
        {
            // Arrange
            CommercialAircraft commercialAircraft = new CommercialAircraft("Boeing 737", "ABC123", 150);
            Passenger passenger1 = new Passenger("Passenger1", "#00001");
            Passenger passenger2 = new Passenger("Passenger2", "#00002");

            // Act
            commercialAircraft.addPassengers(new List<Passenger> { passenger1, passenger2 });
            var passengers = commercialAircraft.getPassangers();

            // Assert
            Assert.IsNotNull(passengers);
            Assert.AreEqual(2, passengers.Count);
            CollectionAssert.Contains(passengers, passenger1);
            CollectionAssert.Contains(passengers, passenger2);
        }
    }
}
