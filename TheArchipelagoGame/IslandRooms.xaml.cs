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
            ItemButtonTwo.Content = MainWindow.game.CurrentIsland.Item[1].Name;
            IslandTitle.Content = MainWindow.game.CurrentIsland.Rooms[0].Name;
            IslandNarration.Text = MainWindow.game.CurrentIsland.Rooms[1].Description;
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

        //Backbutton
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
        //Second Item Button 
        private void ItemButtonTwo_Click(object sender, RoutedEventArgs e)
        {

            string items = String.Empty;
            string requiredItems = MainWindow.game.CurrentIsland.GameNPC.RequiredItem.Name;
            string requiredItemsTwo = MainWindow.game.CurrentIsland.GameNPC.RequiredItemTwo.Name;
            if (MainWindow.game.player.SearchInventory(requiredItems) && MainWindow.game.player.SearchInventory(requiredItemsTwo))
            {
                ItemButtonTwo.Visibility = Visibility.Visible;
                items = MainWindow.game.CurrentIsland.Item[1].Name;
                if (!MainWindow.game.player.SearchInventory(items) && !MainWindow.game.NPCInventory.Contains(items))
                {
                    MainWindow.game.player.Trade(items, requiredItems);
                    this.NavigationService.Refresh();
                    MessageBox.Show($"You have obtained {items}");
                }
                else
                {
                    MessageBox.Show($"You Arleady have {items} in your inventory");
                }
            }
            else
            {
                MessageBox.Show($"You do not have {requiredItems} & {requiredItemsTwo} in inventory.");
            }




        }
    }
}
