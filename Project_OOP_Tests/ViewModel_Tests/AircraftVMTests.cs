using Project_OOP.Interfaces;
using Project_OOP.Models.Persons;
using Project_OOP.Moldels.Aircrafts;
using Project_OOP.Moldels;
using Project_OOP.ViewModels;
using Project_OOP.Enums;

namespace ViewModel_Tests
{
    [TestClass]
    [TestCategory("ViewModelTests")]
    public class AircraftVMTests
    {
        [TestMethod]
        public void CreatePerson_AddPassengerToList()
        {
            // Arrange
            AircraftVM aircraftVM = new AircraftVM();
            Passenger passenger = new Passenger("Bob", 15, "#001");

            // Act
            aircraftVM.Persons.Add(passenger);

            // Assert
            Assert.AreEqual(1, aircraftVM.Persons.Count);
            Assert.IsInstanceOfType(aircraftVM.Persons[0], typeof(Passenger));
        }

        [TestMethod]
        public void CreatePerson_AddPilotToList()
        {
            // Arrange
            AircraftVM aircraftVM = new AircraftVM();
            Pilot pilot = new Pilot("Rocksted", 26, 4, PersonalRole.SecondPilot);

            // Act
            aircraftVM.Persons.Add(pilot);

            // Assert
            Assert.AreEqual(1, aircraftVM.Persons.Count);
            Assert.IsInstanceOfType(aircraftVM.Persons[0], typeof(Pilot));
        }

        [TestMethod]
        public void CreateAircraft_CreateCommercialAircraft()
        {
            // Arrange
            AircraftVM aircraftVM = new AircraftVM();
            Pilot captin = new Pilot("Rocksted", 35, 10, PersonalRole.Captain);
            Pilot pilot = new Pilot("Mary", 26, 4, PersonalRole.FirstPilot);
            aircraftVM.Persons.Add(captin);
            aircraftVM.Persons.Add(pilot);

            // Act
            Aircraft? newAircraft = aircraftVM.CreateAircraft("Комерційний літак", "Boeing", "ABC123", 150);

            // Assert
            Assert.IsNotNull(newAircraft);
            Assert.IsInstanceOfType(newAircraft, typeof(CommercialAircraft));
            CommercialAircraft commercialAircraft = (CommercialAircraft)newAircraft;
            Assert.AreEqual("Boeing", commercialAircraft.Model);
            Assert.AreEqual("ABC123", commercialAircraft.Number);
            Assert.AreEqual(150, commercialAircraft.NumberOfSeats);
            Assert.AreEqual(2, commercialAircraft.passengerTrain.Count);
            Assert.IsInstanceOfType(commercialAircraft.passengerTrain[0], typeof(Pilot));
        }

        [TestMethod]
        public void CreateAircraft_ThrowsExceptionIfNotReadyForFlight()
        {
            // Arrange
            AircraftVM aircraftVM = new AircraftVM();
            Pilot pilot = new Pilot("Rocksted", 26, 4, PersonalRole.SecondPilot);
            aircraftVM.Persons.Add(pilot);

            // Act & Assert
            Assert.ThrowsException<Exception>(() => aircraftVM.CreateAircraft("Комерційний літак", "Boeing", "ABC123", 150));
        }

        [TestMethod]
        public void GetAircraftTypes_ReturnsCorrectList()
        {
            // Arrange
            AircraftVM aircraftVM = new AircraftVM();

            // Act
            List<string> aircraftTypes = aircraftVM.GetAircraftTypes();

            // Assert
            Assert.IsNotNull(aircraftTypes);
            CollectionAssert.Contains(aircraftTypes, "Комерційний літак");
            CollectionAssert.Contains(aircraftTypes, "Військовий літак");
        }

        [TestMethod]
        public void GetPersonTypes_ReturnsCorrectList()
        {
            // Arrange
            AircraftVM aircraftVM = new AircraftVM();

            // Act
            List<string> personTypes = aircraftVM.GetPersonTypes();

            // Assert
            Assert.IsNotNull(personTypes);
            CollectionAssert.Contains(personTypes, "Пасажир");
            CollectionAssert.Contains(personTypes, "Пілот");
        }

        [TestMethod]
        public void GetDisplayNames_ReturnsCorrectList()
        {
            // Arrange
            AircraftVM aircraftVM = new AircraftVM();

            // Act
            List<string> displayNames = aircraftVM.GetDisplayNames(typeof(Person));

            // Assert
            Assert.IsNotNull(displayNames);
            CollectionAssert.Contains(displayNames, "Пасажир");
            CollectionAssert.Contains(displayNames, "Пілот");
        }
    }
}