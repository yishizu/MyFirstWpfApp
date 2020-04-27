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

namespace WpfApp10_RadioButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rbMaybe.IsChecked = true;
        }

        private void RadioButton_Checked_Yes(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you! I like you, too!");
        }

        private void RadioButton_Checked_Maybe(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hmmmm, okay...");
        }

        private void RadioButton_Checked_No(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I am sad, but okay");
        }
    }
}
