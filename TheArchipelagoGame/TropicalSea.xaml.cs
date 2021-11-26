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
using System.Windows.Threading;

namespace TheArchipelagoGame
{
    /// <summary>
    /// Interaction logic for TropicalSea.xaml
    /// </summary>
    public partial class TropicalSea : Page
    {
        public TropicalSea()
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
                   
                    IslandDescription.Visibility = Visibility.Visible;
                    IslandName.Content = MainWindow.game.CurrentIsland.Name;
                    IslandDescription.Content = MainWindow.game.CurrentIsland.Description;
                    ContinueButton.Visibility = Visibility.Visible;
                    BackButton.Visibility = Visibility.Visible;
                    break;

                case "Option2":
                    //Cowboy Island
                    MainWindow.game.CurrentIsland = MainWindow.game.Islands[1];
                  
                    IslandDescription.Visibility = Visibility.Visible;
                    IslandName.Content = MainWindow.game.CurrentIsland.Name;
                    IslandDescription.Content = MainWindow.game.CurrentIsland.Description;
                    ContinueButton.Visibility = Visibility.Visible;
                    BackButton.Visibility = Visibility.Visible;
                    break;

                case "Option3":
                    //Fantasy Island
                    MainWindow.game.CurrentIsland = MainWindow.game.Islands[2];
                  
                    IslandDescription.Visibility = Visibility.Visible;
                    IslandName.Content = MainWindow.game.CurrentIsland.Name;
                    IslandDescription.Content = MainWindow.game.CurrentIsland.Description;
                    ContinueButton.Visibility = Visibility.Visible;
                    BackButton.Visibility = Visibility.Visible;
                    break;
            }
            
        }

        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
            
            NavigationService.Navigate(new Uri("Location.xaml", UriKind.Relative));
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            BackButton.Visibility = Visibility.Hidden;
            IslandName.Content = "Choose an Island";
            IslandDescription.Visibility = Visibility.Hidden;
            ContinueButton.Visibility= Visibility.Hidden;

        }
    }
}


