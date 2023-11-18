using Project_OOP.Moldels;
using Project_OOP.Moldels.Crews;

namespace Crew_Tests
{
    [TestClass]
    public class CommercialCrewTests
    {
        [TestMethod]
        public void ConstructorSetsPropertiesCorrectly()
        {
            // Arrange
            Pilot captain = new Pilot("John Doe", 40, 20);
            Pilot firstPilot = new Pilot("Jane Doe", 35, 15);
            Pilot secondPilot = new Pilot("Bob Smith", 30, 10);

            // Act
            CommercialCrew commercialCrew = new CommercialCrew(captain, firstPilot, secondPilot);

            // Assert
            Assert.AreEqual(captain, commercialCrew.Captain);
            Assert.AreEqual(firstPilot, commercialCrew.FirstPilot);
            Assert.AreEqual(secondPilot, commercialCrew.SecondPilot);
            Assert.AreEqual(3, commercialCrew.Membership);
        }

        [TestMethod]
        public void ConstructorSetsPropertiesCorrectlyWithNullSecondPilot()
        {
            // Arrange
            Pilot captain = new Pilot("John Doe", 40, 20);
            Pilot firstPilot = new Pilot("Jane Doe", 35, 15);

            // Act
            CommercialCrew commercialCrew = new CommercialCrew(captain, firstPilot);

            // Assert
            Assert.AreEqual(captain, commercialCrew.Captain);
            Assert.AreEqual(firstPilot, commercialCrew.FirstPilot);
            Assert.IsNull(commercialCrew.SecondPilot);
            Assert.AreEqual(2, commercialCrew.Membership);
        }
    }
}
