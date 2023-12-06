using Project_OOP.Interfaces;
using Project_OOP.Moldels;
using Project_OOP.ViewModels;
using System.Data;


namespace Project_OOP.Forms
{
    public partial class AircraftForm : Form
    {
        private AirportVM airportViewModel;
        private AircraftVM aircraftViewModel;

        private Dictionary<string, Type> personTypeDictionary = new Dictionary<string, Type>();

        public AircraftForm(AirportVM airportViewModel)
        {
            InitializeComponent();

            this.airportViewModel = airportViewModel;
            this.aircraftViewModel = new AircraftVM();

            SetupDataGridView();
            SetupComboBoxes();
        }

        private void SetupComboBoxes()
        {
            SetComboBoxDataSource(cbxAircraftTypes, typeof(Aircraft));
            SetComboBoxDataSource(cbxPersonTypes, typeof(Person));
        }

        // Прив'язка даних з dataGridView1
        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = aircraftViewModel.Persons;
            dataGridView1.Columns["PersonName"].DataPropertyName = "Name";
            dataGridView1.Columns["Age"].DataPropertyName = "Age";
            dataGridView1.Columns["DisplayRole"].DataPropertyName = "DisplayRole";
        }


        private void SetComboBoxDataSource(ComboBox comboBox, Type baseType)
        {
            var allowedTypes = aircraftViewModel.GetDerivedTypes(baseType);
            PopulateComboBoxWithTypes(comboBox, allowedTypes);
        }


        private void SetComboBoxDataSource(ComboBox comboBox, List<Type> allowedTypes)
        {
            PopulateComboBoxWithTypes(comboBox, allowedTypes);
        }


        private void PopulateComboBoxWithTypes(ComboBox comboBox, List<Type> types)
        {
            var displayNames = types.Select(type =>
            {
                var displayName = aircraftViewModel.GetDisplayName(type);
                personTypeDictionary[displayName] = type;
                return displayName;
            }).ToList();

            comboBox.DataSource = displayNames;
        }


        private void CreatePerson(object sender, EventArgs e)
        {
            string selectedPersonDisplayName = cbxPersonTypes.SelectedItem as string;

            if (selectedPersonDisplayName != null && personTypeDictionary.TryGetValue(selectedPersonDisplayName, out Type selectedPersonType))
            {
                aircraftViewModel.CreatePerson(selectedPersonType);
            }
        }


        private void CreateAircraft(object sender, EventArgs e)
        {
            string model = txbModel.Text.Trim();
            string number = txbNumber.Text.Trim();
            string numberOfSeatsText = txbNumberOfSeats.Text.Trim();

            if (string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(number) || string.IsNullOrWhiteSpace(numberOfSeatsText))
            {
                NotificationService.SendWarrning(
                    "Ви не заповнили всі поля для створення літаку. \n\n" +
                    "Передивіться такі поля як: Модель, Номер, Кількість місць та Тип літаку.");
                return;
            }

            if (!int.TryParse(numberOfSeatsText, out int numberOfSeats))
            {
                NotificationService.SendWarrning("Некоректний формат кількості місць");
                return;
            }

            string? selectedType = cbxAircraftTypes.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(selectedType))
            {
                NotificationService.SendWarrning("Оберіть тип літаку будь ласка");
                return;
            }

            try
            {
                Aircraft? newAircraft = aircraftViewModel.CreateAircraft(selectedType, model, number, numberOfSeats);

                if (newAircraft != null)
                    airportViewModel.AddAircraft(newAircraft);

                this.Close();
            }
            catch (Exception ex)
            {
                NotificationService.SendWarrning(ex.Message);
            }
        }

        // Дозволяємо тільки цифри та клавіші Backspace
        private void txbNumberOfSeats_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Новий текст, який отримається при додаванні нового символу
            string newText = ((TextBox)sender).Text + e.KeyChar;

            // Перевірка, чи введене число перевищує 100
            if (int.TryParse(newText, out int value) && value > 250)
            {
                e.Handled = true;
            }
        }

        private void cbxAircraftTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            aircraftViewModel.Persons.Clear();

            Type? selectedAircraftType = aircraftViewModel.GetDerivedTypeAtIndex(typeof(Aircraft), cbxAircraftTypes.SelectedIndex);

            if (selectedAircraftType != null)
            {
                Aircraft? aircraftInstance = (Aircraft?)Activator.CreateInstance(selectedAircraftType, "Model", "13556", 10);

                if (aircraftInstance != null)
                {
                    List<Type> allowedPersonTypes = aircraftViewModel.GetDerivedTypes(typeof(Person))
                        .Where(type => !aircraftInstance.DisallowedPersonTypes.Contains(type))
                        .ToList();

                    SetComboBoxDataSource(cbxPersonTypes, allowedPersonTypes);
                }
                else
                {
                    NotificationService.SendWarrning($"Не вдалося створити екземпляр об'єкту типу {selectedAircraftType}!");
                }
            }
            else
            {
                NotificationService.SendWarrning($"Не вдалося оприділити вибраний тип літака!");
            }
        }
    }
}
