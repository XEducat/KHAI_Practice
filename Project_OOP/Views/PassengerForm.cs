using Project_OOP.Models.Persons;
using Project_OOP.ViewModels;

namespace Project_OOP.Views
{
    public partial class PassengerForm : Form
    {
        public event EventHandler<PersonCreatedEventArgs>? OnPassengerCreated;

        public PassengerForm()
        {
            InitializeComponent();
        }

        // Обробка натискання на кноку створення пасажиру
        private void buttonCreatePassanger_Pressed(object sender, EventArgs e)
        {
            string name = txbName.Text.Trim();
            string ageText = txbAge.Text.Trim();
            string ticketNumber = txTicketNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                NotificationService.SendError("Введіть ім'я пасажира.");
                return;
            }

            if (!int.TryParse(ageText, out int age))
            {
                NotificationService.SendError("Введіть число будь ласка в поле віку");
                return;
            }

            if (string.IsNullOrWhiteSpace(ticketNumber))
            {
                NotificationService.SendError("Введіть номер білета пасажира.");
                return;
            }

            try
            {
                // Створення пасажира та сповіщення про створення через подію
                Passenger passenger = new Passenger(name, age, ticketNumber);
                OnPassengerCreated?.Invoke(this, new PersonCreatedEventArgs(passenger));

                // Закриття форми після успішного створення пасажира
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException ex)
            {
                NotificationService.SendWarrning(ex.Message);
            }
            catch (Exception ex)
            {
                NotificationService.SendError(ex.Message);
            }
        }
    }
}
