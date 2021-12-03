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
    /// Interaction logic for Location.xaml
    /// </summary>
    public partial class Location : Page
    {
        public Location()
        {
            InitializeComponent();
            IslandTitle.Content = MainWindow.game.CurrentIsland.Name;
            IslandNarration.Text = MainWindow.game.CurrentIsland.Narration;

            ItemButtonOne.Content = MainWindow.game.CurrentIsland.Item[0].Name;
            ItemButtonOne.ToolTip = MainWindow.game.CurrentIsland.Item[0].Description;

            ItemButtonTwo.Content = MainWindow.game.CurrentIsland.Item[1].Name;
            ItemButtonTwo.ToolTip = MainWindow.game.CurrentIsland.Item[1].Description;

            RoomButton.Content = MainWindow.game.CurrentIsland.Rooms[0].Name;
            RoomButton.ToolTip = MainWindow.game.CurrentIsland.Rooms[0].Description;

            string inventory = String.Empty;

            foreach (string item in MainWindow.game.player.Inventory)
            {
                inventory += $"{item}\n";
            }
            InventoryList.Content = inventory;

        }

        //Side Buttons
        private void SideBarButtons_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string itemName = String.Empty;

            switch (button.Name)
            {
                case "InventoryButton":
                    //InventoryClick
                    InventoryList.Visibility = Visibility.Visible;
                    InventoryTitle.Visibility = Visibility.Visible;
                    InventoryButton.Visibility = Visibility.Hidden;
                    SidebarTitle.Visibility = Visibility.Hidden;
                    BackButton.Visibility = Visibility.Hidden;
                    BackButtonInventory.Visibility = Visibility.Visible;
                    break;

                case "BackButtonInventory":
                    //Inventory Back Button
                    InventoryList.Visibility = Visibility.Hidden;
                    InventoryTitle.Visibility = Visibility.Hidden;
                    InventoryButton.Visibility = Visibility.Visible;
                    SidebarTitle.Visibility = Visibility.Visible;
                    BackButton.Visibility = Visibility.Visible;
                    BackButtonInventory.Visibility = Visibility.Hidden;
                    break;

                case "BackButton":
                    //Back Button
                    NavigationService.GoBack();
                    break;

                case "QuestButton":
                    //Quest Button
                    MessageBox.Show(MainWindow.game.QuestDescription);
                    break;
            }
        }
        //Middle Buttons
        private void MiddleButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string itemName = String.Empty;

            switch (button.Name)
            {
                case "ItemButtonOne":
                    //Item Button 1
                    string items = String.Empty;

                    items = MainWindow.game.CurrentIsland.Item[0].Name;
                    if (!MainWindow.game.player.SearchInventory(items) && !MainWindow.game.NPCInventory.Contains(items))
                    {
                        MainWindow.game.player.InventoryAdd(items);
                        this.NavigationService.Refresh();
                        MessageBox.Show($"You have Aquired {items}!");
                    }
                    else
                    {
                        MessageBox.Show($"You Arleady have {items} in your inventory.");
                    }
                    break;

                case "ItemButtonTwo":
                    //Item Button 2
                    items = MainWindow.game.CurrentIsland.Item[1].Name;
                    if (!MainWindow.game.player.SearchInventory(items) && !MainWindow.game.NPCInventory.Contains(items))
                    {
                        MainWindow.game.player.InventoryAdd(items);
                        this.NavigationService.Refresh();
                        MessageBox.Show($"You have Aquired {items}!");
                    }
                    else
                    {
                        MessageBox.Show($"You Arleady have {items} in your inventory.");
                    }
                    break;

                case "RoomButton":
                    //Room Button
                    NavigationService.Navigate(new Uri("IslandRooms.xaml", UriKind.Relative));
                    break;

            }
            
        }



    }
}
