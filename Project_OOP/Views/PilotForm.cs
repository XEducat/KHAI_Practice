using Project_OOP.Models.Persons;
using Project_OOP.ViewModels;


namespace Project_OOP.Views
{
    public partial class PilotForm : Form
    {
        private readonly PilotVM pilotViewModel;

        public event EventHandler<PersonCreatedEventArgs>? OnPilotCreated;

        public PilotForm()
        {
            InitializeComponent();
            pilotViewModel = new PilotVM();
            InitializeBindings();
        }

        // Прив'язка властивостей текстових полів до відповідних властивостей PilotVM
        private void InitializeBindings()
        {
            txtPilotName.DataBindings.Add("Text", pilotViewModel, nameof(pilotViewModel.PilotName));
            txtPilotAge.DataBindings.Add("Text", pilotViewModel, nameof(pilotViewModel.PilotAge));
            txtPilotExperience.DataBindings.Add("Text", pilotViewModel, nameof(pilotViewModel.PilotExperience));
            cbxPilotRole.DataBindings.Add("SelectedItem", pilotViewModel, nameof(pilotViewModel.SelectedPilotRole));
            cbxPilotRole.DataSource = pilotViewModel.PilotRoles;
        }

        // Обробка нажаття на кнопку стоврення пілота
        private void btnCreatePilot_Click(object sender, EventArgs e)
        {
            if (pilotViewModel.FieldsNotEmpty)
            {
                try
                {
                    Pilot pilot = pilotViewModel.GetPilot();

                    OnPilotCreated?.Invoke(this, new PersonCreatedEventArgs(pilot));

                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    NotificationService.SendError(ex.Message);
                }
            }
            else
            {
                NotificationService.SendError("Ви не заповнили всі поля для створення члена пасажирського складу.");
            }
        }

        // Перевірка, чи введене число перевищує 140
        private void txbAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            string newText = textBox.Text + e.KeyChar;

            if (int.TryParse(newText, out int value) && value > 140)
            {
                e.Handled = true;
            }
        }

        // Перевірка, чи введене число перевищує 80
        private void txbExpirience_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            string newText = textBox.Text + e.KeyChar;

            if (int.TryParse(newText, out int value) && value > 80)
            {
                e.Handled = true;
            }
        }

        // -- #CAN BE MOVE IN TRASH --
        //private bool isValidDigit(string newText, char addedChar)         
        //{
        //    if (!char.IsControl(addedChar) && !char.IsDigit(addedChar))
        //    {
        //        return false;
        //    }
        //    else if(int.TryParse(newText, out int value) && value > 140)   // Перевірка, чи введене число перевищує 140
        //    {
        //        return false;
        //    }

        //    return true;
        //}
    }
}