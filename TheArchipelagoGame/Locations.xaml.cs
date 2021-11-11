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

namespace TheArchipelagoGame
{
    /// <summary>
    /// Interaction logic for Locations.xaml
    /// </summary>
    public partial class Locations : Page
    {
        public Locations()
        {
            InitializeComponent();
            
            
            Option1.Content = MainWindow.game.Islands[0].Name;
            Option2.Content = MainWindow.game.Islands[1].Name;
            Option3.Content = MainWindow.game.Islands[2].Name;
            
        }  


        private void NavigateButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string itemName = String.Empty;
            switch (button.Name)
            {
                case "Option1":
                    //Pirate Island
                    MainWindow.game.CurrentIsland = MainWindow.game.Islands[0];
                    break;
                case "Option2":
                    //Cowboy Island
                    MainWindow.game.CurrentIsland = MainWindow.game.Islands[1];
                    break;
                case "Option3":
                    //Fantasy Island
                    MainWindow.game.CurrentIsland = MainWindow.game.Islands[2];
                    break;
                default:
                    break;
            }
        }
    }
}
