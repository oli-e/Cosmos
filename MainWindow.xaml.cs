using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Cosmos
{
    public partial class MainWindow : Window
    {

        private DatabaseService databaseService = new DatabaseService();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Planet earth = new Planet(
                "Earth",
                new UnitValue<long>(100, Unit.KM),
                new UnitValue<double>(0.1, Unit.SUN_MASS),
                new UnitValue<long>(0, Unit.KM));
            Moon moon = new Moon(
                "Moon",
                new UnitValue<long>(100, Unit.KM),
                new UnitValue<double>(0.1, Unit.SUN_MASS),
                new UnitValue<long>(0, Unit.KM),
                new UnitValue<long>(400, Unit.KM)
                );
            earth.AddMoon(moon);

            databaseService.SavePlanet(earth);
            databaseService.SaveToFile();

            List<Planet> planets = databaseService.LoadFromFile();

            MessageBox.Show("Ok");
        }
    }
}
