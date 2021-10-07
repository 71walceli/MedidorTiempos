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

namespace MedidorTiemposCSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string MainContent
        {
            get {
                string uriString = ContentPane.Source.ToString();
                uriString = uriString.Split('/')[1];
                return uriString.Replace("Pane.xaml", ""); 
            }
            set
            {
                (FindName($"{MainContent}PaneButton") as Button).Style = (Style)FindResource("BigButton");
                ContentPane.Source = new Uri($"{value}Pane.xaml", UriKind.Relative);
                PaneMenu.Visibility = Visibility.Hidden;
                (FindName($"{value}PaneButton") as Button).Style = (Style)FindResource("BigButtonActive");
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            MainContent = "Activities";
        }

        public void HideNotificationBar()
        {
        }

        public void ShowNotificationBar()
        {
        }

        private void ActivitiesButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent = "Activities";
        }

        private void GraphicsButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent = "Graphs";
        }

        private void TagsButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent = "Tags";
        }

        private void ExportsButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent = "Backups";
        }

        private void PaneMenuButton_Click(object sender, RoutedEventArgs e)
        {
            PaneMenu.Visibility = PaneMenu.Visibility==Visibility.Hidden ? Visibility.Visible : Visibility.Hidden;
        }
    }
}
