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

namespace CheckBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void cbAllCheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newval = (cbAllTopings.IsChecked == true);
            cbSalani.IsChecked = newval;
            cbMushrooms.IsChecked = newval;
            cbMozzarella.IsChecked = newval;
        }
        private void cbSingleCheckedChnged(object sender, RoutedEventArgs e)
        {
            cbAllTopings.IsChecked = null;
            if((cbSalani.IsChecked==true) && (cbMozzarella.IsChecked==true)&&(cbMushrooms.IsChecked==true))
                    {
                cbAllTopings.IsChecked = true;
            }
            if ((cbSalani.IsChecked == false) && (cbMozzarella.IsChecked == false) && (cbMushrooms.IsChecked == false))
            {
                cbAllTopings.IsChecked = false;
            }
        }
    }
}
