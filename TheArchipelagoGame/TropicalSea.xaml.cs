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
            Option4.Content = MainWindow.game.Islands[3].Name;

            END();


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
                    IslandDescriptionBackground.Visibility = Visibility.Visible;
                    IslandName.Content = MainWindow.game.CurrentIsland.Name;
                    IslandDescription.Text = MainWindow.game.CurrentIsland.Description;
                    ContinueButton.Visibility = Visibility.Visible;
                    BackButton.Visibility = Visibility.Visible;
                    break;

                case "Option2":
                    //Cowboy Island
                    MainWindow.game.CurrentIsland = MainWindow.game.Islands[1];

                    IslandDescription.Visibility = Visibility.Visible;
                    IslandDescriptionBackground.Visibility = Visibility.Visible;
                    IslandName.Content = MainWindow.game.CurrentIsland.Name;
                    IslandDescription.Text = MainWindow.game.CurrentIsland.Description;
                    ContinueButton.Visibility = Visibility.Visible;
                    BackButton.Visibility = Visibility.Visible;
                    break;

                case "Option3":
                    //Fantasy Island
                    MainWindow.game.CurrentIsland = MainWindow.game.Islands[2];

                    IslandDescription.Visibility = Visibility.Visible;
                    IslandDescriptionBackground.Visibility = Visibility.Visible;
                    IslandName.Content = MainWindow.game.CurrentIsland.Name;
                    IslandDescription.Text = MainWindow.game.CurrentIsland.Description;
                    ContinueButton.Visibility = Visibility.Visible;
                    BackButton.Visibility = Visibility.Visible;
                    break;

                case "Option4":
                    //PartyIsland
                    MainWindow.game.CurrentIsland = MainWindow.game.Islands[3];
                    IslandName.Visibility = Visibility.Hidden;
                    NavigationService.Navigate(new Uri("Location.xaml", UriKind.Relative));
                    break;

            }
        }
            

            private void END()
            {

                string requiredItems = MainWindow.game.Item[0].Name;
                string requiredItemsTwo = MainWindow.game.Item[1].Name;
                if (MainWindow.game.player.SearchInventory(requiredItems) && MainWindow.game.player.SearchInventory(requiredItemsTwo))
                {
                    Option1.Visibility = Visibility.Hidden;
                    Option2.Visibility = Visibility.Hidden;
                    Option3.Visibility = Visibility.Hidden;
                    Option4.Visibility = Visibility.Visible;
                    SideBar.Visibility = Visibility.Hidden;
                    JoinTitle.Visibility = Visibility.Visible;
                    IslandName.Visibility = Visibility.Hidden;
                    QuestButton.Visibility = Visibility.Hidden;

                }

            }

            private void Controls_Click(object sender, RoutedEventArgs e)
            {
                Button button = (Button)sender;
                switch (button.Name)
                {

                    case "ContinueButton":
                        //Continue Button
                        NavigationService.Navigate(new Uri("Location.xaml", UriKind.Relative));
                        break;
                    case "BackButton":
                        //Back Button
                        BackButton.Visibility = Visibility.Hidden;
                        IslandName.Content = "Choose an Island";
                        IslandDescription.Visibility = Visibility.Hidden;
                        IslandDescriptionBackground.Visibility = Visibility.Hidden;
                        ContinueButton.Visibility = Visibility.Hidden;
                        break;
                case "QuestButton":
                    //Quest Button
                    MessageBox.Show(MainWindow.game.QuestDescription);
                    break;

            }
            }
        
    } 
} 


