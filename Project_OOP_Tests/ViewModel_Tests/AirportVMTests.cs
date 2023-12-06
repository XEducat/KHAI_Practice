using Project_OOP.Interfaces;
using Project_OOP.Models;
using Project_OOP.Moldels.Aircrafts;
using Project_OOP.ViewModels;
using System;

namespace ViewModel_Tests
{
    [TestClass]
    public class AirportVMTests
    {
        [TestMethod]
        public void ConstructorSetsAirportAndAircraftsCorrectly()
        {
            // Arrange
            Airport airport = new Airport("Test Airport", "TST", new GeographicLocation(0, 0, "Test City"));

            // Act
            AirportVM airportVM = new AirportVM(airport);

            // Assert
            Assert.IsNotNull(airportVM.airport);
            Assert.AreEqual(airport, airportVM.airport);
            Assert.IsNotNull(airportVM.Aircrafts);
            CollectionAssert.AreEqual(airport.aircrafts, airportVM.Aircrafts);
        }

        [TestMethod]
        public void GetAirportInfoReturnsCorrectString()
        {
            // Arrange
            Airport airport = new Airport("Test-Airport", "TST", new GeographicLocation(0, 0, "Test City"));
            AirportVM airportVM = new AirportVM(airport);

            // Act
            string result = airportVM.GetAirportInfo();

            // Assert
            string expected = "0°, 0°\nTest City\nTST";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetAirportNameReturnsCorrectName()
        {
            // Arrange
            Airport airport = new Airport("Test Airport", "TST", new GeographicLocation(0, 0, "Test City"));
            AirportVM airportVM = new AirportVM(airport);

            // Act
            string result = airportVM.GetAirportName();

            // Assert
            Assert.AreEqual("Test Airport", result);
        }

        [TestMethod]
        public void AddAircraftAddsAircraftToAirportAndAircrafts()
        {
            // Arrange
            Airport airport = new Airport("Test Airport", "TST", new GeographicLocation(0, 0, "Test City"));
            AirportVM airportVM = new AirportVM(airport);
            Aircraft newAircraft = new CommercialAircraft("New-Aircraft", "NA001", 12);

            // Act
            airportVM.AddAircraft(newAircraft);

            // Assert
            Assert.IsTrue(airport.aircrafts.Contains(newAircraft));
            CollectionAssert.Contains(airportVM.Aircrafts, newAircraft);
        }

        [TestMethod]
        public void RemoveAircraftRemovesAircraftFromAirportAndAircrafts()
        {
            // Arrange
            Airport airport = new Airport("Test Airport", "TST", new GeographicLocation(0, 0, "Test City"));
            Aircraft aircraftToRemove = new CommercialAircraft("To-Remove", "TR001", 12);
            airport.AddAircraft(aircraftToRemove);
            AirportVM airportVM = new AirportVM(airport);

            // Act
            airportVM.RemoveAircraft(aircraftToRemove);

            // Assert
            Assert.IsFalse(airport.aircrafts.Contains(aircraftToRemove));
            CollectionAssert.DoesNotContain(airportVM.Aircrafts, aircraftToRemove);
        }

        [TestMethod]
        public void GetAircraftsReturnsAircraftList()
        {
            // Arrange
            Airport airport = new Airport("Test Airport", "TST", new GeographicLocation(0, 0, "Test City"));
            AirportVM airportVM = new AirportVM(airport);

            // Act
            var result = airportVM.GetAircrafts();

            // Assert
            CollectionAssert.AreEqual(airport.aircrafts, result);
        }

        [TestMethod]
        public void FindAircraftReturnsCorrectAircraft()
        {
            // Arrange
            Airport airport = new Airport("Test Airport", "TST", new GeographicLocation(0, 0, "Test City"));
            AirportVM airportVM = new AirportVM(airport);
            Aircraft targetAircraft = new CommercialAircraft("Target-Aircraft", "TA001", 12);
            airport.AddAircraft(targetAircraft);

            // Act
            var result = airportVM.FindAircraft("TA001");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(targetAircraft, result);
        }
    }
}
