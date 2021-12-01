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
    /// Interaction logic for IslandRooms.xaml
    /// </summary>
    public partial class IslandRooms : Page
    {
        public IslandRooms()
        {
            InitializeComponent();

            string inventory = String.Empty;

            foreach (string item in MainWindow.game.player.Inventory)
            {
                inventory += $"{item}\n";
            }
            InventoryList.Content = inventory;

        }



        private void InventoryButton_Click(object sender, RoutedEventArgs e)
        {
            InventoryList.Visibility = Visibility.Visible;
            InventoryTitle.Visibility = Visibility.Visible;
            InventoryButton.Visibility = Visibility.Hidden;
            SidebarTitle.Visibility = Visibility.Hidden;
            BackButton.Visibility = Visibility.Hidden;
            BackButtonInventory.Visibility = Visibility.Visible;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void QuestButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(MainWindow.game.QuestDescription);
        }

        private void BackButtonInventory_Click(object sender, RoutedEventArgs e)
        {
            InventoryList.Visibility = Visibility.Hidden;
            InventoryTitle.Visibility = Visibility.Hidden;
            InventoryButton.Visibility = Visibility.Visible;
            SidebarTitle.Visibility = Visibility.Visible;
            BackButton.Visibility = Visibility.Visible;
            BackButtonInventory.Visibility = Visibility.Hidden;
        }
    }
}
