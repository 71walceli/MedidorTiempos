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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class ActivitiesPane : Page
    {
        public ActivitiesPane()
        {
            InitializeComponent();
        }

        private void ActivityList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // TODO When iten is selected, New
        }
    }
}
