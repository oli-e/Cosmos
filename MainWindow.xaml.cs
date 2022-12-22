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
        private DataGenerator dataGenerator = new DataGenerator();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Galaxy galaxy = dataGenerator.GenerateGalaxy();

            databaseService.SaveGalaxy(galaxy);
            databaseService.SaveToFile();

            List<Galaxy> galaxies = databaseService.LoadFromFile();

            MessageBox.Show("Ok");
        }
    }
}
