using Project_OOP;
using Project_OOP.Models.Persons;
using Project_OOP.Moldels;
using Project_OOP.Moldels.Aircrafts;

namespace Aircraft_Tests
{
    [TestClass]
    public class MilitaryAircraftTests
    {
        [TestMethod]
        public void ConstructorWithCrewSetsPropertiesCorrectly()
        {
            // Arrange
            List<Person> crew = new List<Person>
            {
                new Pilot("John Doe", 38, 15, PersonalRole.Captain),
                new Pilot("Jane Doe", 35, 10, PersonalRole.FirstPilot)
            };

            string model = "F-16";
            string number = "12345";
            int numberOfSeats = 20;

            // Act
            MilitaryAircraft militaryAircraft = new MilitaryAircraft(model, number, numberOfSeats, crew);

            // Assert
            Assert.AreEqual(model, militaryAircraft.Model);
            Assert.AreEqual(number, militaryAircraft.Number);
            Assert.AreEqual(numberOfSeats, militaryAircraft.NumberOfSeats);
            CollectionAssert.AreEqual(crew, militaryAircraft.getCrew());
        }

        [TestMethod]
        public void ConstructorWithoutCrewSetsPropertiesCorrectly()
        {
            // Arrange
            string model = "F-16";
            string number = "12345";
            int numberOfSeats = 2;

            // Act
            MilitaryAircraft militaryAircraft = new MilitaryAircraft(model, number, numberOfSeats);

            // Assert
            Assert.AreEqual(model, militaryAircraft.Model);
            Assert.AreEqual(number, militaryAircraft.Number);
            Assert.AreEqual(numberOfSeats, militaryAircraft.NumberOfSeats);
            Assert.AreEqual(0, militaryAircraft.passengerTrain.Count);
        }

        [TestMethod]
        public void SetCrew_SetsCrewCorrectly()
        {
            // Arrange
            MilitaryAircraft militaryAircraft = new MilitaryAircraft("F-16", "12345", 2);
            List<Person> crew = new List<Person>
            {
                new Pilot("John Doe", 38, 15, PersonalRole.Captain),
                new Pilot("Jane Doe", 35, 10, PersonalRole.FirstPilot)
            };

            // Act
            militaryAircraft.setCrew(crew);

            // Assert
            CollectionAssert.AreEqual(crew, militaryAircraft.getCrew());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Екіпаж повинен мати капітана та першого пілота.")]
        public void SetCrew_ThrowsExceptionForInvalidCrew()
        {
            // Arrange
            MilitaryAircraft militaryAircraft = new MilitaryAircraft("F-16", "12345", 2);
            List<Person> invalidCrew = new List<Person>
            {
                new Pilot("John Doe", 38, 15, PersonalRole.Captain),
                new Passenger("Jane Doe", 25, "#0001")
            };

            // Act & Assert
            militaryAircraft.setCrew(invalidCrew);
        }
    }
}
