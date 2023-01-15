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

        //private DataFileSaver databaseService = new DataFileSaver();
        //private GalaxyDao galaxyDao = new GalaxyDao();
        //private DataGenerator dataGenerator = new DataGenerator();
        //private DataFileSaver dataFileSaver = new DataFileSaver();

        public MainWindow()
        {
            InitializeComponent();
        }

        // Simple example of data handling in the application (modification, loading and saving)
        /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Initialize ids data
            dataFileSaver.SaveToFile(1, "ids");

            // Generate galaxy
            Galaxy generatedGalaxy = dataGenerator.GenerateGalaxy();
            
            // Save galaxy
            galaxyDao.SaveGalaxy(generatedGalaxy);

            // Load saved galaxy and perform some basic operations on its objects
            galaxyDao.LoadData();

            // Get Milky Way
            Galaxy galaxy = galaxyDao.GetGalaxy(1);

            // Get Sun
            var star = galaxy.GetStar(2);

            // Remove Solar System
            star.RemovePlanetarySystem(3);

            // Create new Solar System and add it to Sun
            PlanetarySystem solarSystem = new PlanetarySystem(
                "Solar system new",
                UnitValue<long>.Of(130_000, Unit.KM),
                UnitValue<long>.Of(200_000_000, Unit.KM),
                UnitValue<double>.Of(1, Unit.MAGNITUDE),
                new Declination(10, 5, 1),
                new RightAscension(5, 3, 12)
            );
            star.AddPlanetarySystem(solarSystem);

            // Save data
            GlobalIdentificatorProvider.GetInstance().Save();
            galaxyDao.SaveGalaxy(galaxy);

            // You can check if data.json has proper data
            MessageBox.Show("Ok");

            // Remember to remove data.json and ids.json if you want to run this code again.
        }*/
    }
}
