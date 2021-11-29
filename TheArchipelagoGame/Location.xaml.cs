﻿using System;
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
            IslandNarration.Content = MainWindow.game.CurrentIsland.Narration;
            ItemButton.Content = MainWindow.game.CurrentIsland.Item[0].Name;



            string inventory = String.Empty;

            foreach (string item in MainWindow.game.player.Inventory)
            {
                inventory += $"{item}\n";
            }
            InventoryList.Content = inventory;

        }
        //Back Button
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        //Quest Button
        private void QuestButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(MainWindow.game.QuestDescription);
        }

        //Item Button

        private void ItemButton_Click(object sender, RoutedEventArgs e)
        {
            string items = String.Empty;


            items = MainWindow.game.CurrentIsland.Item[0].Name;
            if (!MainWindow.game.player.SearchInventory(items) && !MainWindow.game.NPCInventory.Contains(items))
            {
                MainWindow.game.player.InventoryAdd(items);
                this.NavigationService.Refresh();
            }
            else
            {
                MessageBox.Show($"You Arleady have {items} in your inventory");
            }
        }
        
        private void ItemButtonTwo_Click(object sender, RoutedEventArgs e)
        {
            string items = String.Empty;
            string requiredItems = MainWindow.game.CurrentNPC.RequiredItem.Name;

            if (MainWindow.game.player.SearchInventory(requiredItems))
                ItemButtonTwo.Visibility = Visibility.Visible;
            {
                items = MainWindow.game.CurrentIsland.Item[1].Name;
                if (!MainWindow.game.player.SearchInventory(items) && !MainWindow.game.NPCInventory.Contains(items))
                {
                    MainWindow.game.player.InventoryAdd(items);
                    this.NavigationService.Refresh();
                }
                else
                {
                    MessageBox.Show($"You Arleady have {items} in your inventory");
                }
            }
            else
            {
                MessageBox.Show($"You do not have {items} in inventory.");
            }
        }
            //Inventory Button
            private void InventoryButton_Click(object sender, RoutedEventArgs e)
        {
            
            InventoryList.Visibility = Visibility.Visible;
            InventoryTitle.Visibility = Visibility.Visible;
            InventoryButton.Visibility = Visibility.Hidden;
            SidebarTitle.Visibility= Visibility.Hidden;
            BackButton.Visibility = Visibility.Hidden;
            BackButtonInventory.Visibility = Visibility.Visible;
            
           
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
