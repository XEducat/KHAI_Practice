using Project_OOP.Moldels;
using Project_OOP.Moldels.Aircrafts;
using Project_OOP.Moldels.Crews;

namespace Aircraft_Tests
{
    [TestClass]
    public class MilitaryAircraftTests
    {
        [TestMethod]
        public void ConstructorWithCrewSetsPropertiesCorrectly()
        {
            // Arrange
            MilitaryCrew crew = new MilitaryCrew(new Pilot("John Doe", 38, 15), new Pilot("Jane Doe", 35, 10));
            string model = "F-16";
            string number = "12345";
            int numberOfSeats = 20;

            // Act
            MilitaryAircraft militaryAircraft = new MilitaryAircraft(crew, model, number, numberOfSeats);

            // Assert
            Assert.AreEqual(model, militaryAircraft.Model);
            Assert.AreEqual(number, militaryAircraft.Number);
            Assert.AreEqual(numberOfSeats, militaryAircraft.NumberOfSeats);
            Assert.AreEqual(crew, militaryAircraft.getCrew());
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
            Assert.IsNull(militaryAircraft.getCrew());
        }

        [TestMethod]
        public void SetCrew_SetsCrewCorrectly()
        {
            // Arrange
            MilitaryAircraft militaryAircraft = new MilitaryAircraft("F-16", "12345", 2);
            MilitaryCrew crew = new MilitaryCrew(new Pilot("John Doe", 38, 15), new Pilot("Jane Doe", 35, 10));

            // Act
            militaryAircraft.setCrew(crew);

            // Assert
            Assert.AreEqual(crew, militaryAircraft.getCrew());
        }
    }
}
