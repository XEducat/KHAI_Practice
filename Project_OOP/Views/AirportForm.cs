using Project_OOP.Forms;
using Project_OOP.Interfaces;
using Project_OOP.Models;
using Project_OOP.ViewModels;
using System.ComponentModel;


namespace Project_OOP
{
    public partial class AirportForm : Form
    {
        private AirportVM airportViewModel;

        public AirportForm(Airport airport)
        {
            InitializeComponent();

            this.airportViewModel = new AirportVM(airport);
        }

        private void AirportForm_Load(object sender, EventArgs e)
        {
            SetupLabels();
            SetupDataGridView();
        }


        private void SetupLabels()
        {
            lblAirportName.Text = airportViewModel.GetAirportName();
            lblAirportInfoAboout.Text = airportViewModel.GetAirportInfo();
        }

        private void SetupDataGridView()
        {
            // ������������ ��� ������� �����䳿
            dataGridView.AutoGenerateColumns = false;
            dataGridView.CellContentClick += dataGridView_CellContentClick;

            dataGridView.DataSource = airportViewModel.Aircrafts;
            dataGridView.Columns["Model"].DataPropertyName = "Model";
            dataGridView.Columns["Number"].DataPropertyName = "Number";
            dataGridView.Columns["NumberOfSeats"].DataPropertyName = "NumberOfSeats";
        }


        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.Columns["Type"].Index && e.RowIndex >= 0)
            {
                var data = dataGridView.Rows[e.RowIndex].DataBoundItem;

                if (data != null)
                {
                    var objectType = data.GetType();
                    var displayNameAttribute = (DisplayNameAttribute?)objectType.GetCustomAttributes(typeof(DisplayNameAttribute), true).FirstOrDefault();

                    if (displayNameAttribute != null)
                    {
                        e.Value = displayNameAttribute.DisplayName;
                        e.FormattingApplied = true;
                    }
                }
            }
        }


        // ���������� �� ������ � �������
        private void dataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView.Columns[3].Index)
            {
                //// ��������� ��� � ��������� �����
                var data = dataGridView.Rows[e.RowIndex].DataBoundItem as Aircraft;

                Aircraft? aircraft = airportViewModel.FindAircraft(data.Number);

                // TODO ������� ������ ���� ��� ��������� ������������� ������
                MessageBox.Show(aircraft?.ToString());
            }
        }


        private void AddAircraft(object sender, EventArgs e)
        {
            AircraftForm form = airportViewModel.ShowAircraftForm();
            form.FormClosed += (sender, e) => Show();
            this.Hide();
        }

        private void RemoveAircraft(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0)
            {
                // �������� ���� � DataGridView
                var selectedAircraft = dataGridView.SelectedRows[0].DataBoundItem as Aircraft;

                if (selectedAircraft != null)
                {
                    airportViewModel.RemoveAircraft(selectedAircraft);
                }
            }
        }
    }
}