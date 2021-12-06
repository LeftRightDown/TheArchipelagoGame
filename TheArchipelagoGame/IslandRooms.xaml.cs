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
            ImageSourceConverter imageSourceConverter = new ImageSourceConverter();
            Uri roomimage = new Uri(MainWindow.game.CurrentIsland.Rooms[0].ImagePath, UriKind.Relative);
            RoomImage.Source = (ImageSource)imageSourceConverter.ConvertFrom(roomimage);


            string inventory = String.Empty;
            ItemButtonThree.Content = MainWindow.game.CurrentIsland.Item[2].Name; 
            ItemButtonThree.ToolTip = MainWindow.game.CurrentIsland.Item[2].Description;

            IslandTitle.Content = MainWindow.game.CurrentIsland.Rooms[0].Name;
            IslandNarration.Text = MainWindow.game.CurrentIsland.Rooms[0].Description;
           

            foreach (string item in MainWindow.game.player.Inventory)
            {
                inventory += $"{item}\n";
            }
            InventoryList.Content = inventory;

        }

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
        //Second Item Button 
        private void ItemButtonTwo_Click(object sender, RoutedEventArgs e)
        {

            string items = String.Empty;
            string requiredItems = MainWindow.game.CurrentIsland.GameNPC.RequiredItem.Name;
            string requiredItemsTwo = MainWindow.game.CurrentIsland.GameNPC.RequiredItemTwo.Name;

            string EndingRequirementOne = MainWindow.game.Islands[3].Item[0].Name;
            string EndingRequirementTwo = MainWindow.game.Islands[3].Item[1].Name;

            if (MainWindow.game.player.Inventory.Contains(EndingRequirementOne) && MainWindow.game.player.Inventory.Contains(EndingRequirementTwo))
            {
                NavigationService.Navigate(new Uri("End.xaml", UriKind.Relative));

            }
           else if (MainWindow.game.player.SearchInventory(requiredItems) && MainWindow.game.player.SearchInventory(requiredItemsTwo))
            {
                items = MainWindow.game.CurrentIsland.Item[2].Name;
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
