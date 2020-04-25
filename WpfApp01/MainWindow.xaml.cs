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

namespace MyFirsWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid grid = new Grid();
            this.Content = grid;
            Button btn = new Button();
            btn.FontSize = 20;
            btn.Height = 35;
            btn.Width = 400;
            WrapPanel wp = new WrapPanel();
            TextBlock tb = new TextBlock();
            tb.Text = "This is Button";
            tb.Foreground = Brushes.Red;
            wp.Children.Add(tb);

            tb = new TextBlock();
            tb.Text = "Next buttonText";
            tb.Foreground = Brushes.Blue;
            wp.Children.Add(tb);

            tb = new TextBlock();
            tb.Text = "Last buttonText";
            tb.Foreground = Brushes.Black;
            wp.Children.Add(tb);

            btn.Content = wp;
            grid.Children.Add(btn);


        }
    }
}
