namespace Model_Tests
{
    [TestClass]
    [TestCategory("ModelTests")]
    public class GeographicLocationTests
    {
        [TestMethod]
        public void ConstructorSetsPropertiesCorrectly()
        {
            // Arrange
            double latitude = 40.7128;
            double longitude = -74.0060;
            string address = "New York, NY";

            // Act
            GeographicLocation location = new GeographicLocation(latitude, longitude, address);

            // Assert
            Assert.AreEqual(latitude, location.Latitude);
            Assert.AreEqual(longitude, location.Longitude);
            Assert.AreEqual(address, location.Address);
        }

        [TestMethod]
        public void ToStringReturnsFormattedString()
        {
            // Arrange
            double latitude = 34.0522;
            double longitude = -118.2437;
            string address = "Los Angeles, CA";
            GeographicLocation location = new GeographicLocation(latitude, longitude, address);

            // Act
            string locationString = location.ToString();

            // Assert
            StringAssert.Contains(locationString, $"{latitude}");
            StringAssert.Contains(locationString, $"{longitude}");
            StringAssert.Contains(locationString, $"{address}");
        }
    }
}