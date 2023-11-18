using Project_OOP.Moldels;
using Project_OOP.Moldels.Crews;

namespace Crew_Tests
{
    [TestClass]
    public class MilitaryCrewTests
    {
        [TestMethod]
        public void ConstructorSetsPropertiesCorrectly()
        {
            // Arrange
            Pilot pilot = new Pilot("John Doe", 38, 15);
            Pilot secondPilot = new Pilot("Jane Doe", 35, 10);

            // Act
            MilitaryCrew militaryCrew = new MilitaryCrew(pilot, secondPilot);

            // Assert
            Assert.AreEqual(pilot, militaryCrew.Pilot);
            Assert.AreEqual(secondPilot, militaryCrew.SecondPilot);
            Assert.AreEqual(2, militaryCrew.Membership);
        }
    }
}
