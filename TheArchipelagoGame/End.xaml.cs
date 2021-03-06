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
    /// Interaction logic for End.xaml
    /// </summary>
    public partial class End : Page
    {
        public End()
        {
            InitializeComponent();
            IslandDescription.Text = MainWindow.game.CurrentIsland.Description;
            IslandTitle.Content = " Thanks for Playing!";
        }

        private void NavigateButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
