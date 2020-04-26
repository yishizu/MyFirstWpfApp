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

namespace WpfApp07_ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>();
            matches.Add(new Match { Team1 = "Aston Villa F.C", Team2 = "Norwich City F.C", Score1 = 2, Score2 = 1, Comletion = 85 });
            matches.Add(new Match { Team1 = "Arsenal F.C", Team2 = "Chelsea F.C", Score1 = 0, Score2 = 1, Comletion = 86 });
            matches.Add(new Match { Team1 = "Brighton & Hove Albion F.C", Team2 = "Crystal Palace F.C", Score1 = 3, Score2 = 1, Comletion = 87 });
            matches.Add(new Match { Team1 = "Burnley F.C", Team2 = "Liverpool F.C", Score1 = 1, Score2 = 0, Comletion = 89 });
            lbMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lbMatches.SelectedItem != null)
            {
                MessageBox.Show("Selected Match: "
                    + (lbMatches.SelectedItem as Match).Team1 + " "
                    + (lbMatches.SelectedItem as Match).Team2 + " "
                    + (lbMatches.SelectedItem as Match).Score1 + " "
                    + (lbMatches.SelectedItem as Match).Score2 + " "
                    );
            }
        }
    }
}
