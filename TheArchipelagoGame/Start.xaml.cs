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
    /// Interaction logic for Start.xaml
    /// </summary>
    public partial class Start : Page
    {
        public Start()
        {
            InitializeComponent();

        }

        private void NavigateButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Name)
            {
                case "Button1":
                    //Start
                   NavigationService.Navigate(new Uri("Quest.xaml", UriKind.Relative));
                    break;
                case "Button2":
                    //Credits
                    MessageBox.Show(@"
     Creator: Zachary Tan

                            ");
                    break;
                case "Button3":
                    //Exit
                    Environment.Exit(0);
                    break;
            }
           
        }
       
    }
}