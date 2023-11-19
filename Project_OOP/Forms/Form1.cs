namespace Project_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GeographicLocation geo = new GeographicLocation(70.90, 45.209, "LA San Marino");
            string geoString = geo.ToString();
        }
    }
}