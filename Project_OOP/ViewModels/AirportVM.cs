using Project_OOP.Forms;
using Project_OOP.Interfaces;
using Project_OOP.Models;
using System.ComponentModel;

namespace Project_OOP.ViewModels
{
    public class AirportVM
    {
        public Airport airport;
        public BindingList<Aircraft> Aircrafts;

        //public event EventHandler? OnAircraftAdded;       -- #CAN BE MOVE IN TRASH --
        //public event EventHandler? OnAircraftRemoved;     -- #CAN BE MOVE IN TRASH --

        public AirportVM(Airport airport)
        {
            this.airport = airport;

            Aircrafts = new BindingList<Aircraft>(airport.aircrafts);
        }

        public string GetAirportInfo()
        {
            return airport.Location.ToString() + "\n" + airport.Code;
        }

        public string GetAirportName()
        {
            return airport.Name;
        }

        public void AddAircraft(Aircraft newAircraft)
        {
            airport.AddAircraft(newAircraft);
            Aircrafts.ResetBindings();

            //OnAircraftAdded?.Invoke(this, EventArgs.Empty);     #Can be move in trash
        }

        public void RemoveAircraft(Aircraft aircraftToRemove)
        {
            // Реалізуйте логіку видалення літаку з даних моделі
            airport.RemoveAircraft(aircraftToRemove);
            Aircrafts.ResetBindings();

            //OnAircraftRemoved?.Invoke(this, EventArgs.Empty);   #Can be move in trash
        }

        public List<Aircraft> GetAircrafts()
        {
            return airport.aircrafts;
        }

        public Aircraft? FindAircraft(string number)
        {
            return airport.FindAircraft(number);
        }

        public AircraftForm ShowAircraftForm()
        {
            AircraftForm aircraftForm = new AircraftForm(this);
            aircraftForm.Show();

            return aircraftForm;
        }
    }
}