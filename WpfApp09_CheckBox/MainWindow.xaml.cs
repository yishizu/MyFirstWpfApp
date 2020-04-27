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

namespace WpfApp09_CheckBox
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

        private void cbAllTopping_Checked(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllTopping.IsChecked == true);
            cbSalami.IsChecked = newVal;
            cbMozarella.IsChecked = newVal;
            cbMushrooms.IsChecked = newVal;
        }

        private void cbSingle_Checked(object sender, RoutedEventArgs e)
        {
            cbAllTopping.IsChecked = null;
            if((cbSalami.IsChecked == true) && (cbMushrooms.IsChecked == true) && (cbMozarella.IsChecked == true))
            {
                cbAllTopping.IsChecked = true;
            }

            if((cbSalami.IsChecked == false) && (cbMushrooms.IsChecked == false) && (cbMozarella.IsChecked == false))
            {
                cbAllTopping.IsChecked =false;
            };
            
            MessageBox.Show("Thanks for adding!");

        }

    }
}
