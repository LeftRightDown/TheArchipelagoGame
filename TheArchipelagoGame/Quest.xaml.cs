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
    /// Interaction logic for Quest.xaml
    /// </summary>
    public partial class Quest : Page
    {
        public Quest()
        {
            InitializeComponent();
            QuestDescription.Text = MainWindow.game.QuestDescription;
        }

        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("TropicalSea.xaml", UriKind.Relative));
        }
    }
}
