using Project_OOP.Moldels;
using Project_OOP.Moldels.Aircrafts;
using Project_OOP.Models.Persons;
using Project_OOP.Enums;

namespace Model_Tests.AircraftTests
{
    [TestClass]
    [TestCategory("ModelTests")]
    public class CommercialAircraftTests
    {
        [TestMethod]
        public void ConstructorWithCrewSetsPropertiesCorrectly()
        {
            // Arrange
            string model = "Boeing-737";
            string number = "ABC123";
            int numberOfSeats = 150;

            List<Person> passengerTrain = new List<Person>() {
                new Pilot("John", 38, 15, PersonalRole.Captain),
                new Pilot("Jane", 35, 10, PersonalRole.FirstPilot),
                new Passenger("Женя", 19, "#0001")
            };

            // Act
            CommercialAircraft commercialAircraft = new CommercialAircraft(model, number, numberOfSeats, passengerTrain);

            // Assert
            Assert.AreEqual(model, commercialAircraft.Model);
            Assert.AreEqual(number, commercialAircraft.Number);
            Assert.AreEqual(numberOfSeats, commercialAircraft.NumberOfSeats);
            CollectionAssert.AreEqual(passengerTrain, commercialAircraft.passengerTrain);
        }

        [TestMethod]
        public void ConstructorWithoutCrewSetsPropertiesCorrectly()
        {
            // Arrange
            string model = "Boeing-737";
            string number = "ABC123";
            int numberOfSeats = 150;

            // Act
            CommercialAircraft commercialAircraft = new CommercialAircraft(model, number, numberOfSeats);

            // Assert
            Assert.AreEqual(model, commercialAircraft.Model);
            Assert.AreEqual(number, commercialAircraft.Number);
            Assert.AreEqual(numberOfSeats, commercialAircraft.NumberOfSeats);
            Assert.AreEqual(0, commercialAircraft.passengerTrain.Count);
        }

        [TestMethod]
        public void GetCrew_ReturnsValidCrew()
        {
            // Arrange
            List<Person> validCrew = new List<Person> // Створюємо колекцію пасажирів
            {
                new Pilot("Jane", 40, 15, PersonalRole.Captain),
                new Pilot("Bane", 35, 10, PersonalRole.FirstPilot)
            };
            List<Person> passengerTrain = new List<Person>(validCrew) // Створюємо колекцію в якій буде наш склад (Пасажири, пілоти тощо. )
            {
                new Passenger("Dan", 30, "A00123"),
                new Passenger("Ivan", 22, "A00124")
            };

            CommercialAircraft commercialAircraft = new CommercialAircraft("Boeing-737", "ABC123", 150, passengerTrain);


            // Act & Assert
            CollectionAssert.AreEquivalent(validCrew, commercialAircraft.getCrew());
        }


        [TestMethod]
        public void SetCrew_SetsValidCrew()
        {
            // Arrange
            CommercialAircraft commercialAircraft = new CommercialAircraft("Boeing-737", "ABC123", 150);

            List<Person> validCrew = new List<Person>
            {
                new Pilot("Captain", 40, 15, PersonalRole.Captain),
                new Pilot("Ban", 35, 10, PersonalRole.FirstPilot)
            };

            // Act
            commercialAircraft.setCrew(validCrew);

            // Assert
            CollectionAssert.AreEquivalent(validCrew, commercialAircraft.getCrew());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SetCrew_ThrowsExceptionForInvalidCrew()
        {
            // Arrange
            CommercialAircraft commercialAircraft = new CommercialAircraft("Airbus", "101", 160);
            List<Person> invalidCrew = new List<Person>
            {
                new Pilot("Captain", 40, 15, PersonalRole.Captain),
                new Passenger("John", 30, "ABC123")
            };

            // Act & Assert
            commercialAircraft.setCrew(invalidCrew);
        }
    }
}
